using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace P01_StudentSystem.Data.Models
{
    class Homework
    {
        public int HomeworkId { get; set; }
        [Column(TypeName = "varchar(290)")]
        public string Content { get; set; }
        public ContentType ContentType  { get; set; }
        public DateTime SubmissionTime { get; set; }
        public virtual Student Student { get; set; }
        public int StudentId { get; set; }
        public virtual Course Course { get; set; }
        public int CourseId { get; set; }

    }

    public enum ContentType
    {
        Application = 1,
        Pdf = 2,
        Zip = 3
    }
}
//o HomeworkId
//o	Content (string, linking to a file, not unicode)
//o ContentType(enum – can be Application, Pdf or Zip)
//o SubmissionTime
//o	StudentId
//o	CourseId
