using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace L33tCodePractice_withNUnitTesting.Medium_Problems.Path_with_Maximum_Gold
{
    public class PathWithMaxGold
    {
        public int GetMaximumGold(int[][] grid)
        {
            if (grid == null || grid.Length == 0)
                return 0;

            int max = 0;
            int rowLength = grid.Length;
            int colLength = grid[0].Length;
            for(int i = 0; i < rowLength; i++)
            {
                for(int j = 0; j < colLength; j++)
                {
                    if(grid[i][j] > 0)
                    {
                        int gold = findMaxGold(grid, i, j, rowLength, colLength, InitializeVisitedLocations(grid));
                        max = Math.Max(max, gold);
                    }
                }        
            }
            return max;
           
        }

        public bool[][] InitializeVisitedLocations(int[][] grid)
        {
            int numRows = grid.GetLength(0);
            int numColumns = grid[0].Length;
            bool[][] visitedLocations = new bool[numRows][];
            for(int i = 0; i < numRows; i++)
            {
                visitedLocations[i] = new bool[numColumns];
                for(int j = 0; j < numColumns; j++)
                {
                    visitedLocations[i][j] = false;
                }
            }
            return visitedLocations; 
        }

        public int findMaxGold(int[][] grid, int i, int j, int rowLength, int colLength, bool[][] visited)
        {
            if (i < 0 || j < 0 || i >= rowLength || j >= colLength || grid[i][j] == 0 || visited[i][j] == true)
            {
                return 0;
            }
               
            visited[i][j] = true;
            int left = findMaxGold(grid, i, j - 1, rowLength, colLength, visited);
            int right = findMaxGold(grid, i, j + 1, rowLength, colLength, visited);
            int up = findMaxGold(grid, i - 1, j, rowLength, colLength, visited);
            int down = findMaxGold(grid, i + 1, j, rowLength, colLength, visited);
            visited[i][j] = false;
            return Math.Max(left, Math.Max(right, Math.Max(up, down))) + grid[i][j];
        }
    }


    [TestFixture]
    public class PathWithMaxGold_TEST
    {

        PathWithMaxGold instance = new PathWithMaxGold();

        [Test]
        public void GetMaximumGold_TEST_Grid_060_587_090()
        {
            int expected = 24;
            int[][] grid = GridTestObjects.Grid_060_587_090();
            Assert.AreEqual(expected, instance.GetMaximumGold(grid));
        }

        [Test]
        public void GetMaximumGold_TEST_Grid_1234_0089_1253_0089()
        {
            int expected = 52;
            int[][] grid = GridTestObjects.Grid_1234_0089_1253_0089();
            Assert.AreEqual(expected, instance.GetMaximumGold(grid));
        }

        [Test]
        public void GetMaximumGold_TEST_Grid_11_00()
        {
            int expected = 2;
            int[][] grid = GridTestObjects.Grid_11_00();
            Assert.AreEqual(expected, instance.GetMaximumGold(grid));

        }




    }
}
