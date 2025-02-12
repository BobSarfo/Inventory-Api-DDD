﻿using Inventory.Core.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Core.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }    
        public ProductName? ProductName { get; set; }
        public decimal Price { get; set; }
    }
}