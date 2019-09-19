using Microsoft.VisualStudio.TestTools.UnitTesting;
using aChao_1;
using System.Collections.Generic;

namespace aChao_1UnitTestProject
{
    [TestClass]
    public class RandomCollectionTest
    {
        [TestMethod]
        public void randomIntTest()
        {
            RandomCollection randomCollection = new RandomCollection();
            int i = randomCollection.randomInt(2, 2);
            Assert.AreEqual(2, i);
        }
        [TestMethod]
        public void randomSymbolTest()
        {
            RandomCollection random = new RandomCollection();
            string s = random.randomSymbol();
            Assert.IsNotNull(s);
        }
    }
}
