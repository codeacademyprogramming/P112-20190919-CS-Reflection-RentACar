﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Models
{
    class Manufacturer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CarModel> CarModels { get; set; }

        public bool Status { get; set; }

    }
}
