﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace EMICalculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var obj1 = new EmiProcessor();
            

            Console.WriteLine("Enter price of vehicle");
            obj1.Principal = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter rate of interest ");
            obj1.interest = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter loan duration");
            obj1.time = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter monthly compounding");
            obj1.n = Convert.ToInt32(Console.ReadLine());

            

            Console.WriteLine($"EMI is: {obj1.CalculateEmi()} INR");


        }
    }
}