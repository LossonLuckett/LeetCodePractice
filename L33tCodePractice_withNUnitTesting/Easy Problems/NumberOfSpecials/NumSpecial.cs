using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using L33tCodePractice_withNUnitTesting.Easy_Problems.NumberOfSpecials;

namespace L33tCodePractice_withNUnitTesting.Easy_Problems
{
    public class NumSpecial
    {
        public int NumberOfSpecials(int[][] mat)
        {
            int rowCount = mat.GetLength(0);
            int colCount = mat[0].Length;
            int numSpecial = 0;

            for(int i = 0; i < rowCount; i++)
            {
                for(int j = 0; j < colCount; j++)
                {
                    if(mat[i][j] == 1 && isSpecial(mat, i, j))
                    {
                            numSpecial++;                    
                    }
                }
            }
            return numSpecial;
        }

        public bool isSpecial(int[][] mat, int rowLocation, int colLocation)
        {
            int rowCount = mat.GetLength(0);
            int colCount = mat[0].Length;

            for (int i = 0; i < rowCount; i++)
            {
                if(mat[i][colLocation] == 1 && i != rowLocation)
                {
                    return false;
                }
            }

            for (int j = 0; j < colCount; j++)
            {
                if (mat[rowLocation][j] == 1 && j != colLocation)
                {
                    return false;
                }
            }
            return true;
        }
    }

    [TestFixture]
    public class NumberOfSpecial_TEST
    {
        NumSpecial _instance = new NumSpecial();

        [Test]
        public void NumberOfSpecials_TEST1()
        {
            int[][] grid = TestGridObjects.Grid_00001_01000_00001_10000_00000();
            int expected = 2;
            Assert.AreEqual(expected, _instance.NumberOfSpecials(grid));
        }

        [Test]
        public void NumberOfSpecials_TEST2()
        {
            int[][] grid = TestGridObjects.Grid_010_000_001();
            int expected = 2;
            Assert.AreEqual(expected, _instance.NumberOfSpecials(grid));
        }

        [Test]
        public void NumberOfSpecials_TEST3()
        {
            int[][] grid = TestGridObjects.Grid_1000_0010_0010_1000();
            int expected = 0;
            Assert.AreEqual(expected, _instance.NumberOfSpecials(grid));
        }
    }
}
