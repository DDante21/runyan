using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;              //requires System.Data reference
using System.Data.SqlClient;    //requires System.Data reference
using WebAPI_v4.Common;
using WebAPI_v4.Domain;

namespace WebAPI_v4.DAL
{
    public class Encounters
    {
        public static List<Encounter> GetByIDs(GetOptionsForEncounter getOptions)
        {
            List<Encounter> eList = new List<Encounter>();
            return eList;
        }

        public static List<Encounter> SpEncountersGet(string strContractorName, string strContractNumber,
               string strSiteName, string strYear, string strInfoType, string strEncounterTypeDescription, string strSearchMonth,
               string strConn)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();

            try
            {
                SqlConnection connection = new SqlConnection(strConn);
                cmd.Connection = connection;
                cmd.CommandText = "spEncounters_ReportingStatus_Get";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ContractorName", SqlDbType.VarChar, 100).Value = strContractorName;
                cmd.Parameters.Add("@ContractNumber", SqlDbType.VarChar, 100).Value = null;//strContractNumber;
                cmd.Parameters.Add("@SiteName", SqlDbType.VarChar, 100).Value = null;//strSiteName;
                cmd.Parameters.Add("@rYear", SqlDbType.VarChar, 100).Value = strYear;
                cmd.Parameters.Add("@infoType", SqlDbType.VarChar, 100).Value = strInfoType;
                cmd.Parameters.Add("@Status", SqlDbType.VarChar, 100).Value = null;//strInfoType;
                cmd.Parameters.Add("@EncounterTypeDescription", SqlDbType.VarChar, 100).Value = strEncounterTypeDescription;
                cmd.Parameters.Add("@Month", SqlDbType.VarChar, 100).Value = null;//strSearchMonth;
                cmd.Parameters.Add("@Certified", SqlDbType.VarChar, 100).Value = null;//strSearchMonth;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.SelectCommand.CommandTimeout = 300;

                adapter.Fill(ds);

                // DataTable tblEncounters = new DataTable();
                DataTable tblEncounters;
                tblEncounters = ds.Tables[0];

                List<Encounter> eList = new List<Encounter>();

                foreach (DataRow drCurrent in tblEncounters.Rows)
                {
                    Encounter q = new Encounter();

                    q.ContractorName = drCurrent["ContractorName"].ToString();
                    //q.ContractNumber = drCurrent["ContractNumber"].ToString();
                    //q.SiteName = drCurrent["SiteName"].ToString();
                    q.RYear = Convert.ToInt32(drCurrent["rYear"]);
                    //q.infoType = drCurrent["infoType"].ToString();
                    //q.Status = drCurrent["Status"].ToString();
                    q.EncounterTypeDescription = drCurrent["EncounterTypeDescription"].ToString();
                    q.Month = drCurrent["Month"].ToString();
                    //q.Certified = drCurrent["Certified"].ToString();

                    q.EncounterCount = Convert.ToInt32(drCurrent["EncounterCount"]);

                    eList.Add(q);
                }//next

                connection.Close();
                return eList;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}