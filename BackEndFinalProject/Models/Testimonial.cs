using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndFinalProject.Models
{
    public class Testimonial
    {
        public int Id { get; set; }
        [MaxLength(150)]
        public string Image { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string FullName { get; set; }
        public string Note { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
