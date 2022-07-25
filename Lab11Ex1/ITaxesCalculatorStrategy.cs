using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11Ex1
{
    interface ITaxesCalculatorStrategy
    {
        public double ApplyTaxes(double pret);
    }
}
