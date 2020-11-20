using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using L33tCodePractice_withNUnitTesting.Easy_Problems.CountNegatives_in_SortedMatrix;


namespace L33tCodePractice_withNUnitTesting.Easy_Problems
{
    public class CountNegativesInASortedMartix_TEST
    {
        public int CountNegatives(int[,] grid)
        {

            //Array is sorted in decending order
            int count = 0;
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int k = 0; k < grid.GetLength(1); k++)
                {
                    if (grid[i,k] <= 0)
                    {
                         return (grid.GetLength(0) * grid.GetLength(1)) - count;
                    }
                    count++;
                }
            }
            return 0;
        }

        
    }


    [TestFixture]
    public class CountNegatives_Test
    {
       
        [Test]
        public void CountNeg_Test1()
        {
            CountNegativesInASortedMartix_TEST _instance = new CountNegativesInASortedMartix_TEST();

            int[,] grid = MatrixTestObjects._321000();

            Assert.AreEqual(3, _instance.CountNegatives(grid));
            
        }
        [Test]
        public void CountNeg_Test2()
        {

            CountNegativesInASortedMartix_TEST _instance = new CountNegativesInASortedMartix_TEST();

            int[,] grid = MatrixTestObjects._111111();

            Assert.AreEqual(0, _instance.CountNegatives(grid));

        }
        [Test]
        public void CountNeg_Test3()
        {

            CountNegativesInASortedMartix_TEST _instance = new CountNegativesInASortedMartix_TEST();

            int[,] grid = MatrixTestObjects._543210_1_1();

            Assert.AreEqual(3, _instance.CountNegatives(grid));

        }
        [Test]
        public void CountNeg_Test4()
        {

            CountNegativesInASortedMartix_TEST _instance = new CountNegativesInASortedMartix_TEST();

            int[,] grid = MatrixTestObjects._9620_1_2_3_4();

            Assert.AreEqual(5, _instance.CountNegatives(grid));

        }







    }
}
