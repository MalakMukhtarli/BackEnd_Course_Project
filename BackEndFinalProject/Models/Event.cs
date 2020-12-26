using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndFinalProject.Models
{
    public class Event
    {
        public int Id { get; set; }
        [Required, MaxLength(150)]
        public string Image { get; set; }
        [Required, MaxLength(150)]
        public string Title { get; set; }
        [Required]
        public DateTime TimeStart { get; set; }
        [Required]
        public DateTime TimeEnd { get; set; }
        [Required]
        public string Venue { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedTime { get; set; }
        public virtual EventDetail EventDetail { get; set; }
        public ICollection<CategoryEvent> CategoryEvents { get; set; }
    }
}
