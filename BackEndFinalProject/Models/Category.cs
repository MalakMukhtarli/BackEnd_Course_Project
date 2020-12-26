using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndFinalProject.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; }
        public ICollection<CategoryCourse> CategoryCourses { get; set; }
        public ICollection<CategoryBlog> CategoryBlogs { get; set; }
        public ICollection<CategoryEvent> CategoryEvents { get; set; }

    }
}
