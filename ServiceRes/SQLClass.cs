using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;

namespace ServiceRes
{
    class SQLClass
    {
        
        public static NpgsqlConnection con = new NpgsqlConnection(@"Server = localhost; Port = 5432; User Id = postgres; Password = Urekina1112; Database = data;");
        public static NpgsqlDataAdapter nda;
        public static NpgsqlCommandBuilder ncb;
        static DataTable dt;
        public static List<string> Request(string Text)
        {
            con.Open();
            List<string> result = new List<string>();

            NpgsqlCommand cmd = new NpgsqlCommand(Text, con);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    result.Add(reader.GetValue(i).ToString());
                }
            }
            reader.Close();
            cmd.Dispose();
            con.Close();

            return result;
            
        }
        public static void Query(string Text)
        {
            con.Open();

            NpgsqlCommand cmd = new NpgsqlCommand(Text, con);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            
            reader.Close();
            cmd.Dispose();

            con.Close();
        }
        public static void Insert_visitor(string login, string password, string f_name, string m_name, string l_name, string phone, string role)
        {
            SQLClass.Query("insert into visitors(login, password, f_name, m_name, l_name, phone, role) values( '" +
                login + "', '" +
                password + "', '" +
                f_name + "', '" +
                m_name + "', '" +
                l_name + "', '" +
                phone + "', '" +
                role + "')");
        }
        public static List<string> Select_visitor(string id)
        {
            return SQLClass.Request("select login, password, f_name, m_name, l_name, phone, role " +
                "from visitors where id = " + id);
        }
        public static void Update_visitor(string login, string password, string f_name, string m_name, string l_name, string phone, string role, string id)
        {
            SQLClass.Query("update visitors set login = '" + login +
                "', password = '" + password +
                "', f_name = '" + f_name +
                "', m_name = '" + m_name +
                "', l_name = '" + l_name +
                "', phone = '" + phone +
                "', role = '" + role +
                "' where id = " + id);
        }
        public static void Delete_visitor(string id)
        {
            SQLClass.Query("delete from visitors where id = " + id);
        }
        public static string Exist_User(string login)
        {
            return SQLClass.Request("SELECT COUNT(*) FROM visitors WHERE login ='" + login + "'")[0];
        }
        public static string Exist_UserWithPass(string login, string password)
        {
            return SQLClass.Request("SELECT COUNT(*) FROM visitors WHERE login = '" + login +
                "' AND password = '" + password + "'")[0];
        }
        public static string Select_ID(string login)
        {
            return SQLClass.Request("SELECT id FROM visitors WHERE login ='" + login + "'")[0];
        }
        public static string Select_Role(string login)
        {
            return SQLClass.Request("SELECT role FROM visitors WHERE login = '" + login + "'")[0];
        }
        public static DataTable Select_reservation(string dateFrom = "", string dateTo = "" )
        {
            if (dateFrom == "")
            {
                string curDate = DateTime.Now.ToString("yyyy-MM-dd");
                SQLClass.nda = new NpgsqlDataAdapter(@"select r.id, r.id_t as ""Номер стола"", r.date as ""Дата"", r.time as ""Время"",
                    v.f_name as ""Фамилия"", v.m_name as ""Имя"", v.l_name as ""Отчество"", 
                    v.phone as ""Номер телефона"", v.login as ""Почта"" from visitors v 
                    inner join reservation r on v.id = r.id_v
                    where date >= '" + curDate + "' order by date", SQLClass.con);
                dt = new DataTable();
                SQLClass.nda.Fill(dt);
                return dt;
            }
            SQLClass.nda = new NpgsqlDataAdapter(@"select r.id, r.id_t as ""Номер стола"", r.date as ""Дата"", r.time as ""Время"",
                v.f_name as ""Фамилия"", v.m_name as ""Имя"", v.l_name as ""Отчество"", 
                v.phone as ""Номер телефона"", v.login as ""Почта"" from visitors v 
                inner join reservation r on v.id = r.id_v
                where date between '" + dateFrom + "' and '" + dateTo + "' order by date", SQLClass.con);
            dt = new DataTable();
            SQLClass.nda.Fill(dt);
            return dt;
        }
        public static void Update_reservation(string id, string id_t, string date, string time)
        {
            SQLClass.Query("update reservation set id_t = " + id_t + ", date = '" + date + "', " +
                "time = '" + time + "' where id = " + id);
        }
        public static void Delete_reservation(string id)
        {
            SQLClass.Query("Delete from reservation where id = " + id);
        }
        public static void Insert_reservation(string TableId, string Date, string Time, string id)
        {
            SQLClass.Query("insert into reservation(id_v,id_t,date,time) values(" + id + "," + TableId +
            "," + "'" + Date + "'" + "," + "'" + Time + "')");
        }
        public static DataTable Select_admins()
        {
            SQLClass.nda = new NpgsqlDataAdapter(@"select id, f_name as ""Фамилия"", m_name as ""Имя"", 
                l_name as ""Отчество"", phone as ""Номер телефона"", login as ""Почта"" from visitors 
                where role = 'администратор'
                order by f_name", SQLClass.con);
            dt = new DataTable();
            SQLClass.nda.Fill(dt);
            return dt;
        }
        public static void Update_admin(string id)
        {
            SQLClass.Query("update visitors set role = 'посетитель' where id = " + id);
        }
        public static List<string> Select_free_tables(string date, int time)
        {
            return SQLClass.Request(String.Format("with reserved_t as " +
                "(Select t.id, t.persons from tables t " +
                "full JOIN reservation r on t.id = r.id_t " +
                "where r.date = '{0}' and r.time BETWEEN '{1}:10' AND '{2}:50') " +
                "select t.id, t.persons from tables t " +
                "LEFT OUTER join reserved_t r on t.id = r.id " +
                "where r.id is NULL " +
                "order by t.id", date, time - 2, time + 1));
        }
        public static List<string> Select_tables()
        {
            /*
            SQLClass.nda = new NpgsqlDataAdapter(@"select id as ""Номер стола"", persons as ""Количество персон"" from tables", SQLClass.con);
            dt = new DataTable();
            SQLClass.nda.Fill(dt);*/

            return SQLClass.Request(@"select id, persons from tables");
        }
        public static void Delete_table(string id_t)
        {
            SQLClass.Query("Delete from tables where id = " + id_t);
        }
        public static void Update_table(List<string> dtl)
        {
            List<string> NameColumns = new List<string>();
            NameColumns.Add("Номер стола");
            NameColumns.Add("Количество персон");

            List<string> list = dtl.ToList<string>();
            List<string[]> list2 = new List<string[]>();
            for (int i = 0; i < list.Count; i += 2)
            {
                list2.Add(new string[] { list[i], list[i + 1] });
            }
            dt = ToDataTable(list2, NameColumns);

            SQLClass.nda = new NpgsqlDataAdapter(@"select id as ""Номер стола"", persons as ""Количество персон"" from tables", SQLClass.con);

            ncb = new NpgsqlCommandBuilder(nda);
            nda.Update(dt);
        }
        public static DataTable ToDataTable(List<string[]> list, List<string> NameColums)
        {
            // New table.
            DataTable table = new DataTable();

            // Get max columns.
            int columns = 0;
            foreach (var array in list)
            {
                if (array.Length > columns)
                {
                    columns = array.Length;
                }
            }

            // Add columns.
            for (int i = 0; i < columns; i++)
            {
                table.Columns.Add(NameColums[i]);
            }

            // Add rows.
            foreach (var array in list)
            {
                table.Rows.Add(array);
            }

            return table;
        }
    }
}
