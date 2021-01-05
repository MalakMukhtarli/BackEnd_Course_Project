using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndFinalProject.ViewModel
{
    public class SubscribeVM
    {
        [StringLength(100), DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public bool IsDeleted { get; set; }
    }
}
