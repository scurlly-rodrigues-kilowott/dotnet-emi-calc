using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMICalculator
{
    internal class EmiProcessor
    {
        internal decimal P { private get; set; }

        internal decimal i { private get; set; }

        internal int n { private get; set; }

        internal int t { private get; set; }

        public decimal CalculateEmi()
        {
            t = t * n;
            i = 1 + (i / n);
           
            decimal e = P * ((decimal) (Math.Pow((double)i,(double)t))) / 24;

            decimal emi = Math.Round(e, 2);

            return emi;

            

        }
       
    }

}
