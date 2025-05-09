using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongNumberChecker
{
    public class ArmstrongNumber
    {
        public bool IsArmstrong(int number)
        {
            if (number < 0) return false;

            int originalNumber = number;
            int sum = 0;
            int digits = number.ToString().Length;

            while (number > 0)
            {
                int digit = number % 10;
                sum += (int)Math.Pow(digit, digits);
                number /= 10;
            }

            return sum == originalNumber;
        }
    }
}
