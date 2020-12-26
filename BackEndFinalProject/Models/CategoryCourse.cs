using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndFinalProject.Models
{
    public class CategoryCourse
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}
