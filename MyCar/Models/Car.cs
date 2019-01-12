using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCar.Models
{
    public class Car
    {
        public int CarID { get; set; }
        public string CarName { get; set; }
        public DateTime AvailableDate { get; set; }
        public decimal Price { get; set; }
    }

}
