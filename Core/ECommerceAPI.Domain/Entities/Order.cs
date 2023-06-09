﻿using ECommerceAPI.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Domain.Entities
{
    public class Order: BaseEntity
    {
        public string Description { get; set; }
        public string DeliveryAddress { get; set; }
        public ICollection<Product> Products { get; set; }
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
    }
}
