using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndFinalProject.Models
{
    public class CategoryEvent
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public int EventId { get; set; }
        public virtual Event Event { get; set; }
    }
}
