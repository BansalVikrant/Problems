using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindIslands
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Islands view before processing");
            Input.Display2DArray();

            int islandsCount = BuisnessLogic.NumberofIslands(ref Input.islands);
            Console.WriteLine("Number of islands: " + islandsCount);

            Console.WriteLine("Islands view after processing");
            Input.Display2DArray();
        }
    }
}