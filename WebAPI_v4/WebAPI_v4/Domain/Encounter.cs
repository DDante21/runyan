using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI_v4.Domain
{
    public class Encounter
    {
        public string ContractorName { get; set; }
        public string ContractNumber { get; set; }
        public string SiteName { get; set; }
        public int PkEncounterId { get; set; }
        public string Month { get; set; }
        public string Projected { get; set; }
        public DateTime LastEdited { get; set; }
        public string EditedBy { get; set; }
        public DateTime TheDate { get; set; }
        public int RYear { get; set; }
        public string InfoType { get; set; }
        public string UiControlName { get; set; }
        public string EncounterTypeDescription { get; set; }
        public int EncounterCount { get; set; }
    }
}