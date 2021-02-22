using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace MstestWrapper
{
    public class XmlCustomDataSourceAttribute : Attribute, ITestDataSource
    {
        public IEnumerable<object[]> GetData(MethodInfo methodInfo)
        {
            foreach (var environment in YourStaticXmlParser.GetEnvironments())
            {
                yield return new object[] { environment.Name };
            }
        }

        public string GetDisplayName(MethodInfo methodInfo, object[] data)
        {
            if (data != null)
            {
                return string.Format("Target Environmment- {0} ({1})", methodInfo.Name, data[0]);
            }

            return null;
        }
    }
}