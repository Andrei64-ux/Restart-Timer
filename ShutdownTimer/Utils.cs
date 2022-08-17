using ShutdownTimer;
using System;
using System.Collections;
using System.Data.SqlClient;
using System.Linq;
using System.Management;

namespace sqltest
{
    public class Utils
    {
        private static ArrayList ipList;

        public static ArrayList readFromDB()
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "40.10.0.50.database.windows.net";
                builder.UserID = "usr_intern";
                builder.Password = "STu.22!pa20dos";
                builder.InitialCatalog = "ASSETS";
                ArrayList ipList = new ArrayList();
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {

                    String sql = "SELECT eq.IPAdress FROM [ASSETS].[dbo].[AutoRestartPCs] arp JOIN [ASSETS].[dbo].[Equipments] eq ON arp.IDEQ = eq.ID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ipList.Add(reader.GetString(reader.GetOrdinal("IPAddress")));
                            }
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.ReadLine();
            }
            return ipList;
        }

        public static void updateDB()
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "40.10.0.50.database.windows.net";
                builder.UserID = "usr_intern";
                builder.Password = "STu.22!pa20dos";
                builder.InitialCatalog = "ASSETS";
                ArrayList ipList = readFromDB();
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    foreach (string ip in ipList)
                    {
                        String sql = "update [ASSETS].[dbo].[AutoRestartPCs] set LastRestartDate = " + GetLastBootUpTimeViaWMI(ip) +
                                     ", NextRestartDate = " + GetNextBootUpTimeViaWMI() + " where ID =" +
                                     "(SELECT arp.ID FROM[ASSETS].[dbo].[AutoRestartPCs] arp JOIN[ASSETS].[dbo].[Equipments] eq ON arp.IDEQ = eq.ID where eq.IPAdress = " + ip +
                                     ")";

                        using (SqlCommand command = new SqlCommand(sql, connection))

                            connection.Open();
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.ReadLine();
            }
        }

        public static DateTime GetLastBootUpTimeViaWMI(string ip)
        {
            var scope = new ManagementScope(string.Format(@"\\{0}\root\cimv2", ip));
            scope.Connect();
            var query = new ObjectQuery("SELECT LastBootUpTime FROM Win32_OperatingSystem");
            var searcher = new ManagementObjectSearcher(scope, query);
            var firstResult = searcher.Get().OfType<ManagementObject>().First();
            return ManagementDateTimeConverter.ToDateTime(firstResult["LastBootUpTime"].ToString());
        }

        public static DateTime GetNextBootUpTimeViaWMI()
        {
            Form1 x = new Form1();
            x.LoadTotalDateTime();
            return DateTime.Now.AddHours(x.totalDateTime);
        }
    }
}