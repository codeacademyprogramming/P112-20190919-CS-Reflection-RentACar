using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Models
{
    class Order
    {
        public int Id { get; set; }
        public DateTime RentStartDate { get; set; }
        public DateTime RentEndDate { get; set; }

        public int  CarId { get; set; }
        public Car Car { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public decimal DiscountPrice { get; set; }

        public decimal OrderPrice { get; set; }

        public bool Status { get; set; }


    }
}
