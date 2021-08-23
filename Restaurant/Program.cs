using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SQLClass.con = new Npgsql.NpgsqlConnection();
            SQLClass.con.ConnectionString = @"Server = localhost; Port = 5432; User Id = postgres; Password = Urekina1112; Database = data;";
            SQLClass.con.Open();

            Application.Run(new AuthoForm());

            SQLClass.con.Close();
        }
        public static string ID;
        public static string Role;
    }
}
