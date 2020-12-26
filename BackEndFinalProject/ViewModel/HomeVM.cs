using BackEndFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndFinalProject.ViewModel
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public List<Course> Courses { get; set; }
        public List<CourseDetail> CourseDetails { get; set; }
        public List<Category> Categories { get; set; }
        public List<Event> Events { get; set; }
        public List<EventDetail> EventDetails { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<BlogDetail> BlogDetails { get; set; }
    }
}
