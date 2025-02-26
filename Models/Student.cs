﻿using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Class { get; set; }
        public string Photo { get; set; } 

    }
}
