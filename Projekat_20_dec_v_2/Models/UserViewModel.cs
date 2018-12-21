using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;

namespace Projekat_20_dec_v_2.Models
{
    public class UserViewModel
    {
        public UserViewModel() { }

        public UserViewModel(ApplicationUser user)
        {
            ID = user.Id;
            Email = user.Email;
            Password = user.PasswordHash;

        }

        public string ID { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }

        public string RoleName { get; set; }
    }
}