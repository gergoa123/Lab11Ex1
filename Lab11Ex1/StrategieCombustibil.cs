using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11Ex1
{
    class StrategieCombustibil : ITaxesCalculatorStrategy
    {
        private double cantitate { get; set; }

        public StrategieCombustibil(double cantitate)
        {
            this.cantitate = cantitate;
        }

        public double ApplyTaxes(double pret)
        {
            return pret + pret * 0.19 + (1.8 * cantitate) + (1.3 * cantitate);
        }
    }
}
