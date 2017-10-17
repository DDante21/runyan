using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI_v4.Common
{
    public class GetOptionsForEncounter
    {
        public string hSessionID { get; set; }
        public string reportType { get; set; }
        public string ContractorIDs { get; set; }
        public string contractNumber { get; set; }
        public string ContractIDs { get; set; }
        public string SiteIDs { get; set; }
        public string RYear { get; set; }
        public string InfoType { get; set; }
        public string EncounterTypeDescription { get; set; }
        public string StrMonth { get; set; }
        public int MonthCount { get; set; }
    }
}