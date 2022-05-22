using AspTask1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspTask1.ViewModel
{
    public class HomeVM
    {
        public List<SliderItem> SliderItems{ get; set; }
        public List<Category> Categories{ get; set; }
    }
}
