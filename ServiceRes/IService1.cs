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
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IService1" в коде и файле конфигурации.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string Select_ID(string login);

        [OperationContract]
        string Select_Role(string login);

        [OperationContract]
        string Exist_User(string login);

        [OperationContract]
        string Exist_UserWithPass(string login, string password);

        [OperationContract]
        void Update_visitor(string login, string password, string f_name, string m_name, string l_name, string phone, string role, string id);

        [OperationContract]
        List<string> Select_visitor(string id);

        [OperationContract]
        void Delete_visitor(string id);

        [OperationContract]
        DataTable Select_admins();

        [OperationContract]
        void Update_admin(string id);

        [OperationContract]
        void Insert_visitor(string login, string password, string f_name, string m_name, string l_name, string phone, string role);

        [OperationContract]
        DataTable Select_reservation(string dateFrom,string dateTo);

        [OperationContract]
        void Update_reservation(string id,string id_t,string date,string time);

        [OperationContract]
        void Delete_reservation(string id);

        [OperationContract]
        void Insert_reservation(string TableId,string Date,string Time, string id);

        [OperationContract]
        List<string> Select_free_tables(string date,int time);

        [OperationContract]
        List<string> Select_tables();

        [OperationContract]
        void Delete_table(string id);

        [OperationContract]
        void Update_table(List<string> dt);
        // TODO: Добавьте здесь операции служб
    }


    // Используйте контракт данных, как показано в примере ниже, чтобы добавить составные типы к операциям служб.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
