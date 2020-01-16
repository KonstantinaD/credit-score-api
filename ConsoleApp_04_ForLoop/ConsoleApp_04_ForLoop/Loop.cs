using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_04_ForLoop
{
    public class Loop
    {
            public static void Execute(int topLimit)
            {

            for (int num = new int(); num < topLimit;  num++)
                {
                    Console.WriteLine("Value of smaller number: {0}", num);
                }
            }
    }
}
