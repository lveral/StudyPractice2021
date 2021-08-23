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
    }
}
