using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11Ex1
{
    class Product
    {
        public string get_Name;
        public Guid get_Id;
        public double get_GrossPrice;
        public Tag get_Tag;
        
        private double netPrice { get; set; }

        public Product(string get_Name, Guid get_Id, double get_GrossPrice, ITaxesCalculatorStrategy strategy)
        {
            this.get_Name = get_Name;
            this.get_Id = get_Id;
            this.get_GrossPrice = get_GrossPrice;
            this.netPrice = strategy.ApplyTaxes(get_GrossPrice);
            this.get_Tag = new Tag(get_Id, get_Name, netPrice);
        }
    }
}
