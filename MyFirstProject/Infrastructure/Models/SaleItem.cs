﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Infrastructure.Models
{
    public class SaleItem
    {
        public int ItemNumber { get; set; }
        public Product Product { get; set; }
        public int ItemCount { get; set; }

    }
}
