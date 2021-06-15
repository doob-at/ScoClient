using System.Collections.Generic;

namespace SCO.Models
{
    public class StartRunbookRequest
    {
        public string RunbookId { get; set; }
        public string RunbookServers { get; set; }
        public List<StartRunbookParameter> Parameters { get; set; }
    }

    public class StartRunbookParameter
    {
        public string Id { get; set; }
        public string Value { get; set; }
    }
}
