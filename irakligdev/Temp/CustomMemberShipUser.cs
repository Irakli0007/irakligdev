using irakligdev.DBEntities;
using System;
using System.Collections.Generic;
using System.Web.Security;

namespace CustomAuthenticationMVC.CustomAuthentication
{
    public class CustomMembershipUser : MembershipUser
    {

        public int UserId { get; set; }
        


        public CustomMembershipUser(User user) : base("CustomMembership", user.Username, user.UserId, string.Empty, string.Empty, string.Empty, true, false, DateTime.Now, DateTime.Now, DateTime.Now, DateTime.Now, DateTime.Now)
        {
            UserId = user.UserId;
           
        }
    }
}