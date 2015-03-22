﻿using System;
using System.ComponentModel.DataAnnotations;

namespace HboFactFind.Domain
{
    public class User
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string SecondName { get; set; }

        [Required]
        public string EmailAddress { get; set; }

        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public string SessionToken { get; set; }

        [Required]
        public bool IsAdmin { get; set; }

        public DateTime LastLoggedIn { get; set; }
    }
}