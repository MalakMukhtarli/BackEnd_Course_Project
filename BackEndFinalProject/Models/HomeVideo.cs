using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndFinalProject.Models
{
    public class HomeVideo
    {
        public int Id { get; set; }
        [Required,MaxLength(200)]
        public string VideoLink { get; set; }
    }
}
