using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndFinalProject.Models
{
    public class Slider
    {
        public int Id { get; set; }
        [Required,MaxLength(150)]
        public string Image { get; set; }
        [MaxLength(150)]
        public string Title { get; set; }
        [MaxLength(250)]
        public string Subtitle { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
