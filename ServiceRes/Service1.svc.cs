using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServiceRes
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы Service1.svc или Service1.svc.cs в обозревателе решений и начните отладку.
    public class Service1 : IService1
    {
        public string Select_ID(string login)
        {
            return SQLClass.Select_ID(login);
        }
        public string Select_Role(string login)
        {
            return SQLClass.Select_Role(login);
        }
        public string Exist_User(string login)
        {
            return SQLClass.Exist_User(login);
        }
        public string Exist_UserWithPass(string login, string password)
        {
            return SQLClass.Exist_UserWithPass(login, password);
        }

        public void Update_visitor(string login, string password, string f_name, string m_name, string l_name, string phone, string role, string id)
        {
            SQLClass.Update_visitor(login, password, f_name, m_name, l_name, phone, role, id);
        }

        public List<string> Select_visitor(string id)
        {
            return SQLClass.Select_visitor(id);
        }

        public void Delete_visitor(string id)
        {
            SQLClass.Delete_visitor(id);
        }
        public DataTable Select_admins()
        {
            return SQLClass.Select_admins();
        }

        public void Update_admin(string id)
        {
            SQLClass.Update_admin(id);
        }
        public void Insert_visitor(string login, string password, string f_name, string m_name, string l_name, string phone, string role)
        {
            SQLClass.Insert_visitor(login, password, f_name, m_name, l_name, phone, role);
        }

        public DataTable Select_reservation(string dateFrom, string dateTo)
        {
            if (dateFrom == "")
            {
                return SQLClass.Select_reservation();
            }
            return SQLClass.Select_reservation(dateFrom, dateTo);
        }

        public void Update_reservation(string id, string id_t, string date, string time)
        {
            SQLClass.Update_reservation(id, id_t, date, time);
        }

        public void Delete_reservation(string id)
        {
            SQLClass.Delete_reservation(id);
        }

        public void Insert_reservation(string TableId, string Date, string Time, string id)
        {
            SQLClass.Insert_reservation(TableId, Date, Time, id);
        }

        public List<string> Select_free_tables(string date, int time)
        {
            return SQLClass.Select_free_tables(date, time);
        }

        public List<string> Select_tables()
        {
            return SQLClass.Select_tables();
        }

        public void Delete_table(string id)
        {
            SQLClass.Delete_table(id); 
        }

        public void Update_table(List<string> dt)
        {
            SQLClass.Update_table(dt);
        }
    }
}
