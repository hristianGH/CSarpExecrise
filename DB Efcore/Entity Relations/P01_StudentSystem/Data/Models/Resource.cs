using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace P01_StudentSystem.Data.Models
{
    class Resource
    {
        public int ResourceId { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [ Column(TypeName = "varchar(2048)")]
        public string Url { get; set; }
        public ResourseType ResourseType { get; set; }
        public virtual Course Course { get; set; }
        public int CourseId { get; set; }


    }
    public enum ResourseType
    {
        Video = 1,
        Presentation = 2,
        Document = 3,
        Other = 4
    }
}
//o ResourceId
//o	Name (up to 50 characters, unicode)
//o Url(not unicode)
//o ResourceType(enum – can be Video, Presentation, Document or Other)
//o CourseId
