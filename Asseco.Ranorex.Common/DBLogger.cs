using System;
using System.Data.OracleClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asseco.Ranorex.Common
{
    public class DbLogger
    {
        public static void Log(int id, DateTime dateTime, string description, EventType eventType)
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

                command.ExecuteOracleNonQuery(out OracleString rowid);
            }
            catch (OracleException e)
            {
                Console.WriteLine("Wystąpił błąd bazy danych: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Wystąpił błąd: " + e.Message);
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
