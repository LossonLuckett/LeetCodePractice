using System;
using System.Text;
using NUnit.Framework;


namespace StrStr_Test
{
    public class NeedleInHaystack
    {

        public static int StrStr(string hay, string needle)
        {

            if (needle.Length == 0)
                return 0;

            int checkLength = needle.Length;
            for (int i = 0; i < hay.Length; i++)
            {
                if (hay[i] == needle[0])
                {
                    for (int j = 0; j < needle.Length - 1; j++)
                    {
                        if (hay[i + j] != needle[j])
                        {
                            return -1;
                        }
                    }
                    return i;
                }
            }
            return -1;
        }
    }

    [TestFixture]
    public class StrStr_Test
    {
        [Test]
        [TestCase(2, "Hello", "ll")]
        [TestCase(-1, "aaaaaa", "bba")]
        [TestCase(4, "hello", "o")]
        [TestCase(-1, "123", "444")]
        [TestCase(1, "098", "9")]
        public void StrStr_TEST(int expected, string haystack, string needle)
        {
            int result = NeedleInHaystack.StrStr(haystack, needle);
            Assert.AreEqual(expected, result);
        }


    }

}
