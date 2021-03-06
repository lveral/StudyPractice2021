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
        public static string Exist_Table(string number)
        {
            return SQLClass.Request("SELECT COUNT(*) FROM tables WHERE number =" + number + "")[0];
        }
        public static string Select_ID_table(string number)
        {
            return SQLClass.Request("SELECT id FROM tables WHERE number ='" + number + "'")[0];
        }
        public static string Select_ID(string login)
        {
            return SQLClass.Request("SELECT id FROM visitors WHERE login ='" + login + "'")[0];
        }
        public static string Select_Role(string login)
        {
            return SQLClass.Request("SELECT role FROM visitors WHERE login = '" + login + "'")[0];
        }
        public static List<string> Select_reservation(string dateFrom = "", string dateTo = "" )
        {
            if (dateFrom == "")
            {
                string curDate = DateTime.Now.ToString("yyyy-MM-dd");
                return SQLClass.Request(@"with reserved_t as 
                    (Select r.id, r.id_t, r.id_v, t.number, r.date, r.time from tables t 
                    inner JOIN reservation r on t.id = r.id_t) 
                    select r.id, r.id_t, r.number, r.date, r.time,v.f_name, v.m_name, v.l_name, 
                    v.phone, v.login from visitors v 
                    inner join reserved_t r on v.id = r.id_v 
                    where date >= '" + curDate + "' order by date");
            }
            return SQLClass.Request(@"with reserved_t as 
                    (Select r.id, r.id_t, r.id_v, t.number, r.date, r.time from tables t 
                    inner JOIN reservation r on t.id = r.id_t) 
                    select r.id, r.id_t, r.number, r.date, r.time,v.f_name, v.m_name, v.l_name, 
                    v.phone, v.login from visitors v 
                    inner join reserved_t r on v.id = r.id_v 
                    where date between '" + dateFrom + "' and '" + dateTo + "' order by date");
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
        public static List<string> Select_admins()
        {
            return SQLClass.Request("select id, f_name, m_name, l_name, phone, login from visitors where role = 'администратор' order by f_name");
        }
        public static void Update_admin(string id)
        {
            SQLClass.Query("update visitors set role = 'посетитель' where id = " + id);
        }
        public static List<string> Select_free_tables(string date, int time)
        {
            return SQLClass.Request(String.Format("with reserved_t as " +
                "(Select t.id, t.persons, t.number from tables t " +
                "full JOIN reservation r on t.id = r.id_t " +
                "where r.date = '{0}' and r.time BETWEEN '{1}:10' AND '{2}:50') " +
                "select t.id, t.number, t.persons from tables t " +
                "LEFT OUTER join reserved_t r on t.id = r.id " +
                "where r.id is NULL " +
                "order by t.number", date, time - 2, time + 1));
        }
        public static string Select_reserved_tables(string id_t,string date, int time)
        {
            return SQLClass.Request(String.Format(" select COUNT(*) from reservation where id_t = {0} " +
                "and date = '{1}' and time BETWEEN '{2}:10' AND '{3}:50'", id_t, date, time - 2, time + 1))[0];
        }
        public static List<string> Select_tables()
        {
            return SQLClass.Request(@"select id, number, persons from tables order by number");
        }
        public static List<string> Select_number_tables()
        {
            return SQLClass.Request(@"select number from tables");
        }
        public static void Delete_table(string id_t)
        {
            SQLClass.Query("Delete from tables where id = " + id_t);
        }
        public static void Update_table(string id, string persons, string number)
        {
            SQLClass.Query("update tables set persons = '" + persons + "', number = '" + number + "' where id = " + id);
        }
        public static void Add_table(string number, string persons)
        {
            SQLClass.Query("insert into tables(number, persons) values ('" + number + "', '"+ persons + "')");
        }
        
    }
}
