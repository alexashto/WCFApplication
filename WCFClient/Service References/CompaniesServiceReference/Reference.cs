﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.18051
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFClient.CompaniesServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Company", Namespace="http://schemas.datacontract.org/2004/07/Companies.Domains")]
    [System.SerializableAttribute()]
    public partial class Company : WCFClient.CompaniesServiceReference.BaseEntity {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneField, value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BaseEntity", Namespace="http://schemas.datacontract.org/2004/07/Companies.Domains")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(WCFClient.CompaniesServiceReference.Employee))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(WCFClient.CompaniesServiceReference.Company))]
    public partial class BaseEntity : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employee", Namespace="http://schemas.datacontract.org/2004/07/Companies.Domains")]
    [System.SerializableAttribute()]
    public partial class Employee : WCFClient.CompaniesServiceReference.BaseEntity {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime BirthDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CompanyIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime EmploymentDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PositionField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime BirthDate {
            get {
                return this.BirthDateField;
            }
            set {
                if ((this.BirthDateField.Equals(value) != true)) {
                    this.BirthDateField = value;
                    this.RaisePropertyChanged("BirthDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CompanyId {
            get {
                return this.CompanyIdField;
            }
            set {
                if ((this.CompanyIdField.Equals(value) != true)) {
                    this.CompanyIdField = value;
                    this.RaisePropertyChanged("CompanyId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime EmploymentDate {
            get {
                return this.EmploymentDateField;
            }
            set {
                if ((this.EmploymentDateField.Equals(value) != true)) {
                    this.EmploymentDateField = value;
                    this.RaisePropertyChanged("EmploymentDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Position {
            get {
                return this.PositionField;
            }
            set {
                if ((object.ReferenceEquals(this.PositionField, value) != true)) {
                    this.PositionField = value;
                    this.RaisePropertyChanged("Position");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CompaniesServiceReference.ICompaniesService")]
    public interface ICompaniesService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompaniesService/GetCompanies", ReplyAction="http://tempuri.org/ICompaniesService/GetCompaniesResponse")]
        WCFClient.CompaniesServiceReference.Company[] GetCompanies();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompaniesService/GetCompanies", ReplyAction="http://tempuri.org/ICompaniesService/GetCompaniesResponse")]
        System.Threading.Tasks.Task<WCFClient.CompaniesServiceReference.Company[]> GetCompaniesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompaniesService/GetEmployees", ReplyAction="http://tempuri.org/ICompaniesService/GetEmployeesResponse")]
        WCFClient.CompaniesServiceReference.Employee[] GetEmployees();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompaniesService/GetEmployees", ReplyAction="http://tempuri.org/ICompaniesService/GetEmployeesResponse")]
        System.Threading.Tasks.Task<WCFClient.CompaniesServiceReference.Employee[]> GetEmployeesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompaniesService/GetCompany", ReplyAction="http://tempuri.org/ICompaniesService/GetCompanyResponse")]
        WCFClient.CompaniesServiceReference.Company GetCompany(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompaniesService/GetCompany", ReplyAction="http://tempuri.org/ICompaniesService/GetCompanyResponse")]
        System.Threading.Tasks.Task<WCFClient.CompaniesServiceReference.Company> GetCompanyAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompaniesService/GetEmployee", ReplyAction="http://tempuri.org/ICompaniesService/GetEmployeeResponse")]
        WCFClient.CompaniesServiceReference.Employee GetEmployee(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompaniesService/GetEmployee", ReplyAction="http://tempuri.org/ICompaniesService/GetEmployeeResponse")]
        System.Threading.Tasks.Task<WCFClient.CompaniesServiceReference.Employee> GetEmployeeAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompaniesService/DeleteCompany", ReplyAction="http://tempuri.org/ICompaniesService/DeleteCompanyResponse")]
        void DeleteCompany(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompaniesService/DeleteCompany", ReplyAction="http://tempuri.org/ICompaniesService/DeleteCompanyResponse")]
        System.Threading.Tasks.Task DeleteCompanyAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompaniesService/DeleteEmployee", ReplyAction="http://tempuri.org/ICompaniesService/DeleteEmployeeResponse")]
        void DeleteEmployee(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompaniesService/DeleteEmployee", ReplyAction="http://tempuri.org/ICompaniesService/DeleteEmployeeResponse")]
        System.Threading.Tasks.Task DeleteEmployeeAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompaniesService/AddCompany", ReplyAction="http://tempuri.org/ICompaniesService/AddCompanyResponse")]
        void AddCompany(WCFClient.CompaniesServiceReference.Company company);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompaniesService/AddCompany", ReplyAction="http://tempuri.org/ICompaniesService/AddCompanyResponse")]
        System.Threading.Tasks.Task AddCompanyAsync(WCFClient.CompaniesServiceReference.Company company);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompaniesService/AddEmployee", ReplyAction="http://tempuri.org/ICompaniesService/AddEmployeeResponse")]
        void AddEmployee(WCFClient.CompaniesServiceReference.Employee employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompaniesService/AddEmployee", ReplyAction="http://tempuri.org/ICompaniesService/AddEmployeeResponse")]
        System.Threading.Tasks.Task AddEmployeeAsync(WCFClient.CompaniesServiceReference.Employee employee);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICompaniesServiceChannel : WCFClient.CompaniesServiceReference.ICompaniesService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CompaniesServiceClient : System.ServiceModel.ClientBase<WCFClient.CompaniesServiceReference.ICompaniesService>, WCFClient.CompaniesServiceReference.ICompaniesService {
        
        public CompaniesServiceClient() {
        }
        
        public CompaniesServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CompaniesServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CompaniesServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CompaniesServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WCFClient.CompaniesServiceReference.Company[] GetCompanies() {
            return base.Channel.GetCompanies();
        }
        
        public System.Threading.Tasks.Task<WCFClient.CompaniesServiceReference.Company[]> GetCompaniesAsync() {
            return base.Channel.GetCompaniesAsync();
        }
        
        public WCFClient.CompaniesServiceReference.Employee[] GetEmployees() {
            return base.Channel.GetEmployees();
        }
        
        public System.Threading.Tasks.Task<WCFClient.CompaniesServiceReference.Employee[]> GetEmployeesAsync() {
            return base.Channel.GetEmployeesAsync();
        }
        
        public WCFClient.CompaniesServiceReference.Company GetCompany(int id) {
            return base.Channel.GetCompany(id);
        }
        
        public System.Threading.Tasks.Task<WCFClient.CompaniesServiceReference.Company> GetCompanyAsync(int id) {
            return base.Channel.GetCompanyAsync(id);
        }
        
        public WCFClient.CompaniesServiceReference.Employee GetEmployee(int id) {
            return base.Channel.GetEmployee(id);
        }
        
        public System.Threading.Tasks.Task<WCFClient.CompaniesServiceReference.Employee> GetEmployeeAsync(int id) {
            return base.Channel.GetEmployeeAsync(id);
        }
        
        public void DeleteCompany(int id) {
            base.Channel.DeleteCompany(id);
        }
        
        public System.Threading.Tasks.Task DeleteCompanyAsync(int id) {
            return base.Channel.DeleteCompanyAsync(id);
        }
        
        public void DeleteEmployee(int id) {
            base.Channel.DeleteEmployee(id);
        }
        
        public System.Threading.Tasks.Task DeleteEmployeeAsync(int id) {
            return base.Channel.DeleteEmployeeAsync(id);
        }
        
        public void AddCompany(WCFClient.CompaniesServiceReference.Company company) {
            base.Channel.AddCompany(company);
        }
        
        public System.Threading.Tasks.Task AddCompanyAsync(WCFClient.CompaniesServiceReference.Company company) {
            return base.Channel.AddCompanyAsync(company);
        }
        
        public void AddEmployee(WCFClient.CompaniesServiceReference.Employee employee) {
            base.Channel.AddEmployee(employee);
        }
        
        public System.Threading.Tasks.Task AddEmployeeAsync(WCFClient.CompaniesServiceReference.Employee employee) {
            return base.Channel.AddEmployeeAsync(employee);
        }
    }
}
