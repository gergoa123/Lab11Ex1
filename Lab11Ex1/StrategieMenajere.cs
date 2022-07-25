using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11Ex1
{
    class StrategieMenajere : ITaxesCalculatorStrategy
    {
        public double ApplyTaxes(double pret)
        {
            return pret + pret * 0.19;
        }
    }
}
