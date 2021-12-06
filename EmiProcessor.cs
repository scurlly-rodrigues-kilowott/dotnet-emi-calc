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

        internal decimal Interest { private get; set; }

        internal int MonthlyCompound { private get; set; }

        internal int Time { private get; set; }

        public decimal CalculateEmi()
        {
            Time = Time * MonthlyCompound;
            Interest = 1 + (Interest / MonthlyCompound);
           
            decimal Temp = Principal * ((decimal) (Math.Pow((double)Interest,(double)Time))) / 24;

            decimal EMI = Math.Round(Temp, 2);

            return EMI;

            

        }
       
    }

}
