/*
 * Created by Ranorex
 * User: marci
 * Date: 03.10.2017
 * Time: 14:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System.Collections.Generic;
using System;
using Ranorex;
using System.Data.OracleClient;

namespace Asseco.CSharp.Core
{
	/// <summary>
	/// Description of MyClass.
	/// </summary>
	public class DbLogger
	{
		// TODO: Add Code to call testing functions - for example:	
		// Automation.Start()
		
		public static void Log(int id, System.DateTime dateTime, string description, EventType eventType)
        {
			 string sql = "insert into tst_ranorex_log(ID_LOG, DT_LOG, DESCRIPTION, ID_SEVERITY) values (:id,:dateTime,:description,:eventType)";

            string connectionString = "Data Source=BIGENEA; User Id=BIGENEA2; Password=BIGENEA2; Integrated Security = no;";
            OracleConnection connection = new OracleConnection(connectionString);

            try
            {

                connection.Open();

                OracleCommand command = new OracleCommand(sql, connection);

                OracleParameter idParameter = new OracleParameter("id", id);
                command.Parameters.Add(idParameter);
                OracleParameter dateTimeParameter = new OracleParameter("dateTime", dateTime);
                command.Parameters.Add(dateTimeParameter);
                OracleParameter descriptionParameter = new OracleParameter("description", description);
                command.Parameters.Add(descriptionParameter);
                OracleParameter eventTypeParameter = new OracleParameter("eventType", (int)eventType);
                command.Parameters.Add(eventTypeParameter);

                OracleString rowid;
                command.ExecuteOracleNonQuery(out rowid);
            }
            catch (OracleException e)
            {
            	Validate.Fail(String.Format("Wystąpił błąd bazy danych: {0}", e.Message));                
            }
            catch (System.Exception e)
            {
                Validate.Fail(String.Format("Wystąpił błąd: {0}", e.Message));
            }
            finally
            {
                connection.Close();
            }
        }
        
	}
	
	public enum EventType
    {
        Debug = 1, Info = 2, Warn = 3, Error = 4, Fatal = 5
    }
}