using System.Collections;

namespace SortConsole.Test
{
    // https://docs.nunit.org/2.6.4/quickStart.html
    [TestFixture]
    public class SorterTests
    {
        [SetUp]
        public void Setup()
        {
        }


        [TestCaseSource(typeof(MyDataClass2), nameof(MyDataClass2.TestCases))]
        public static int[] TestSort(int[] input)
        {
            //int[] Result = Sorter.Sort(new int[] { 5, 1, 2, -3, 0, int.MinValue, int.MaxValue });
            //// 2147483647
            //int[] zero = Sorter.Sort(new int[] { 0, 0, 0 });
            //int[] onlynegative = Sorter.Sort(new int[] { -5, -1, -2, -3, 0, int.MinValue, -5689864 });
            //int[] biggestnumbers = Sorter.Sort(new int[] { int.MaxValue - 3, int.MaxValue - 5, int.MaxValue - 4, int.MaxValue - 1, int.MaxValue - 2, int.MinValue, int.MaxValue });
            //int[] samenumbers = Sorter.Sort(new int[] { 3, 2, 1, 5, 3, 8, 3, 6, 8, 4, 7 });
            //int[] onlysamenumbers = Sorter.Sort(new int[] { 5, 5, 5, 5, 7, 5, 5, });
            //int[] samenegative = Sorter.Sort(new int[] { 6, 5, -3, -3, -3, 4, 2, 1, 7, -8, -8 });
            //Assert.That(Result, Is.EqualTo(new int[] { int.MinValue, -3, 0, 1, 2, 5, int.MaxValue }));
            //Assert.That(zero, Is.EqualTo(new int[] { 0, 0, 0 }));
            //Assert.That(onlynegative, Is.EqualTo(new int[] { int.MinValue, -5689864, -5, -3, -2, -1, 0 }));
            //Assert.That(biggestnumbers, Is.EqualTo(new int[] { int.MinValue, int.MaxValue - 5, int.MaxValue - 4, int.MaxValue - 3, int.MaxValue - 2, int.MaxValue - 1, int.MaxValue }));
            //Assert.That(samenumbers, Is.EqualTo(new int[] { 1, 2, 3, 3, 3, 4, 5, 6, 7, 8, 8 }));
            //Assert.That(onlysamenumbers, Is.EqualTo(new int[] { 5, 5, 5, 5, 5, 5, 7 }));
            //Assert.That(samenegative, Is.EqualTo(new int[] { -8, -8, -3, -3, -3, 1, 2, 4, 5, 6, 7 }));
            return Sorter.Sort(input);


        }
    
       
    }
    public class MyDataClass2
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(new int[] { 1, 2, 3 })
                {
                    TestName = "NormalArray",
                    ExpectedResult = new int[] { 1, 2, 3 }
                };
                yield return new TestCaseData(new int[] { 0,0,0,0,0 })
                {
                    TestName = "Zero",
                    ExpectedResult = new int[] { 0, 0, 0, 0, 0 }
                };
                yield return new TestCaseData(new int[] { -5, -1, -2, -3, 0, int.MinValue, -5689864 })
                {
                    TestName = "OnlyNegative",
                    ExpectedResult = new int[] { int.MinValue, -5689864, -5, -3, -2, -1, 0 }
                };
                yield return new TestCaseData(new int[] { int.MaxValue - 3, int.MaxValue - 5, int.MaxValue - 4, int.MaxValue - 1, int.MaxValue - 2, int.MinValue, int.MaxValue })
                {
                    TestName = "BiggestNumbers",
                    ExpectedResult = new int[] { int.MinValue, int.MaxValue - 5, int.MaxValue - 4, int.MaxValue - 3, int.MaxValue - 2, int.MaxValue - 1, int.MaxValue }
                };
                yield return new TestCaseData(new int[] { 3, 2, 1, 5, 3, 8, 3, 6, 8, 4, 7 })
                {
                    TestName = "SameNumbers",
                    ExpectedResult = new int[] { 1, 2, 3, 3, 3, 4, 5, 6, 7, 8, 8 }
                };
                yield return new TestCaseData(new int[] { 5,5,5,5,5,5 })
                {
                    TestName = "OnlySameNumbers",
                    ExpectedResult = new int[] { 5,5,5,5,5,5 }
                };
                yield return new TestCaseData(new int[] { 6, 5, -3, -3, -3, 4, 2, 1, 7, -8, -8 })
                {
                    TestName = "SameNegativeNumbers",
                    ExpectedResult = new int[] { -8, -8, -3, -3, -3, 1, 2, 4, 5, 6, 7 }
                };
                yield return new TestCaseData(new int[] { 3,-4,1,-7,-78,98,-34,56,-22,223434 })
                {
                    TestName = "ZickZack",
                    ExpectedResult = new int[] { -78,-34,-22,-7,-4,1,3,56,98,223434 }
                };
            }
        }
    }
}