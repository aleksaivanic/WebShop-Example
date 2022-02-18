using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Model
{
    public class AccommodationPayment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public AccommodationPayment()
        {
        }
    }
}
