using System;
using System.Collections.Generic;
using doob.ScoClient.Helper;
using Reflectensions.ExtensionMethods;

namespace doob.ScoClient.Models
{
    public class Parameter
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string Direction { get; set; }

        public static List<Parameter> FromXml(SimpleXml xml)
        {

            var pList = new List<Parameter>();

            xml.AddNameSpace("m", "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata");
            xml.AddNameSpace("d", "http://schemas.microsoft.com/ado/2007/08/dataservices");
            var propertyElements = xml.SelectElements("//m:properties");

            foreach (var simpleXmlElement in propertyElements)
            {
                var p = new Parameter();
                p.Id = simpleXmlElement.SelectElement("d:Id").GetValue().ToGuid();
                p.Name = simpleXmlElement.SelectElement("d:Name").GetValue();
                p.Type = simpleXmlElement.SelectElement("d:Type").GetValue();
                p.Description = simpleXmlElement.SelectElement("d:Description").GetValue();
                p.Direction = simpleXmlElement.SelectElement("d:Direction").GetValue();
                pList.Add(p);
            }

            return pList;
        }

    }
}
