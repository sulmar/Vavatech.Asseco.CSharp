using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.6.1\System.Data.OracleClient.dll
/// </summary>
namespace Asseco.CSharp.Db
{
    class Program
    {
        static void Main(string[] args)
        {
            GetDataTest();
            //AddDataTest();
            AddDataTestWithParameters();
        }

        private static void AddDataTestWithParameters()
        {
            int id = 1;
            DateTime dateTime = DateTime.Now;
            string description = "[sm]Wykonano test";
            EventType eventType = EventType.Error;
            //string sql = String.Format("insert into tst_ranorex_log(ID_LOG, DT_LOG, DESCRIPTION, ID_SEVERITY) values ({0},'{1:yyyyMMdd}','[sm]{2}',{3})", id, dateTime, description, (int)eventType);
            string sql = "insert into tst_ranorex_log(ID_LOG, DT_LOG, DESCRIPTION, ID_SEVERITY) values (:id,:dateTime,:description,:eventType)";

            string connectionString = "Data Source=BIGENEA;User Id=BIGENEA2;Password=BIGENEA2; Integrated Security = no;";
            OracleConnection connection = new OracleConnection(connectionString);
            
            try
            {

                connection.Open();

                OracleCommand command = new OracleCommand(sql, connection);

                OracleParameter idParameter = new OracleParameter("id", id);
                command.Parameters.Add(idParameter);
                OracleParameter dateTimeParameter = new OracleParameter("dateTime", dateTime);
                command.Parameters.Add(dateTimeParameter);
                OracleParameter descriptionParameter = new OracleParameter("description",  description);
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

        private static void AddDataTest()
        {
            int id = 1;
            DateTime dateTime = DateTime.Now;
            string description = "Wykonano test";
            EventType eventType = EventType.Error;
            string sql = String.Format("insert into tst_ranorex_log(ID_LOG, DT_LOG, DESCRIPTION, ID_SEVERITY) values ({0},'{1:yyyyMMdd}','[sm]{2}',{3})", id, dateTime, description, (int)eventType);

            string connectionString = "Data Source=BIGENEA;User Id=BIGENEA2;Password=BIGENEA2; Integrated Security = no;";
            OracleConnection connection = new OracleConnection(connectionString);


            try
            {

                connection.Open();
                
                OracleCommand command = new OracleCommand(sql, connection);
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

        private static void GetDataTest()
        {
            string connectionString = "Data Source=BIGENEA;User Id=BIGENEA2;Password=BIGENEA2; Integrated Security = no;";

            OracleConnection connection = new OracleConnection(connectionString);

            try
            {
                connection.Open();

                string sql = "Select consumption, rate, expected from tst_calculationData";
                OracleCommand command = new OracleCommand(sql, connection);
                OracleDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string consumption = reader.GetString(0);
                    string rate = reader.GetString(1);
                    string expected = reader.GetString(2);

                    Console.WriteLine($"Zużycie energii: {consumption}, {rate}, {expected}");
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }
        }
    }

    enum EventType
    {
        Debug = 1, Info = 2, Warn = 3, Error = 4, Fatal = 5
    }
        
}
