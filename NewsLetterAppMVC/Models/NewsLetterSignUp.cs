using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsLetterAppMVC.Models
{
    public class NewsLetterSignUp
    {
        public string FirstName { get; set; }
        public int id { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string SocialSecurityNumber { get; set; }
    }
}