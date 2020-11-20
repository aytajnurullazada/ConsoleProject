﻿using MyFirstProject.Infrastructure.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Infrastructure
{
    public class Product
    {
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public int ProductCount { get; set; }
        public string ProductCode { get; set; }
        public Category Category { get; set; }
        
    }
}
