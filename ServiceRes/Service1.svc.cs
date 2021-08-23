using System;
using System.Collections.Generic;
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
            return SQLClass.Select_ID(login);
        }
        public string Exist_UserWithPass(string login, string password)
        {
            return SQLClass.Select_Role(login);
        }

    }
}
