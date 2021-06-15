using System;
using System.Collections.Generic;
using doob.ScoClient.Helper;
using Reflectensions.ExtensionMethods;

namespace doob.ScoClient.Models
{
    public class Runbook
    {
        public Guid Id { get; set; }
        public Guid FolderId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Path { get; set; }

        public List<Parameter> InputParameters { get; set; } = new List<Parameter>();
        public List<Parameter> OutputParameters { get; set; } = new List<Parameter>();

        internal static Runbook FromXml(SimpleXml xml)
        {

            var rb = new Runbook();

            xml.AddNameSpace("m", "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata");
            xml.AddNameSpace("d", "http://schemas.microsoft.com/ado/2007/08/dataservices");
            var contentElement = xml.SelectElement("//m:properties");

            rb.Id = contentElement.SelectElement("d:Id").GetValue().ToGuid();
            rb.FolderId = contentElement.SelectElement("d:FolderId").GetValue().ToGuid();
            rb.Name = contentElement.SelectElement("d:Name").GetValue();
            rb.Description = contentElement.SelectElement("d:Description").GetValue();
            rb.Path = contentElement.SelectElement("d:Path").GetValue();

            return rb;

        }

    }

}
