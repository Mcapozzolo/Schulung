using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortConsole.Test
{
    [TestFixture]
    public class CeaserverschlüsselungTests
    {
        // todo: test cases
        // "" -> ""     | empty stays empty
        // "Hallo" -> "Kdoor"   | simple encryption
        // "Hallo du!" -> "Kdoor gx" | with spaces and signs
        // "42 Jahre" -> "75 Mdkuh"  | with numbers
        // "9 Xyz" -> "2 Abc" | start at beginning
        // "fritz@box.com" -> "iulwc@era.frp" | with special characters

        [Test]
        [TestCase("", ExpectedResult = "", TestName = "Encrypt - Empty stays empty")]
        [TestCase("Hallo", ExpectedResult = "Kdoor", TestName = "Encrypt - single encryption")]
        [TestCase("Hallo Du", ExpectedResult = "Kdoor Gx", TestName = "Encrypt - with spaces and signs")]
        [TestCase("42 Jahre", ExpectedResult = "75 Mdkuh", TestName = "Encrypt - With Numbers")]
        [TestCase("9 Xyz", ExpectedResult = "2 Abc", TestName = "Encrypt - start at beginning")]
        [TestCase("fritz@box.com", ExpectedResult = "iulwc@era.frp", TestName = "Encrypt - with special characters")]
        [TestCase("x", ExpectedResult = "a", TestName = "Encrypt - Grenztest x")]
        [TestCase("X", ExpectedResult = "A", TestName = "Encrypt - Grenztest X")]
        [TestCase("9", ExpectedResult = "2", TestName = "Encrypt - Grenztest 9")]
        [TestCase("@#%&", ExpectedResult = "@#%&", TestName = "Encrypt - special characters")]
        [TestCase("     ", ExpectedResult = "     ", TestName = "Encrypt - space")]

        public string TestCaesarLock(string plaintext)
        {
            return Ceasarverschluesselung.Encrypt(plaintext);
        }

        [Test]
        [TestCase("", ExpectedResult = "", TestName = "Decrypt - Empty stays empty")]
        [TestCase("KDOOR", ExpectedResult = "HALLO", TestName = "Decrypt - BIG")]
        [TestCase("Kdoor", ExpectedResult = "Hallo", TestName = "Decrypt - single encryption")]
        [TestCase("Kdoor Gx", ExpectedResult = "Hallo Du", TestName = "Decrypt - with spaces and signs")]
        [TestCase("75 Mdkuh", ExpectedResult = "42 Jahre", TestName = "Decrypt - With Numbers")]
        [TestCase("2 Abc", ExpectedResult = "9 Xyz", TestName = "Decrypt - start at beginning")]
        [TestCase("iulwc@era.frp", ExpectedResult = "fritz@box.com", TestName = "Decrypt - with special characters")]
        [TestCase("a", ExpectedResult = "x", TestName = "Decrypt - Grenztest a")]
        [TestCase("A", ExpectedResult = "X", TestName = "Decrypt - Grenztest A")]
        [TestCase("0", ExpectedResult = "7", TestName = "Decrypt - Grenztest 0")]
        [TestCase("@#%&", ExpectedResult = "@#%&", TestName = "Decrypt - special characters")]
        [TestCase("     ", ExpectedResult = "     ", TestName = "Decrypt - space")]
        public string DecryptTests(string cryptedText)
        {
            return Ceasarverschluesselung.Decrypt(cryptedText);
        }
        // todo: test cases for encryption
        // same, but in other direction
    }
}
