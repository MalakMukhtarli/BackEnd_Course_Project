using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndFinalProject.Models
{
    public class About
    {
        public int Id { get; set; }
        [Required, MaxLength(150)]
        public string Image { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
    }
}
