using System;

namespace ConsoleApp_04_WhileLoop
{
    public class Loop
    {
        public static void Execute(int topLimit)
        {
            int num = new int();

            while (num < topLimit)
            {
                Console.WriteLine("Value of smaller number: {0}", num);

                num++;
            }
        }
    }
}
