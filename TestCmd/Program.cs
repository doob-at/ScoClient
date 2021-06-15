using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using doob.ScoClient;


namespace TestCmd
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var creds = new NetworkCredential("bwlab\\admin","ABC12abc");
            var sco = new SCOClient("http://192.168.75.121:81", options => options.WithCredential("bwlab\\admin","ABC12abc"));

            //var rb = await sco.GetRunbookById("849e1d7a-40a8-4ed8-ae43-63ec5c61bdc6");
            var rb = (await sco.GetRunbooksByName("Autopatching.PatchObject.Reboot"))?.FirstOrDefault();

            var rb2 = await sco.GetRunbookByPath(@"\00-Dev\2");
            //var par = await sco.GetRunbookParameters(rb.Id);

            var allrbs = await sco.GetRunbooks();

            //foreach (var runbook in allrbs)
            //{
            //    var par = await sco.GetRunbookParameters(runbook.Id);
            //}

            await sco.StartRunbook(rb, new Dictionary<string, object> {["POID"] = "234"});
        }
    }
}
