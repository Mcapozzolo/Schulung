using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using NUnit.Framework;

namespace SortConsole.Test
{
    [TestFixture]
    public class NumberInputReaderTests
    {
        // todo: testcases
        // "3, 8, 1"  --> { 1, 3, 8 }   | reads numbers
        // "7, -2, 5" --> { -2, 5, 7 }  | with negative values
        // "3 8 1" --> { }              | empty result on spaces between numbers
        // "7 -2 1" --> { }             | empty result on negative numbers without spaces
        // "hallo marco" --> { }        | invalid input results in empty result
        // "3,, 8," -> { 3, 8 }         | too many delimiter will be ignored
        // "" --> { }                   | empty input leads to empty result
        // "3.1415926 535 2.4857" -> {} | empty result


        [TestCaseSource(typeof(MyDataClass), nameof(MyDataClass.TestCases2))]
        public static int[] TestInput(string input)
        {
            return NumberInputReader.ReadNumberFromInput(input);
        }

    }
    public class MyDataClass
    {
        public static IEnumerable TestCases2
        {
            get
            {
                yield return new TestCaseData("1,2,3")
                {
                    TestName = "normal",
                    ExpectedResult = new int[] { 1, 2, 3 }
                };
                yield return new TestCaseData("3,    4, 5")
                {
                    TestName = "MitAbstand",
                    ExpectedResult = new int[] { 3, 4, 5 }
                };
                yield return new TestCaseData("343,-6,0,9")
                {
                    TestName = "minusnumbers",
                    ExpectedResult = new int[] {343, -6, 0, 9}
                };
                yield return new TestCaseData("1 2 3")
                {
                    TestName = "NoKommas",
                    ExpectedResult = new int[] { }
                };
                yield return new TestCaseData("4.5 ,5, 6")
                {
                    TestName = "Kommastellen",
                    ExpectedResult = new int[] { }
                };
                yield return new TestCaseData("hallo marco")
                {
                    TestName = "NoNumbers",
                    ExpectedResult = new int[] { }
                };
            }
        }



    }
}
