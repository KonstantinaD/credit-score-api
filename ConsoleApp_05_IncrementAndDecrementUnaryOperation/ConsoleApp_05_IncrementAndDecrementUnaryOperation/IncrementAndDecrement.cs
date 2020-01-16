namespace ConsoleApp_05_IncrementAndDecrementUnaryOperation
{
    class IncrementAndDecrement
    {
        internal static int DoPrefixIncrement(int number)
        {
            int result = ++number;
            return result;
        }

        internal static int DoPostfixIncrement(int number)
        {
            int result = number++;
            return result;
        }

        internal static int DoPrefixDecrement(int number)
        {
            int result = --number;
            return result;
        }

        internal static int DoPostfixDecrement(int number)
        {
            int result = number--;
            return result;
        }
    }
}
