﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Domain.Entities
{
    public class CarPricing
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public Car car { get; set; }
        public int PricingId {  get; set; }
        public Pricing pricing { get; set; }
        public decimal Amount { get; set; }

    }
}
