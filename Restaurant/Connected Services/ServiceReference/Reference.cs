﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Restaurant.ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Select_ID", ReplyAction="http://tempuri.org/IService1/Select_IDResponse")]
        string Select_ID(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Select_ID", ReplyAction="http://tempuri.org/IService1/Select_IDResponse")]
        System.Threading.Tasks.Task<string> Select_IDAsync(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Select_Role", ReplyAction="http://tempuri.org/IService1/Select_RoleResponse")]
        string Select_Role(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Select_Role", ReplyAction="http://tempuri.org/IService1/Select_RoleResponse")]
        System.Threading.Tasks.Task<string> Select_RoleAsync(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Exist_User", ReplyAction="http://tempuri.org/IService1/Exist_UserResponse")]
        string Exist_User(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Exist_User", ReplyAction="http://tempuri.org/IService1/Exist_UserResponse")]
        System.Threading.Tasks.Task<string> Exist_UserAsync(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Exist_UserWithPass", ReplyAction="http://tempuri.org/IService1/Exist_UserWithPassResponse")]
        string Exist_UserWithPass(string login, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Exist_UserWithPass", ReplyAction="http://tempuri.org/IService1/Exist_UserWithPassResponse")]
        System.Threading.Tasks.Task<string> Exist_UserWithPassAsync(string login, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Update_visitor", ReplyAction="http://tempuri.org/IService1/Update_visitorResponse")]
        void Update_visitor(string login, string password, string f_name, string m_name, string l_name, string phone, string role, string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Update_visitor", ReplyAction="http://tempuri.org/IService1/Update_visitorResponse")]
        System.Threading.Tasks.Task Update_visitorAsync(string login, string password, string f_name, string m_name, string l_name, string phone, string role, string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Select_visitor", ReplyAction="http://tempuri.org/IService1/Select_visitorResponse")]
        string[] Select_visitor(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Select_visitor", ReplyAction="http://tempuri.org/IService1/Select_visitorResponse")]
        System.Threading.Tasks.Task<string[]> Select_visitorAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Delete_visitor", ReplyAction="http://tempuri.org/IService1/Delete_visitorResponse")]
        void Delete_visitor(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Delete_visitor", ReplyAction="http://tempuri.org/IService1/Delete_visitorResponse")]
        System.Threading.Tasks.Task Delete_visitorAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Select_admins", ReplyAction="http://tempuri.org/IService1/Select_adminsResponse")]
        string[] Select_admins();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Select_admins", ReplyAction="http://tempuri.org/IService1/Select_adminsResponse")]
        System.Threading.Tasks.Task<string[]> Select_adminsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Update_admin", ReplyAction="http://tempuri.org/IService1/Update_adminResponse")]
        void Update_admin(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Update_admin", ReplyAction="http://tempuri.org/IService1/Update_adminResponse")]
        System.Threading.Tasks.Task Update_adminAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Insert_visitor", ReplyAction="http://tempuri.org/IService1/Insert_visitorResponse")]
        void Insert_visitor(string login, string password, string f_name, string m_name, string l_name, string phone, string role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Insert_visitor", ReplyAction="http://tempuri.org/IService1/Insert_visitorResponse")]
        System.Threading.Tasks.Task Insert_visitorAsync(string login, string password, string f_name, string m_name, string l_name, string phone, string role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Select_reservation", ReplyAction="http://tempuri.org/IService1/Select_reservationResponse")]
        string[] Select_reservation(string dateFrom, string dateTo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Select_reservation", ReplyAction="http://tempuri.org/IService1/Select_reservationResponse")]
        System.Threading.Tasks.Task<string[]> Select_reservationAsync(string dateFrom, string dateTo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Update_reservation", ReplyAction="http://tempuri.org/IService1/Update_reservationResponse")]
        void Update_reservation(string id, string id_t, string date, string time);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Update_reservation", ReplyAction="http://tempuri.org/IService1/Update_reservationResponse")]
        System.Threading.Tasks.Task Update_reservationAsync(string id, string id_t, string date, string time);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Delete_reservation", ReplyAction="http://tempuri.org/IService1/Delete_reservationResponse")]
        void Delete_reservation(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Delete_reservation", ReplyAction="http://tempuri.org/IService1/Delete_reservationResponse")]
        System.Threading.Tasks.Task Delete_reservationAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Insert_reservation", ReplyAction="http://tempuri.org/IService1/Insert_reservationResponse")]
        void Insert_reservation(string TableId, string Date, string Time, string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Insert_reservation", ReplyAction="http://tempuri.org/IService1/Insert_reservationResponse")]
        System.Threading.Tasks.Task Insert_reservationAsync(string TableId, string Date, string Time, string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Select_free_tables", ReplyAction="http://tempuri.org/IService1/Select_free_tablesResponse")]
        string[] Select_free_tables(string date, int time);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Select_free_tables", ReplyAction="http://tempuri.org/IService1/Select_free_tablesResponse")]
        System.Threading.Tasks.Task<string[]> Select_free_tablesAsync(string date, int time);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Select_tables", ReplyAction="http://tempuri.org/IService1/Select_tablesResponse")]
        string[] Select_tables();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Select_tables", ReplyAction="http://tempuri.org/IService1/Select_tablesResponse")]
        System.Threading.Tasks.Task<string[]> Select_tablesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Delete_table", ReplyAction="http://tempuri.org/IService1/Delete_tableResponse")]
        void Delete_table(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Delete_table", ReplyAction="http://tempuri.org/IService1/Delete_tableResponse")]
        System.Threading.Tasks.Task Delete_tableAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Update_table", ReplyAction="http://tempuri.org/IService1/Update_tableResponse")]
        void Update_table(string id, string persons);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Update_table", ReplyAction="http://tempuri.org/IService1/Update_tableResponse")]
        System.Threading.Tasks.Task Update_tableAsync(string id, string persons);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Add_table", ReplyAction="http://tempuri.org/IService1/Add_tableResponse")]
        void Add_table(string id, string persons);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Add_table", ReplyAction="http://tempuri.org/IService1/Add_tableResponse")]
        System.Threading.Tasks.Task Add_tableAsync(string id, string persons);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Restaurant.ServiceReference.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Restaurant.ServiceReference.IService1>, Restaurant.ServiceReference.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Select_ID(string login) {
            return base.Channel.Select_ID(login);
        }
        
        public System.Threading.Tasks.Task<string> Select_IDAsync(string login) {
            return base.Channel.Select_IDAsync(login);
        }
        
        public string Select_Role(string login) {
            return base.Channel.Select_Role(login);
        }
        
        public System.Threading.Tasks.Task<string> Select_RoleAsync(string login) {
            return base.Channel.Select_RoleAsync(login);
        }
        
        public string Exist_User(string login) {
            return base.Channel.Exist_User(login);
        }
        
        public System.Threading.Tasks.Task<string> Exist_UserAsync(string login) {
            return base.Channel.Exist_UserAsync(login);
        }
        
        public string Exist_UserWithPass(string login, string password) {
            return base.Channel.Exist_UserWithPass(login, password);
        }
        
        public System.Threading.Tasks.Task<string> Exist_UserWithPassAsync(string login, string password) {
            return base.Channel.Exist_UserWithPassAsync(login, password);
        }
        
        public void Update_visitor(string login, string password, string f_name, string m_name, string l_name, string phone, string role, string id) {
            base.Channel.Update_visitor(login, password, f_name, m_name, l_name, phone, role, id);
        }
        
        public System.Threading.Tasks.Task Update_visitorAsync(string login, string password, string f_name, string m_name, string l_name, string phone, string role, string id) {
            return base.Channel.Update_visitorAsync(login, password, f_name, m_name, l_name, phone, role, id);
        }
        
        public string[] Select_visitor(string id) {
            return base.Channel.Select_visitor(id);
        }
        
        public System.Threading.Tasks.Task<string[]> Select_visitorAsync(string id) {
            return base.Channel.Select_visitorAsync(id);
        }
        
        public void Delete_visitor(string id) {
            base.Channel.Delete_visitor(id);
        }
        
        public System.Threading.Tasks.Task Delete_visitorAsync(string id) {
            return base.Channel.Delete_visitorAsync(id);
        }
        
        public string[] Select_admins() {
            return base.Channel.Select_admins();
        }
        
        public System.Threading.Tasks.Task<string[]> Select_adminsAsync() {
            return base.Channel.Select_adminsAsync();
        }
        
        public void Update_admin(string id) {
            base.Channel.Update_admin(id);
        }
        
        public System.Threading.Tasks.Task Update_adminAsync(string id) {
            return base.Channel.Update_adminAsync(id);
        }
        
        public void Insert_visitor(string login, string password, string f_name, string m_name, string l_name, string phone, string role) {
            base.Channel.Insert_visitor(login, password, f_name, m_name, l_name, phone, role);
        }
        
        public System.Threading.Tasks.Task Insert_visitorAsync(string login, string password, string f_name, string m_name, string l_name, string phone, string role) {
            return base.Channel.Insert_visitorAsync(login, password, f_name, m_name, l_name, phone, role);
        }
        
        public string[] Select_reservation(string dateFrom, string dateTo) {
            return base.Channel.Select_reservation(dateFrom, dateTo);
        }
        
        public System.Threading.Tasks.Task<string[]> Select_reservationAsync(string dateFrom, string dateTo) {
            return base.Channel.Select_reservationAsync(dateFrom, dateTo);
        }
        
        public void Update_reservation(string id, string id_t, string date, string time) {
            base.Channel.Update_reservation(id, id_t, date, time);
        }
        
        public System.Threading.Tasks.Task Update_reservationAsync(string id, string id_t, string date, string time) {
            return base.Channel.Update_reservationAsync(id, id_t, date, time);
        }
        
        public void Delete_reservation(string id) {
            base.Channel.Delete_reservation(id);
        }
        
        public System.Threading.Tasks.Task Delete_reservationAsync(string id) {
            return base.Channel.Delete_reservationAsync(id);
        }
        
        public void Insert_reservation(string TableId, string Date, string Time, string id) {
            base.Channel.Insert_reservation(TableId, Date, Time, id);
        }
        
        public System.Threading.Tasks.Task Insert_reservationAsync(string TableId, string Date, string Time, string id) {
            return base.Channel.Insert_reservationAsync(TableId, Date, Time, id);
        }
        
        public string[] Select_free_tables(string date, int time) {
            return base.Channel.Select_free_tables(date, time);
        }
        
        public System.Threading.Tasks.Task<string[]> Select_free_tablesAsync(string date, int time) {
            return base.Channel.Select_free_tablesAsync(date, time);
        }
        
        public string[] Select_tables() {
            return base.Channel.Select_tables();
        }
        
        public System.Threading.Tasks.Task<string[]> Select_tablesAsync() {
            return base.Channel.Select_tablesAsync();
        }
        
        public void Delete_table(string id) {
            base.Channel.Delete_table(id);
        }
        
        public System.Threading.Tasks.Task Delete_tableAsync(string id) {
            return base.Channel.Delete_tableAsync(id);
        }
        
        public void Update_table(string id, string persons) {
            base.Channel.Update_table(id, persons);
        }
        
        public System.Threading.Tasks.Task Update_tableAsync(string id, string persons) {
            return base.Channel.Update_tableAsync(id, persons);
        }
        
        public void Add_table(string id, string persons) {
            base.Channel.Add_table(id, persons);
        }
        
        public System.Threading.Tasks.Task Add_tableAsync(string id, string persons) {
            return base.Channel.Add_tableAsync(id, persons);
        }
    }
}
