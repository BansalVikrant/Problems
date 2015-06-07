using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindIslands
{
    public static class Input
    {
        public static int[,] islands;

        static Input()
        {
            islands = new int[,] { {1,1,0,0,1},
                                   {1,0,0,1,0},
                                   {1,1,0,1,0}};
        }

        public static void Display2DArray()
        {
            int Rows = islands.GetUpperBound(0);
            int Columns = islands.GetUpperBound(1);

            for (int i = 0; i <= Rows; i++)
            {
                for (int j = 0; j <= Columns; j++)
                {
                    Console.Write(" " + islands[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}