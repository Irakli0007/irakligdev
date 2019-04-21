using System;
using System.IO;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using irakligdev.Models;

namespace irakligdev.Models
{
    public class PWHash
    {
        public static bool ComparePassHash(String username, String password)
        {
            using(var context = new UserContext())
            {
                var user = context.User.Where(u => u.Username == username).FirstOrDefault<User>();
                if(user == null)
                {
                    return false;
                }
                using (SHA256 mySHA256 = SHA256.Create())
                {
                    try
                    {
                        var stream = new MemoryStream();
                        var writer = new StreamWriter(stream);
                        writer.Write(password);
                        writer.Flush();
                        stream.Position = 0;

                        byte[] hashValue = mySHA256.ComputeHash(stream);
                        if(user.Password == hashValue)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    catch (IOException e)
                    {
                        Console.WriteLine($"I/O Exception: {e.Message}");
                        return false;
                    }
                    catch (UnauthorizedAccessException e)
                    {
                        Console.WriteLine($"Access Exception: {e.Message}");
                        return false;
                    }
                }
            }
            
        }

        public static void NewUserHash(String username, String password)
        {
            using (var context = new UserContext())
            {
                var user = context.User.Where(u => u.Username == username).FirstOrDefault<User>();

                if (user == null)
                {
                    using (SHA256 mySHA256 = SHA256.Create())
                    {
                        try
                        {
                            var stream = new MemoryStream();
                            var writer = new StreamWriter(stream);
                            writer.Write(password);
                            writer.Flush();
                            stream.Position = 0;

                            byte[] hashValue = mySHA256.ComputeHash(stream);

                            var newUser = new User() {
                                Username = username,
                                Password = hashValue
                            };

                            context.User.Add(newUser);
                            context.SaveChanges();

                        }
                        catch (IOException e)
                        {
                            Console.WriteLine($"I/O Exception: {e.Message}");
                        }
                        catch (UnauthorizedAccessException e)
                        {
                            Console.WriteLine($"Access Exception: {e.Message}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("User already exists.");
                }
            }
        }
    }
}