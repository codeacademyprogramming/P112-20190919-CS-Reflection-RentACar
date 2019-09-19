using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Models
{
    class Car
    {
        public int Id { get; set; }

        public int ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; }

        public int ModelId { get; set; }
        public CarModel Model { get; set; }

        public int Year { get; set; }

        public decimal DailyPrice { get; set; }

        public string PlateNumber { get; set; }
        public string Color { get; set; }

        public List<Order> Orders { get; set; }

        public bool Available { get; set; }

        public bool Status { get; set; }
    }
}
