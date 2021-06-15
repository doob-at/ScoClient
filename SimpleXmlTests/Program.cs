using System;
using System.Linq;
using System.Xml;
using SimpleXmlTests.Helper;

namespace SimpleXmlTests
{
    class Program
    {
        static void Main(string[] args)
        {
            var xml = SimpleXml.Parse(XmlContent.Get());
            
            xml.AddNameSpace("x", "http://www.w3.org/2005/Atom");
            xml.AddNameSpace("m", "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata");
            xml.AddNameSpace("d", "http://schemas.microsoft.com/ado/2007/08/dataservices");

            var entry = xml.SelectElements("//x:entry");

        }
    }
}
