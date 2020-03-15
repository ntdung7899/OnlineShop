﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShop.Areas.Admin.Models
{
    [Serializable]
    public class LoginModel
    {
        [Required]
        public string Username { get; set; }
        public string Password { get; set; }
        public bool RemeberMe { get; set; }
    }
}