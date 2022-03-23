﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace P01_StudentSystem.Data.Models
{
    class Course
    {
        public Course()
        {
            StudentsEnrolled = new HashSet<Student>();
            Resources = new HashSet<Resource>();
            HomeworkSubmissions = new HashSet<Homework>();

        }
        public int CourseId { get; set; }
        [MaxLength(80)]
        [Column(TypeName ="varchar(2048)")]
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }
        [NotMapped]
        public ICollection<Student> StudentsEnrolled { get; set; }
        public ICollection<Resource> Resources { get; set; }
        public ICollection<Homework> HomeworkSubmissions { get; set; }

    }
}
//o CourseId
//o	Name (up to 80 characters, unicode)
//o Description(unicode, not required)
//o StartDate
//o	EndDate
//o	Price
