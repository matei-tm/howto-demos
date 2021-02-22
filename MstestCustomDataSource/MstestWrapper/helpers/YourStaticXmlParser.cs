using System.Collections.Generic;

namespace MstestWrapper
{
    internal class YourStaticXmlParser
    {
        internal static IEnumerable<CustomEnvironment> GetEnvironments()
        {
            var mockEnvironmentList = new List<CustomEnvironment>
            {
                new CustomEnvironment(){Name = "MyCustom_001" },
                new CustomEnvironment(){Name = "MyFailingMock" }
            };

            return mockEnvironmentList;
        }
    }
}