using System;
using System.Linq;

namespace ClassLibrary_12_TDD_BiggestNumber_MainCode
{
    public class BiggestNumber
    {
        public int GetBiggestNumber(params int[] num1)
        {
            int returnVal = 0;

            if (!(num1.Length == 0))
            {
                returnVal = num1.Max();
            }

            return returnVal;
        }
    }
}

