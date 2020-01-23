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

                    bool isMultipleOf3 = integerValue % 3 == 0;

                    bool isMultipleOf5 = integerValue % 5 == 0;

                    if (isMultipleOf3 && isMultipleOf5)
                    {
                        returnedArray[i] = "FIZZ BUZZ";
                    }

                    else if (isMultipleOf3)
                    {
                        returnedArray[i] = "FIZZ";
                    }

                    else if (isMultipleOf5)
                    {
                        returnedArray[i] = "BUZZ";
                    }
                }
            }

            return returnedArray;
        }
    }
}
