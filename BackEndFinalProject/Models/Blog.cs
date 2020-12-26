using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndFinalProject.Models
{
    public class Blog
    {
        public int Id { get; set; }
        [Required,MaxLength(200)]
        public string Title { get; set; }
        [Required,MaxLength(150)]
        public string Image { get; set; }
        public string ByName { get; set; }
        public DateTime AddedTime { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedTime { get; set; }
        public virtual BlogDetail BlogDetail { get; set; }
        public ICollection<CategoryBlog> CategoryBlogs { get; set; }
    }
}
