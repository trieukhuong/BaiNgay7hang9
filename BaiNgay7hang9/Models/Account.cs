﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BaiNgay7hang9.Models
{
    public class Account
    {
        //bắt buộc phải có 
        [Key]
        public string Usename { get; set; }
        public string Password { get; set; }

    }
}