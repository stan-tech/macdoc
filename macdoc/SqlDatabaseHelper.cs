using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace macdoc
{
    public class SqlDatabaseHelper
    {

        public static string Users = "users";
        public static string Machine = "users";
        public static string Staff_activity = "users";


        public static string SelectComponentNumber(string selected_component, string selected_machine)
        {
            string compnum = "";
            using (SQLiteConnection connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {
                if (connection.State == ConnectionState.Closed)
                {

                    if (Equals(selected_component, "Vérin"))
                    {
                        selected_component = "verin";
                    }

                    connection.Open();

                    string composants_num = "select" +
                               " count(id_machine) as counts from " + selected_component + " inner join machine on id_machine =" +
                                "machine.id  where machine.nom = '" + selected_machine + "'; ";

                    SQLiteCommand cmd = new SQLiteCommand(composants_num, connection);

                    compnum = cmd.ExecuteScalar().ToString();



                }
                else
                {
                    connection.Close();

                }

            }

            return compnum;

        }



    }
}
