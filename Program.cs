using System;
using System.Collections.Generic;
using System.Linq;

namespace EMICalculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
         
            try
            {
                var obj1 = new EmiProcessor();

                Console.WriteLine("Enter price of vehicle");
                obj1.Principal = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Enter rate of interest ");
                obj1.Interest = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Enter loan duration in years");
                obj1.Time = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter monthly compounding");
                obj1.MonthlyCompound = Convert.ToInt32(Console.ReadLine());

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }
            finally
            {
                Console.WriteLine($"EMI is: {obj1.CalculateEmi()} INR");
            }

            

            

           


        }
    }
}