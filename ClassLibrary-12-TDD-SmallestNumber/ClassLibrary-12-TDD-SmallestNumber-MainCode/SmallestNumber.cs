using System.Linq;

namespace ClassLibrary_12_TDD_SmallestNumber_MainCode
{
    public class SmallestNumber
    {
        public int GetSmallestNumber(params int[] num)
        {
            int returnValue = 0;

            if (num.Length != 0)
            {
                returnValue = num.Min();
            }

            return returnValue;
        }
    }
}
