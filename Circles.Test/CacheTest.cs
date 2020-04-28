using Microsoft.VisualStudio.TestTools.UnitTesting;
using Circles;

namespace Circles.Test {
    [TestClass]
    public class CacheTest {
        [TestMethod]
        public void TestCache() {
            Assert.IsTrue(60585 == Cache.CirclePoints.Length);
        }
    }
}
