using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11Ex1
{
    class StrategieAlimente : ITaxesCalculatorStrategy
    {
        public double ApplyTaxes(double pret)
        {
            return pret + 0.09 * pret;
        }
    }
}
