using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Models
{
    class User
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string PIN { get; set; }
        public string Phone { get; set; }
        public DateTime Birthday { get; set; }

        public List<Order> Orders { get; set; }

        public bool Status { get; set; }

    }
}
