﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindKurumsal2.Entities
{
   public  class Order
    {
        public int OrderId { get; set; }

        public DateTime OrderDate { get; set; }

        public string ShipCity { get; set; }

        public string ShipCountry { get; set; }
    }
}
