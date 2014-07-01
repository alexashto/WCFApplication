using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Companies.Domains;
using Companies.DataAccessors;
//using NLog;
//using Ninject;

namespace Companies
{
    public class CompaniesService
    {
        private IEntityAccessor<Employee> _employeeAccessor;
        private IEntityAccessor<Company> _companyAccessor;

        //private static Logger logger = LogManager.GetCurrentClassLogger();



        public CompaniesService (IEntityAccessor<Employee> employeeAccessor, IEntityAccessor<Company> companyAccessor)
	    {
            _employeeAccessor = employeeAccessor;
            _companyAccessor = companyAccessor;
	    }

        public void AddCompany(Company company)
        {
            _companyAccessor.Insert(company);
        }

        public void AddEmployee(Employee employee)
        {
            _employeeAccessor.Insert(employee);
        }

        public Company GetCompany(int id)
        {
            return _companyAccessor.GetById(id);
        }

        public Employee GetEmployee(int id)
        {
            return _employeeAccessor.GetById(id);
        }

        public Company[] GetCompanies()
        {
            return _companyAccessor.GetAll().ToArray();
        }

        public Employee[] GetEmployees()
        {
            return _employeeAccessor.GetAll().ToArray();
        }

        public void DeleteCompany(int id)
        {
            _companyAccessor.DeleteById(id);
        }

        public void DeleteEmployee(int id)
        {
            _employeeAccessor.DeleteById(id);
        }

    }
}
