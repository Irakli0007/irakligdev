﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using irakligdev.Models;

namespace irakligdev.Controllers
{
    public class MainController : Controller
    {
        public ActionResult Index()
        {
            

            return View();
        }
        
        public ActionResult Start()
        {
            using (var context = new ScoreContext())
            {
                Score s = new Score();
                try
                {
                    Object obj = context.Score.First();
                    Score currScore = (Score)obj;
                    s.Value = currScore.Value;
                }
                catch (InvalidOperationException e)
                {
                }
                ViewBag.Message = s.Value;
                
                return View();
            }
        }

        public ActionResult Grow()
        {
            using (var context = new ScoreContext())
            {
                Score s = new Score();
                try
                {
                    Object obj = context.Score.First();
                    Score currScore = (Score)obj;
                    s.Value = ++currScore.Value;
                    context.Score.Remove(currScore);
                    context.SaveChanges();
                    context.Score.Add(s);
                }
                catch (InvalidOperationException e)
                {
                    context.Score.Add(s);
                }
                context.SaveChanges();
                ViewBag.Message = s.Value;

            }
            return View("Start");
        }

       
        public ActionResult Register(User user)
        {
            if(ModelState.IsValid)
            {
                bool Registered = PWHash.NewUserHash(user.Username, user.SPassword);
                               
                //if success return with success view?
            }

            return View();
        }

        
        public ActionResult Login(User user)
        {
            if (ModelState.IsValid)
            {
                bool LoggedIn = PWHash.ComparePassHash(user.Username, user.SPassword);
                //if success return with success view?
            }

            return View();
        }


    }
}