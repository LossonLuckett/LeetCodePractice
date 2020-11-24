using System;
using System.Collections.Generic;
using System.Text;

namespace L33tCodePractice_withNUnitTesting.Easy_Problems.NumberOfSpecials
{
    public class TestGridObjects
    {
        public static int[][] Grid_010_000_001()
        {
            int[][] grid =
            {
                new int[]  {0,1,0},
                new int[]  {0,0,0},
                new int[]  {0,0,1}
            };
            return grid;
        }

        public static int[][] Grid_00001_01000_00001_10000_00000()
        {
            int[][] grid =
            {
                new int[]  {0,0,0,0,1},
                new int[]  {0,1,0,0,0},
                new int[]  {0,0,0,0,1},
                new int[]  {1,0,0,0,0},
                new int[]  {0,0,0,0,0}
            };
            return grid;
        }


        public static int[][] Grid_1000_0010_0010_1000()
        {
            int[][] grid =
            {
                new int[]  {1,0,0,0},
                new int[]  {0,0,1,0},
                new int[]  {0,0,1,0},
                new int[]  {1,0,0,0}
            };
            return grid;
        }


    }
}
