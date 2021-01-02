using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndFinalProject.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        [Required, MaxLength(200)]
        public string Name { get; set; }
        [Required, MaxLength(200)]
        public string Surname { get; set; }
        [Required, MaxLength(200)]
        public string Position { get; set; }
        [Required, MaxLength(150)]
        public string Image { get; set; }
        public string Facebook { get; set; }
        public string Pinterest { get; set; }
        public string Vimeo { get; set; }
        public string Twitter { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedTime { get; set; }
        public virtual TeacherDetail TeacherDetail { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
