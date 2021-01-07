using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndFinalProject.Models
{
    public class Course
    {
        public int Id { get; set; }
        [MaxLength(150)]
        public string Image { get; set; }
        [Required, MaxLength(150)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedTime { get; set; }
        public virtual CourseDetail CourseDetail { get; set; }
        public ICollection<CategoryCourse> CategoryCourses { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
