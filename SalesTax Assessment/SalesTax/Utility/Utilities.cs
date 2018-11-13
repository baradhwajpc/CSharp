using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVM.Utility
{
    public class Utilities
    {
        private const double ROUNDOFF = 0.05;
        public static double RoundOff(double value)
        {
            return (int)(value / ROUNDOFF + 0.5) * 0.05;
        }

        internal static bool ParseBoolean(char value)
        {
            bool flag = true;
            bool boolValue = false;

            while (flag)
            {
                if (value == 'Y' || value == 'y')
                {
                    boolValue = true;
                    flag = false;
                }
                else if (value == 'N' || value == 'n')
                {
                    boolValue = false;
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Invalid input. Enter (Y/N)");
                }
            }
            return boolValue;
        }
        public static double Truncate(double value)
        {
            String result = value.ToString("N3"); ;
            return Double.Parse(result);
        }
    }
}
