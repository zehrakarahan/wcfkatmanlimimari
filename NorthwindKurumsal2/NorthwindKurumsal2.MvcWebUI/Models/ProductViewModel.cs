using System.Collections.Generic;
using NorthwindKurumsal2.Entities;

namespace NorthwindKurumsal2.MvcWebUI.Models
{
    public class ProductViewModel
    {
        public object PagingInfo { get; set; }
        public List<Product> Productlar { get; set; }
    }
}