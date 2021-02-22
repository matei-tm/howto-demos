using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MstestWrapper
{
    [TestClass]
    public class DataDrivenWrapper
    {
        public TestContext TestContext { get; set; }

        [DataTestMethod]
        [XmlCustomDataSource]
        public void Should_Blur(string environmentName)
        {
            var actualEnvironment = SomeMethodToGetActualEnvironment();
            Assert.AreEqual(environmentName, actualEnvironment);
        }

        private object SomeMethodToGetActualEnvironment()
        {
            return "MyCustom_001";
        }
    }
}
