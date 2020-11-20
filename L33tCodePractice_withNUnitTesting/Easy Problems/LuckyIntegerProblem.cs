using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace L33tCodePractice_withNUnitTesting.Easy_Problems
{
    public class LuckyIntegerProblem
    {

        public int FindLucky(int[] arr)
        {
            Dictionary<int,int> frequencyTable = new Dictionary<int,int>();
            foreach(int i in arr)
            {
                
               if(frequencyTable.ContainsKey(i))
                {                 
                    frequencyTable[i]++;
                }
                else
                {
                    frequencyTable.Add(i, 1);
                }            
            }


            HashSet<int> LuckyIntergers = new HashSet<int>();
            foreach(KeyValuePair<int, int> i in frequencyTable)
            {
                if(i.Key == i.Value)
                {
                    LuckyIntergers.Add(i.Value);
                }
            }

            return returnLargest(LuckyIntergers);

        }

        public int returnLargest(HashSet<int> arr)
        {
            if (arr.Count == 0)
                return -1;

            int largest = int.MinValue;
            foreach(int i in arr)
            {
                if(i > largest)
                {
                    largest = i;
                }

            }
            return largest;
        }
    }

    [TestFixture]
    public class FindLucky_TEST
    {
        [Test]
        [TestCase(5, new int[] { 1,2,5,5,5,2,5,5 })]
        [TestCase(3, new int[] { 3, 2, 5, 3, 5, 2, 3, 1, 4})]
        [TestCase(1, new int[] { 1, 2, 5, 5, 5, 3, 5 })]
        [TestCase(-1, new int[] { 12,3,4,5,6,7,})]
        public void FindLucky_Test(int expected, int[] arr)
        {
            LuckyIntegerProblem instance = new LuckyIntegerProblem();
            Assert.AreEqual(expected, instance.FindLucky(arr));          
        }
    }
}
