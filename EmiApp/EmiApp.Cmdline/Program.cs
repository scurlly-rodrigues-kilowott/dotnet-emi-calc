﻿using System;

namespace EmiApp.Cmdline
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var emiRequest = new Request() { Principal = 100000, InterestRateInPercentage = 12, LoanDurationInYearCount = 2 };
            ICalculator emiCalculator = new Calculator();

            
            var emiMonthly = emiCalculator.CalculateMonthlyEmi(emiRequest);
        
            if (string.IsNullOrEmpty(emiMonthly.ErrorMessage))
                Console.WriteLine($"Monthly EMI is {emiMonthly.EmiPayment}");
            else 
                Console.WriteLine(emiMonthly.ErrorMessage);


            // fill other regions below...

            var emiDaily = emiCalculator.CalculateDailyEmi(emiRequest);

            if (string.IsNullOrEmpty(emiMonthly.ErrorMessage))
                Console.WriteLine($"Daily EMI is {emiDaily.EmiPayment}");
            else
                Console.WriteLine(emiMonthly.ErrorMessage);

            var emiContinous = emiCalculator.CalculateContinousEmi(emiRequest);

            if (string.IsNullOrEmpty(emiMonthly.ErrorMessage))
                Console.WriteLine($"Continous EMI is {emiContinous.EmiPayment}");
            else
                Console.WriteLine(emiMonthly.ErrorMessage);

        }
    }
}

