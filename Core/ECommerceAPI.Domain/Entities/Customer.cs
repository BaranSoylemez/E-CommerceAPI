﻿using ECommerceAPI.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Domain.Entities
{
    public class Customer: BaseEntity
    {
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public ICollection<Order> Orders { get; set; }

    }
}
