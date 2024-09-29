using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using STRINGTDD;
namespace STRINDTDD.Tests
{
    [TestClass]
    public class STRINDTDDTests
    {
       
        
        [TestMethod]
        public void FindShortestWord_Find_Shortest_Word_ReturnsFind()
        {
            STRINGTdd str = new STRINGTdd();

            Assert.AreEqual("Find", str.FindShortestWord("Find Shortest Word"));
            Assert.IsNull(str.FindShortestWord(""));
            Assert.IsNull(str.FindShortestWord(null));
        }

        [TestMethod]
        public void CountWords_Count_Words_Returns2()
        {
            STRINGTdd str = new STRINGTdd();

            Assert.AreEqual(2, str.CountWords("Count Words"));
            Assert.AreEqual(0, str.CountWords(""));
            Assert.AreEqual(0, str.CountWords(null));
        }

        [TestMethod]
        public void CountCharacters_Count_Characters_Returns16()
        {
            STRINGTdd str = new STRINGTdd();

            Assert.AreEqual(16, str.CountCharacters("Count Characters"));
            Assert.AreEqual(0, str.CountCharacters(""));
            Assert.AreEqual(0, str.CountCharacters(null));
        }

        [TestMethod]
        public void FindNinthCharacter_Find_Ninth_Character_Returnst()
        {
            STRINGTdd str = new STRINGTdd();

            Assert.AreEqual('t', str.FindNinthCharacter("Find Ninth Character"));
            Assert.IsNull(str.FindNinthCharacter(""));
            Assert.IsNull(str.FindNinthCharacter(null));
        }

        [TestMethod]
        public void CountDigits_Count3_Digits03_Returns3()
        {
            STRINGTdd str = new STRINGTdd();

            Assert.AreEqual(3, str.CountDigits("Count3 Digits03"));
            Assert.AreEqual(0, str.CountDigits(""));
            Assert.AreEqual(0, str.CountDigits(null));
        }

        [TestMethod]
        public void LongestDigits_12782178shh16262772r433434422_Returns9()
        {
            STRINGTdd str = new STRINGTdd();

            Assert.AreEqual(9, str.LongestDigits("12782178shh16262772r433434422"));
            Assert.AreEqual(0, str.LongestDigits(""));
            Assert.AreEqual(0, str.LongestDigits(null));
        }

        [TestMethod]
        public void CountAmOccurrences_амамамамамамам_амвуооам_Returns9()
        {
            STRINGTdd str = new STRINGTdd();

            Assert.AreEqual(9, str.CountAmOccurrences("амамамамамамам_амвуооам"));
            Assert.AreEqual(0, str.CountAmOccurrences(""));
            Assert.AreEqual(0, str.CountAmOccurrences(null));
        }
    }
}

