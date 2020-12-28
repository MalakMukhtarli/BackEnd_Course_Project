using BackEndFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndFinalProject.ViewModel
{
    public class SidebarVM
    {
        public List<Category> Categories { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
