using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace E4ADRI
{
    public class conexion
    {
        private string server="localhost";
        private string database="bdadriana";
        private string user="root";
        private string password="";
        private string cadConexion;
        

        public conexion()
        {
            cadConexion= "server=" + server + ";database=" + database + ";Uid=" + user + ";pwd=" + password + ";";

        }
        public MySqlConnection AbrirConexion()
        {
            MySqlConnection conexion = new MySqlConnection(cadConexion);
            conexion.Open();
            return conexion;
        }


    }
}
