using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndFinalProject.Models
{
    public class EventDetail
    {
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
        [Required,MaxLength(150)]
        public string SpeakerName { get; set; }
        [Required]
        public string SpeakerPosition { get; set; }
        [Required,MaxLength(150)]
        public string SpeakerImage { get; set; }
        [ForeignKey("Event")]
        public int EventId { get; set; }
        public virtual Event Event { get; set; }
    }
}
