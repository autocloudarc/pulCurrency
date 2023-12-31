using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace pulCurrency
{
    public class Euro
    {
        public static double ConvertToEuro(double amount)
        {
            double exchangeRate = 0.908;
            // Conversion logic for euros
            double convertedAmount = amount * exchangeRate;
            return convertedAmount;
        }

        public static string GetSymbol()
        {
            // Get the symbol for euros
            string symbol = "EUR";
            return symbol;
        }
    }

    public class Yen
    {
        public static double ConvertToYen(double amount)
        {
            double exchangeRate = 142.19;
            // Conversion logic for yens
            double convertedAmount = amount * exchangeRate;
            return convertedAmount;
        }

        public static string GetSymbol()
        {
            // Get the symbol for yens
            string symbol = "JPY";
            return symbol;
        }
    }

    public class USDollar
    {
        public static double ConvertToUSD(double amount)
        {
            double exchangeRate = 1.00;
            // Conversion logic for US dollars
            double convertedAmount = amount * exchangeRate;
            return convertedAmount;
        }

        public static string GetSymbol()
        {
            // Get the symbol for yens
            string symbol = "USD";
            return symbol;
        }
    }
}
