using System;

namespace ConsoleApp_19_CollectionApp
{
    class ExampleOfArrays
    {
        public static void ShowSingleDimensional()
        {
            //An array can be declared and initialized at the same time using the new keyword.
            int[] myIntArray = new int[5] { 1, 2, 3, 4, 5 };

            Console.Write("Values in myIntArray: ");
            foreach (int i in myIntArray)
            {
                Console.Write("\t{0}", i);
            }
        }

        public static void ShowTwoDimensional()
        {
            //creates a two - dimensional array of four rows and two columns.
            int[,] array4rowsby2columns = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

            Console.WriteLine();
            Console.WriteLine("\nTwo dimensional - 4 rows by 2columns: ");
            // Get the upper bound.
            // ... Use for-loop over rows.
            for (int i = 0; i <= array4rowsby2columns.GetUpperBound(0); i++)
            {
                Console.Write("Using for-loop over rows, Values at Row: {0} are : ", i);
                int s1 = array4rowsby2columns[i, 0];
                int s2 = array4rowsby2columns[i, 1];
                Console.WriteLine("\t{0}, \t{1}", s1, s2);
            }
        }

        public static void ShowThreeDimensional()
        {
            // Three-dimensional array.
            int[,,] array3D = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } },
                                       { { 7, 8, 9 }, { 10, 11, 12 } } };

            Console.WriteLine("\nThree Dimensional Array Elements");

            for (int i = 0; i <= array3D.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= array3D.GetUpperBound(0); j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        Console.WriteLine(" array3D [{0},{1},{2}] = {3}", i, j, k, array3D[i, j, k]);
                    }
                }
            }

        }

        public static void ShowJaggedArray()
        {
            int[][] jedArray = new int[5][];
            jedArray[0] = new int[5] { 1, 2, 3, 4, 5 };
            jedArray[1] = new int[10] { 300, 301, 302, 303, 304, 305, 306, 307, 308, 309 };
            jedArray[2] = new int[] { 6, 50, 40, 20, 88 };
            jedArray[3] = new int[2] { 22, 29 };
            jedArray[4] = new int[4] { 12, 13, 16, 19 };

            Console.WriteLine("\nJagged Array Elements");

            for (int i = 0; i < jedArray.Length; i++)
            {
                Console.Write("Element[{0}]: ", i);
                for (int j = 0; j < jedArray[i].Length; j++)
                { Console.Write("{0}{1}", jedArray[i][j], j == (jedArray[i].Length - 1) ? "" : " "); }
                Console.WriteLine();
            }
        }
    }
}
