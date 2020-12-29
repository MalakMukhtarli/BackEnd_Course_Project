using BackEndFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndFinalProject.ViewModel
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public List<Notice> Notices { get; set; }
        public HomeVideo HomeVideos { get; set; }
    }
}
