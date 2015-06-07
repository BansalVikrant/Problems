using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindIslands
{
    public static class BuisnessLogic
    {
        private static int RowBound;
        private static int ColumnBound;

        private static bool IsOutofBound(int rowIndex, int columnIndex)
        {
            if ((rowIndex >= 0) &&
               (rowIndex <= RowBound) &&
               (columnIndex >= 0) &&
               (columnIndex <= ColumnBound))
            { return false; }

            return true;
        }

        private static void MarkLandofIsland(ref int[,] islands, int rowIndex, int columnIndex)
        {
            if ((IsOutofBound(rowIndex, columnIndex)) ||
                (islands[rowIndex, columnIndex] != 1))
                return;

            islands[rowIndex, columnIndex] = 2;
            MarkLandofIsland(ref islands, rowIndex - 1, columnIndex);
            MarkLandofIsland(ref islands, rowIndex + 1, columnIndex);
            MarkLandofIsland(ref islands, rowIndex, columnIndex - 1);
            MarkLandofIsland(ref islands, rowIndex, columnIndex + 1);
        }

        public static int NumberofIslands(ref int[,] islands)
        {
            int numberofIslands = 0;

            RowBound = islands.GetUpperBound(0);
            ColumnBound = islands.GetUpperBound(1);

            for (int i = 0; i <= RowBound; i++)
            {
                for (int j = 0; j <= ColumnBound; j++)
                {
                    if (islands[i, j] == 1)
                    {
                        numberofIslands += 1;
                        MarkLandofIsland(ref islands, i, j);
                    }
                }
            }

            return numberofIslands;
        }
    }
}