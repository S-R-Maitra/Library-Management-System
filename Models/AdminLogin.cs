﻿using System.ComponentModel.DataAnnotations;

namespace Library_Management_System.Models
{
    public class AdminLogin
    {
        [Key]
        public long Id { get; set; }


        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Password { get; set; }

    }
}