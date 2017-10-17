using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI_v4.Common;
using WebAPI_v4.Domain;
using WebAPI_v4.BLL;



namespace WebAPI_v4.BLL
{
    public class Encounters
    {
        public static List<Encounter> GetByIDs(GetOptionsForEncounter getOptions)
        {
            List<Encounter> eList;
            //
            //string strMonth = Utilities.getAnnualMonths_Lookup(month);
            //string strStartDate = strYear + "-" + strMonth + "-01";
            //string strEndDate = strYear + "-" + strMonth + "-01";

            //if (strInfoType == "projection")
            //{
            //    //month = "";
            //}
            string strContractIds;
            //strContractIds = BLL.Contracts.getContractsStrings_new(getOptions.ContractorIDs, getOptions.SiteIDs, getOptions.RYear, getOptions.StrMonth);

            Common.ContractQuery getOptionsForContracts = new Common.ContractQuery();
            getOptionsForContracts.ContractorIDs = getOptions.ContractorIDs;
            getOptionsForContracts.SiteIDs = getOptions.SiteIDs;
            getOptionsForContracts.RYear = getOptions.RYear;
            getOptionsForContracts.strMonth = getOptions.StrMonth;

            //strContractIds = BLL.Contracts.getContractsStrings_new(getOptionsForContracts);

            //getOptions.ContractIDs = strContractIds;

            eList = DAL.Encounters.GetByIDs(getOptions);

            return eList;
        }

    }
}