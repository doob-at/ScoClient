using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleXmlTests
{
    public class XmlContent
    {

        public static string Get()
        {

            return @"<?xml version=""1.0"" encoding=""utf-8"" standalone=""yes""?>
<feed xml:base=""http://localhost:81/Orchestrator2012/Orchestrator.svc/"" xmlns:d=""http://schemas.microsoft.com/ado/2007/08/dataservices"" xmlns:m=""http://schemas.microsoft.com/ado/2007/08/dataservices/metadata"" xmlns=""http://www.w3.org/2005/Atom"">
  <title type=""text"">Runbooks</title>
  <id>http://localhost:81/Orchestrator2012/Orchestrator.svc/Runbooks</id>
  <updated>2020-12-02T17:04:46Z</updated>
  <link rel=""self"" title=""Runbooks"" href=""Runbooks"" />
  <entry m:etag=""W/&quot;datetime'2020-11-17T09%3A02%3A50'&quot;"">
    <id>http://localhost:81/Orchestrator2012/Orchestrator.svc/Runbooks(guid'00b67604-574a-468d-ae08-26913e757e0c')</id>
    <title type=""text"">SyncBenutzer</title>
    <published>2020-11-09T15:08:50+01:00</published>
    <updated>2020-11-17T09:02:50+01:00</updated>
    <author>
      <name />
    </author>
    <link rel=""edit"" title=""Runbook"" href=""Runbooks(guid'00b67604-574a-468d-ae08-26913e757e0c')"" />
    <link rel=""http://schemas.microsoft.com/ado/2007/08/dataservices/related/Folder"" type=""application/atom+xml;type=entry"" title=""Folder"" href=""Runbooks(guid'00b67604-574a-468d-ae08-26913e757e0c')/Folder"" />
    <link rel=""http://schemas.microsoft.com/ado/2007/08/dataservices/related/Parameters"" type=""application/atom+xml;type=feed"" title=""Parameters"" href=""Runbooks(guid'00b67604-574a-468d-ae08-26913e757e0c')/Parameters"" />
    <link rel=""http://schemas.microsoft.com/ado/2007/08/dataservices/related/Activities"" type=""application/atom+xml;type=feed"" title=""Activities"" href=""Runbooks(guid'00b67604-574a-468d-ae08-26913e757e0c')/Activities"" />
    <link rel=""http://schemas.microsoft.com/ado/2007/08/dataservices/related/Jobs"" type=""application/atom+xml;type=feed"" title=""Jobs"" href=""Runbooks(guid'00b67604-574a-468d-ae08-26913e757e0c')/Jobs"" />
    <link rel=""http://schemas.microsoft.com/ado/2007/08/dataservices/related/Instances"" type=""application/atom+xml;type=feed"" title=""Instances"" href=""Runbooks(guid'00b67604-574a-468d-ae08-26913e757e0c')/Instances"" />
    <link rel=""http://schemas.microsoft.com/ado/2007/08/dataservices/related/Diagram"" type=""application/atom+xml;type=entry"" title=""Diagram"" href=""Runbooks(guid'00b67604-574a-468d-ae08-26913e757e0c')/Diagram"" />
    <link rel=""http://schemas.microsoft.com/ado/2007/08/dataservices/related/Statistics"" type=""application/atom+xml;type=feed"" title=""Statistics"" href=""Runbooks(guid'00b67604-574a-468d-ae08-26913e757e0c')/Statistics"" />
    <category term=""Microsoft.SystemCenter.Orchestrator.WebService.Runbook"" scheme=""http://schemas.microsoft.com/ado/2007/08/dataservices/scheme"" />
    <content type=""application/xml"">
      <m:properties>
        <d:Id m:type=""Edm.Guid"">00b67604-574a-468d-ae08-26913e757e0c</d:Id>
        <d:FolderId m:type=""Edm.Guid"">d81c0f1d-ed47-4ab6-9420-1bdbd2cb6d9d</d:FolderId>
        <d:Name>SyncBenutzer</d:Name>
        <d:Description m:null=""true"" />
        <d:CreatedBy>S-1-5-500</d:CreatedBy>
        <d:CreationTime m:type=""Edm.DateTime"">2020-11-09T15:08:50.907</d:CreationTime>
        <d:LastModifiedBy>S-1-5-21-1709059561-2143686068-2252755103-1103</d:LastModifiedBy>
        <d:LastModifiedTime m:type=""Edm.DateTime"">2020-11-17T09:02:50</d:LastModifiedTime>
        <d:IsMonitor m:type=""Edm.Boolean"">false</d:IsMonitor>
        <d:Path>\00-Dev\SyncBenutzer\SyncBenutzer</d:Path>
        <d:CheckedOutBy m:null=""true"" />
        <d:CheckedOutTime m:type=""Edm.DateTime"" m:null=""true"" />
      </m:properties>
    </content>
  </entry>
  <entry m:etag=""W/&quot;datetime'2020-11-17T12%3A00%3A53'&quot;"">
    <id>http://localhost:81/Orchestrator2012/Orchestrator.svc/Runbooks(guid'ba9defb7-1c63-4448-ac4f-30f9e264c82b')</id>
    <title type=""text"">2</title>
    <published>2020-11-17T12:00:06+01:00</published>
    <updated>2020-11-17T12:00:53+01:00</updated>
    <author>
      <name />
    </author>
    <link rel=""edit"" title=""Runbook"" href=""Runbooks(guid'ba9defb7-1c63-4448-ac4f-30f9e264c82b')"" />
    <link rel=""http://schemas.microsoft.com/ado/2007/08/dataservices/related/Folder"" type=""application/atom+xml;type=entry"" title=""Folder"" href=""Runbooks(guid'ba9defb7-1c63-4448-ac4f-30f9e264c82b')/Folder"" />
    <link rel=""http://schemas.microsoft.com/ado/2007/08/dataservices/related/Parameters"" type=""application/atom+xml;type=feed"" title=""Parameters"" href=""Runbooks(guid'ba9defb7-1c63-4448-ac4f-30f9e264c82b')/Parameters"" />
    <link rel=""http://schemas.microsoft.com/ado/2007/08/dataservices/related/Activities"" type=""application/atom+xml;type=feed"" title=""Activities"" href=""Runbooks(guid'ba9defb7-1c63-4448-ac4f-30f9e264c82b')/Activities"" />
    <link rel=""http://schemas.microsoft.com/ado/2007/08/dataservices/related/Jobs"" type=""application/atom+xml;type=feed"" title=""Jobs"" href=""Runbooks(guid'ba9defb7-1c63-4448-ac4f-30f9e264c82b')/Jobs"" />
    <link rel=""http://schemas.microsoft.com/ado/2007/08/dataservices/related/Instances"" type=""application/atom+xml;type=feed"" title=""Instances"" href=""Runbooks(guid'ba9defb7-1c63-4448-ac4f-30f9e264c82b')/Instances"" />
    <link rel=""http://schemas.microsoft.com/ado/2007/08/dataservices/related/Diagram"" type=""application/atom+xml;type=entry"" title=""Diagram"" href=""Runbooks(guid'ba9defb7-1c63-4448-ac4f-30f9e264c82b')/Diagram"" />
    <link rel=""http://schemas.microsoft.com/ado/2007/08/dataservices/related/Statistics"" type=""application/atom+xml;type=feed"" title=""Statistics"" href=""Runbooks(guid'ba9defb7-1c63-4448-ac4f-30f9e264c82b')/Statistics"" />
    <category term=""Microsoft.SystemCenter.Orchestrator.WebService.Runbook"" scheme=""http://schemas.microsoft.com/ado/2007/08/dataservices/scheme"" />
    <content type=""application/xml"">
      <m:properties>
        <d:Id m:type=""Edm.Guid"">ba9defb7-1c63-4448-ac4f-30f9e264c82b</d:Id>
        <d:FolderId m:type=""Edm.Guid"">e4002667-4008-47de-8d0d-2ae65d8f6da4</d:FolderId>
        <d:Name>2</d:Name>
        <d:Description m:null=""true"" />
        <d:CreatedBy>S-1-5-500</d:CreatedBy>
        <d:CreationTime m:type=""Edm.DateTime"">2020-11-17T12:00:06.093</d:CreationTime>
        <d:LastModifiedBy>S-1-5-21-1709059561-2143686068-2252755103-1103</d:LastModifiedBy>
        <d:LastModifiedTime m:type=""Edm.DateTime"">2020-11-17T12:00:53</d:LastModifiedTime>
        <d:IsMonitor m:type=""Edm.Boolean"">true</d:IsMonitor>
        <d:Path>\00-Dev\Schedules\1min\2</d:Path>
        <d:CheckedOutBy m:null=""true"" />
        <d:CheckedOutTime m:type=""Edm.DateTime"" m:null=""true"" />
      </m:properties>
    </content>
  </entry>
  <entry m:etag=""W/&quot;datetime'2020-11-23T09%3A36%3A34'&quot;"">
    <id>http://localhost:81/Orchestrator2012/Orchestrator.svc/Runbooks(guid'ea5b73a1-9a35-48ec-b79f-44cfe40ff3e3')</id>
    <title type=""text"">Sync-StammportalBenutzer</title>
    <published>2020-11-16T14:37:09+01:00</published>
    <updated>2020-11-23T09:36:34+01:00</updated>
    <author>
      <name />
    </author>
    <link rel=""edit"" title=""Runbook"" href=""Runbooks(guid'ea5b73a1-9a35-48ec-b79f-44cfe40ff3e3')"" />
    <link rel=""http://schemas.microsoft.com/ado/2007/08/dataservices/related/Folder"" type=""application/atom+xml;type=entry"" title=""Folder"" href=""Runbooks(guid'ea5b73a1-9a35-48ec-b79f-44cfe40ff3e3')/Folder"" />
    <link rel=""http://schemas.microsoft.com/ado/2007/08/dataservices/related/Parameters"" type=""application/atom+xml;type=feed"" title=""Parameters"" href=""Runbooks(guid'ea5b73a1-9a35-48ec-b79f-44cfe40ff3e3')/Parameters"" />
    <link rel=""http://schemas.microsoft.com/ado/2007/08/dataservices/related/Activities"" type=""application/atom+xml;type=feed"" title=""Activities"" href=""Runbooks(guid'ea5b73a1-9a35-48ec-b79f-44cfe40ff3e3')/Activities"" />
    <link rel=""http://schemas.microsoft.com/ado/2007/08/dataservices/related/Jobs"" type=""application/atom+xml;type=feed"" title=""Jobs"" href=""Runbooks(guid'ea5b73a1-9a35-48ec-b79f-44cfe40ff3e3')/Jobs"" />
    <link rel=""http://schemas.microsoft.com/ado/2007/08/dataservices/related/Instances"" type=""application/atom+xml;type=feed"" title=""Instances"" href=""Runbooks(guid'ea5b73a1-9a35-48ec-b79f-44cfe40ff3e3')/Instances"" />
    <link rel=""http://schemas.microsoft.com/ado/2007/08/dataservices/related/Diagram"" type=""application/atom+xml;type=entry"" title=""Diagram"" href=""Runbooks(guid'ea5b73a1-9a35-48ec-b79f-44cfe40ff3e3')/Diagram"" />
    <link rel=""http://schemas.microsoft.com/ado/2007/08/dataservices/related/Statistics"" type=""application/atom+xml;type=feed"" title=""Statistics"" href=""Runbooks(guid'ea5b73a1-9a35-48ec-b79f-44cfe40ff3e3')/Statistics"" />
    <category term=""Microsoft.SystemCenter.Orchestrator.WebService.Runbook"" scheme=""http://schemas.microsoft.com/ado/2007/08/dataservices/scheme"" />
    <content type=""application/xml"">
      <m:properties>
        <d:Id m:type=""Edm.Guid"">ea5b73a1-9a35-48ec-b79f-44cfe40ff3e3</d:Id>
        <d:FolderId m:type=""Edm.Guid"">7a975967-4bab-46bd-aeaa-a3b3f239e8c0</d:FolderId>
        <d:Name>Sync-StammportalBenutzer</d:Name>
        <d:Description m:null=""true"" />
        <d:CreatedBy>S-1-5-500</d:CreatedBy>
        <d:CreationTime m:type=""Edm.DateTime"">2020-11-16T14:37:09.993</d:CreationTime>
        <d:LastModifiedBy>S-1-5-21-1709059561-2143686068-2252755103-1103</d:LastModifiedBy>
        <d:LastModifiedTime m:type=""Edm.DateTime"">2020-11-23T09:36:34</d:LastModifiedTime>
        <d:IsMonitor m:type=""Edm.Boolean"">false</d:IsMonitor>
        <d:Path>\00-Dev\SyncBenutzer\StammportalBenutzer\Sync-StammportalBenutzer</d:Path>
        <d:CheckedOutBy m:null=""true"" />
        <d:CheckedOutTime m:type=""Edm.DateTime"" m:null=""true"" />
      </m:properties>
    </content>
  </entry>
  <entry m:etag=""W/&quot;datetime'2020-11-18T07%3A47%3A15'&quot;"">
    <id>http://localhost:81/Orchestrator2012/Orchestrator.svc/Runbooks(guid'b183675e-f047-498b-8a72-8d07fcb43d3d')</id>
    <title type=""text"">Reset Password</title>
    <published>2020-11-17T12:34:31+01:00</published>
    <updated>2020-11-18T07:47:15+01:00</updated>
    <author>
      <name />
    </author>
    <link rel=""edit"" title=""Runbook"" href=""Runbooks(guid'b183675e-f047-498b-8a72-8d07fcb43d3d')"" />
    <link rel=""http://schemas.microsoft.com/ado/2007/08/dataservices/related/Folder"" type=""application/atom+xml;type=entry"" title=""Folder"" href=""Runbooks(guid'b183675e-f047-498b-8a72-8d07fcb43d3d')/Folder"" />
    <link rel=""http://schemas.microsoft.com/ado/2007/08/dataservices/related/Parameters"" type=""application/atom+xml;type=feed"" title=""Parameters"" href=""Runbooks(guid'b183675e-f047-498b-8a72-8d07fcb43d3d')/Parameters"" />
    <link rel=""http://schemas.microsoft.com/ado/2007/08/dataservices/related/Activities"" type=""application/atom+xml;type=feed"" title=""Activities"" href=""Runbooks(guid'b183675e-f047-498b-8a72-8d07fcb43d3d')/Activities"" />
    <link rel=""http://schemas.microsoft.com/ado/2007/08/dataservices/related/Jobs"" type=""application/atom+xml;type=feed"" title=""Jobs"" href=""Runbooks(guid'b183675e-f047-498b-8a72-8d07fcb43d3d')/Jobs"" />
    <link rel=""http://schemas.microsoft.com/ado/2007/08/dataservices/related/Instances"" type=""application/atom+xml;type=feed"" title=""Instances"" href=""Runbooks(guid'b183675e-f047-498b-8a72-8d07fcb43d3d')/Instances"" />
    <link rel=""http://schemas.microsoft.com/ado/2007/08/dataservices/related/Diagram"" type=""application/atom+xml;type=entry"" title=""Diagram"" href=""Runbooks(guid'b183675e-f047-498b-8a72-8d07fcb43d3d')/Diagram"" />
    <link rel=""http://schemas.microsoft.com/ado/2007/08/dataservices/related/Statistics"" type=""application/atom+xml;type=feed"" title=""Statistics"" href=""Runbooks(guid'b183675e-f047-498b-8a72-8d07fcb43d3d')/Statistics"" />
    <category term=""Microsoft.SystemCenter.Orchestrator.WebService.Runbook"" scheme=""http://schemas.microsoft.com/ado/2007/08/dataservices/scheme"" />
    <content type=""application/xml"">
      <m:properties>
        <d:Id m:type=""Edm.Guid"">b183675e-f047-498b-8a72-8d07fcb43d3d</d:Id>
        <d:FolderId m:type=""Edm.Guid"">aa71169f-b0e5-4ae8-a475-9d793a98eadd</d:FolderId>
        <d:Name>Reset Password</d:Name>
        <d:Description m:null=""true"" />
        <d:CreatedBy>S-1-5-500</d:CreatedBy>
        <d:CreationTime m:type=""Edm.DateTime"">2020-11-17T12:34:31.33</d:CreationTime>
        <d:LastModifiedBy>S-1-5-21-1709059561-2143686068-2252755103-1103</d:LastModifiedBy>
        <d:LastModifiedTime m:type=""Edm.DateTime"">2020-11-18T07:47:15</d:LastModifiedTime>
        <d:IsMonitor m:type=""Edm.Boolean"">false</d:IsMonitor>
        <d:Path>\00-Dev\Reset Password\Reset Password</d:Path>
        <d:CheckedOutBy m:null=""true"" />
        <d:CheckedOutTime m:type=""Edm.DateTime"" m:null=""true"" />
      </m:properties>
    </content>
  </entry>
  <entry m:etag=""W/&quot;datetime'2020-11-17T11%3A59%3A43'&quot;"">
    <id>http://localhost:81/Orchestrator2012/Orchestrator.svc/Runbooks(guid'bf84ae75-8742-494c-8192-980c7244d8a8')</id>
    <title type=""text"">1min</title>
    <published>2020-11-17T11:58:17+01:00</published>
    <updated>2020-11-17T11:59:43+01:00</updated>
    <author>
      <name />
    </author>
    <link rel=""edit"" title=""Runbook"" href=""Runbooks(guid'bf84ae75-8742-494c-8192-980c7244d8a8')"" />
    <link rel=""http://schemas.microsoft.com/ado/2007/08/dataservices/related/Folder"" type=""application/atom+xml;type=entry"" title=""Folder"" href=""Runbooks(guid'bf84ae75-8742-494c-8192-980c7244d8a8')/Folder"" />
    <link rel=""http://schemas.microsoft.com/ado/2007/08/dataservices/related/Parameters"" type=""application/atom+xml;type=feed"" title=""Parameters"" href=""Runbooks(guid'bf84ae75-8742-494c-8192-980c7244d8a8')/Parameters"" />
    <link rel=""http://schemas.microsoft.com/ado/2007/08/dataservices/related/Activities"" type=""application/atom+xml;type=feed"" title=""Activities"" href=""Runbooks(guid'bf84ae75-8742-494c-8192-980c7244d8a8')/Activities"" />
    <link rel=""http://schemas.microsoft.com/ado/2007/08/dataservices/related/Jobs"" type=""application/atom+xml;type=feed"" title=""Jobs"" href=""Runbooks(guid'bf84ae75-8742-494c-8192-980c7244d8a8')/Jobs"" />
    <link rel=""http://schemas.microsoft.com/ado/2007/08/dataservices/related/Instances"" type=""application/atom+xml;type=feed"" title=""Instances"" href=""Runbooks(guid'bf84ae75-8742-494c-8192-980c7244d8a8')/Instances"" />
    <link rel=""http://schemas.microsoft.com/ado/2007/08/dataservices/related/Diagram"" type=""application/atom+xml;type=entry"" title=""Diagram"" href=""Runbooks(guid'bf84ae75-8742-494c-8192-980c7244d8a8')/Diagram"" />
    <link rel=""http://schemas.microsoft.com/ado/2007/08/dataservices/related/Statistics"" type=""application/atom+xml;type=feed"" title=""Statistics"" href=""Runbooks(guid'bf84ae75-8742-494c-8192-980c7244d8a8')/Statistics"" />
    <category term=""Microsoft.SystemCenter.Orchestrator.WebService.Runbook"" scheme=""http://schemas.microsoft.com/ado/2007/08/dataservices/scheme"" />
    <content type=""application/xml"">
      <m:properties>
        <d:Id m:type=""Edm.Guid"">bf84ae75-8742-494c-8192-980c7244d8a8</d:Id>
        <d:FolderId m:type=""Edm.Guid"">e4002667-4008-47de-8d0d-2ae65d8f6da4</d:FolderId>
        <d:Name>1min</d:Name>
        <d:Description m:null=""true"" />
        <d:CreatedBy>S-1-5-500</d:CreatedBy>
        <d:CreationTime m:type=""Edm.DateTime"">2020-11-17T11:58:17.17</d:CreationTime>
        <d:LastModifiedBy>S-1-5-21-1709059561-2143686068-2252755103-1103</d:LastModifiedBy>
        <d:LastModifiedTime m:type=""Edm.DateTime"">2020-11-17T11:59:43</d:LastModifiedTime>
        <d:IsMonitor m:type=""Edm.Boolean"">true</d:IsMonitor>
        <d:Path>\00-Dev\Schedules\1min\1min</d:Path>
        <d:CheckedOutBy m:null=""true"" />
        <d:CheckedOutTime m:type=""Edm.DateTime"" m:null=""true"" />
      </m:properties>
    </content>
  </entry>
  <entry m:etag=""W/&quot;datetime'2020-11-23T10%3A13%3A58.55'&quot;"">
    <id>http://localhost:81/Orchestrator2012/Orchestrator.svc/Runbooks(guid'759f0d8e-55bd-47be-9136-b152495861d2')</id>
    <title type=""text"">New Runbook</title>
    <published>2020-11-23T10:13:58+01:00</published>
    <updated>2020-11-23T10:13:58+01:00</updated>
    <author>
      <name />
    </author>
    <link rel=""edit"" title=""Runbook"" href=""Runbooks(guid'759f0d8e-55bd-47be-9136-b152495861d2')"" />
    <link rel=""http://schemas.microsoft.com/ado/2007/08/dataservices/related/Folder"" type=""application/atom+xml;type=entry"" title=""Folder"" href=""Runbooks(guid'759f0d8e-55bd-47be-9136-b152495861d2')/Folder"" />
    <link rel=""http://schemas.microsoft.com/ado/2007/08/dataservices/related/Parameters"" type=""application/atom+xml;type=feed"" title=""Parameters"" href=""Runbooks(guid'759f0d8e-55bd-47be-9136-b152495861d2')/Parameters"" />
    <link rel=""http://schemas.microsoft.com/ado/2007/08/dataservices/related/Activities"" type=""application/atom+xml;type=feed"" title=""Activities"" href=""Runbooks(guid'759f0d8e-55bd-47be-9136-b152495861d2')/Activities"" />
    <link rel=""http://schemas.microsoft.com/ado/2007/08/dataservices/related/Jobs"" type=""application/atom+xml;type=feed"" title=""Jobs"" href=""Runbooks(guid'759f0d8e-55bd-47be-9136-b152495861d2')/Jobs"" />
    <link rel=""http://schemas.microsoft.com/ado/2007/08/dataservices/related/Instances"" type=""application/atom+xml;type=feed"" title=""Instances"" href=""Runbooks(guid'759f0d8e-55bd-47be-9136-b152495861d2')/Instances"" />
    <link rel=""http://schemas.microsoft.com/ado/2007/08/dataservices/related/Diagram"" type=""application/atom+xml;type=entry"" title=""Diagram"" href=""Runbooks(guid'759f0d8e-55bd-47be-9136-b152495861d2')/Diagram"" />
    <link rel=""http://schemas.microsoft.com/ado/2007/08/dataservices/related/Statistics"" type=""application/atom+xml;type=feed"" title=""Statistics"" href=""Runbooks(guid'759f0d8e-55bd-47be-9136-b152495861d2')/Statistics"" />
    <category term=""Microsoft.SystemCenter.Orchestrator.WebService.Runbook"" scheme=""http://schemas.microsoft.com/ado/2007/08/dataservices/scheme"" />
    <content type=""application/xml"">
      <m:properties>
        <d:Id m:type=""Edm.Guid"">759f0d8e-55bd-47be-9136-b152495861d2</d:Id>
        <d:FolderId m:type=""Edm.Guid"">d81c0f1d-ed47-4ab6-9420-1bdbd2cb6d9d</d:FolderId>
        <d:Name>New Runbook</d:Name>
        <d:Description m:null=""true"" />
        <d:CreatedBy>S-1-5-500</d:CreatedBy>
        <d:CreationTime m:type=""Edm.DateTime"">2020-11-23T10:13:58.55</d:CreationTime>
        <d:LastModifiedBy>S-1-5-500</d:LastModifiedBy>
        <d:LastModifiedTime m:type=""Edm.DateTime"">2020-11-23T10:13:58.55</d:LastModifiedTime>
        <d:IsMonitor m:type=""Edm.Boolean"">false</d:IsMonitor>
        <d:Path>\00-Dev\SyncBenutzer\New Runbook</d:Path>
        <d:CheckedOutBy>S-1-5-21-1709059561-2143686068-2252755103-1103</d:CheckedOutBy>
        <d:CheckedOutTime m:type=""Edm.DateTime"">2020-11-23T10:14:04</d:CheckedOutTime>
      </m:properties>
    </content>
  </entry>
</feed>

";

        }
    }
}
