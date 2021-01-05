using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndFinalProject.Models
{
    public class Subscribe
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(100),DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public bool IsDeleted { get; set; }
    }
}
