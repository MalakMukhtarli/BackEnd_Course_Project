using BackEndFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndFinalProject.ViewModel
{
    public class CourseCategoryVM
    {
        public Course Course { get; set; } 
        public List<Category> CategoriesView { get; set; }
        public List<int> Categories { get; set; }
        public CategoryCourse CategoryCourses { get; set; }
        
    }
}
