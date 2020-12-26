using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndFinalProject.Models
{
    public class CourseDetail
    {
        public int Id { get; set; }
        public string CourseAbout { get; set; }
        public string HowToApply { get; set; }
        public string Certification { get; set; }
        [Required]
        public DateTime CourseStartDate { get; set; }
        [Required]
        public int CourseDuration { get; set; }
        [Required]
        public int ClassDuration { get; set; }
        [Required, MaxLength(50)]
        public string SkillLevel { get; set; }
        [Required, MaxLength(50)]
        public string Language { get; set; }
        [Required]
        public int StudentsCount { get; set; }
        [Required, MaxLength(50)]
        public string Assessment { get; set; }
        [Required]
        public double Price { get; set; }
        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}
