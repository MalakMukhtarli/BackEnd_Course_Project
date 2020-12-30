using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndFinalProject.Models
{
    public class Bio
    {
        public int Id { get; set; }
        [Required,MaxLength(150)]
        public string SmallLogo { get; set; }
        [Required, MaxLength(150)]
        public string BigLogo { get; set; }
        public string About { get; set; }
        public string Facebook { get; set; }
        public string Pinterest { get; set; }
        public string Vimeo { get; set; }
        public string Twitter { get; set; }
        [Required, MaxLength(200)]
        public string Address { get; set; }
        [Required]
        public string Phone { get; set; }
        public string AdditionalPhone { get; set; }
        [Required]
        public string Email { get; set; }
        public string Webpage { get; set; }
    }
}
