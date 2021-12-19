using Fiorella.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorella.ViewModel
{
    public class HomeViewModel
    {
        public List<Slider> Sliders { get; set; }
        public SliderIntro SliderIntro { get; set; }
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }
        public InfoVideo InfoVideo { get; set; }
        public InfoIntro InfoIntro { get; set; }
        public ExpertIntro ExpertIntro { get; set; }
        public List<ExpertInfo> ExpertInfo { get; set; }
        public BlogIntro BlogIntro { get; set; }
        public List<BlogInfo> BlogInfos { get; set; }
        public List<Review> Reviews  { get; set; }


    }
}
