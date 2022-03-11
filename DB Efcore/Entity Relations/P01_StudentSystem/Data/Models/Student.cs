﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace P01_StudentSystem.Data.Models
{
    class Student
    {
        public Student()
        {
            CourseEnrollments = new HashSet<Course>();
            HomeworkSubmissions = new HashSet<Homework>();
        }
        
        public int StudentId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Column(TypeName = "char(10)")]
        public string PhoneNumber { get; set; }
        public DateTime RegisteredOn { get; set; }
        public DateTime? BirthDay { get; set; }
        [NotMapped]
        public ICollection<Course> CourseEnrollments { get; set; }
        public ICollection<Homework> HomeworkSubmissions { get; set; }


    }
  
}
//o PhoneNumber(exactly 10 characters, not unicode, not required)
//o RegisteredOn
//o	Birthday (not required)
