using System;

namespace MethodOverloading
{
    internal class Program
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }
        public static string Add(int x, int y, bool isCheck)
        {
            var sum = x + y;
            if (isCheck == true && sum == 1)
            {
                return ($"{sum} dollar");
            }
            if (isCheck == true && sum != 1)
            {
                return ($"{sum} dollars");
            }
            else
                return x + y.ToString();
            }
            
    











	}
}
