using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TODOList2
{
    internal class SQL
    {
        static SqlConnectionStringBuilder connectionString;

        public static Queue<string> sqlqueue = new Queue<string>();

        public SQL(String data_source, String Initial_Catalog) {
            connectionString = new SqlConnectionStringBuilder() {
                DataSource = data_source,
                InitialCatalog = Initial_Catalog,
                IntegratedSecurity = true
            };
        }

        public static SqlConnection connection() {
            return new SqlConnection(connectionString.ConnectionString);
        }

        public static void guardar() {
            SqlConnection conexion = connection();
            conexion.Open();
            foreach(string set in  sqlqueue)
            {
                SqlCommand cmd = new SqlCommand(set, conexion);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Guardado con exito");
            conexion.Close();
        }

        public static void cargar(ListBox set) {
            SqlConnection conexion = connection();
            conexion.Open();
            String command = "Select * from Tasks";
            SqlCommand cmd = new SqlCommand(command, conexion);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                
                set.Items.Add(new Tasks(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetBoolean(3)));
            }
            MessageBox.Show("Cargado con exito");
            conexion.Close();
        }


    }
}
