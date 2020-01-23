using System;

namespace ClassLibrary_12_TDD_FizzBuzz_MainCode
{
    public class FizzBuzz
    {
        public string[] DoFizzBuzz(params string[] numbers)
        {
            string[] returnedArray = numbers;

            if (numbers.Length != 0)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    int integerValue = int.Parse(numbers[i]);

                    if (integerValue % 3 == 0 && integerValue % 5 == 0)
                    {
                        returnedArray[i] = "FIZZ BUZZ";
                    }

                    else if (integerValue % 3 == 0)
                    {
                        returnedArray[i] = "FIZZ";
                    }

                    else if (integerValue % 5 == 0)
                    {
                        returnedArray[i] = "BUZZ";
                    }
                }
            }

            return returnedArray;
        }
    }
}
