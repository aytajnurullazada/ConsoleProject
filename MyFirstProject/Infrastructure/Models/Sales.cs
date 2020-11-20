using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Infrastructure.Models
{
    class Sales
    {

        public int SaleNumber { get; set; }
        public Double SaleAmount { get; set; }
        public List <SaleItem>  Saleİtems { get; set; }
        public DateTime SaleDate { get; set; }

    }
}
