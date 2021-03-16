using System.Collections.Generic;
using BL;
using Entities;

namespace WebApp.Models
{
    public class IndexViewModel
    {
        public IEnumerable<ProductViewModel> ProductViewModels { get; set; }
        public PageViewModel PageViewModel { get; set; }
    }
}