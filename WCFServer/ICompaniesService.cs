using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
using Companies.Domains;

namespace WCFServer
{
    [ServiceContract]
    interface ICompaniesService
    {
        [OperationContract]
        List<Company> GetCompanies();

        [OperationContract]
        List<Employee> GetEmployees();

        [OperationContract]
        Company GetCompany(int id);

        [OperationContract]
        Employee GetEmployee(int id);

        [OperationContract]
        void DeleteCompany(int id);

        [OperationContract]
        void DeleteEmployee(int id);

        [OperationContract]
        void AddCompany(Company company);

        [OperationContract]
        void AddEmployee(Employee employee);


    }
}
