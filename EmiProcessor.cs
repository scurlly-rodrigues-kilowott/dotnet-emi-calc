using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMICalculator
{
    internal class EmiProcessor
    {
        internal decimal Principal { private get; set; }

        internal decimal interest { private get; set; }

        internal int n { private get; set; }

        internal int time { private get; set; }

        public decimal CalculateEmi()
        {
            time = time * n;
            interest = 1 + (interest / n);
           
            decimal e = Principal * ((decimal) (Math.Pow((double)interest,(double)time))) / 24;

            decimal emi = Math.Round(e, 2);

            return emi;

            

        }
       
    }

}
