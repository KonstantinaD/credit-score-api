using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_04_DoWhileLoop
{
    public class Loop
    {

        public static void Execute (int topLimit)
        {
            int num = new int();
            do
            {
                Console.WriteLine("Value of smaller number: {0}", num);
                num++;
            }
            while (num < topLimit);
        }       
    }
}
