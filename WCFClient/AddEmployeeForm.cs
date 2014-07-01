using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCFClient.CompaniesServiceReference;

namespace WCFClient
{
    public partial class AddEmployeeForm : Form
    {
        int _companyId;

        public AddEmployeeForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        public AddEmployeeForm(int companyId)
            : this()
        {
            _companyId = companyId;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var employee = new Employee()
            {
                CompanyId = _companyId,
                FirstName = textBoxFirstName.Text,
                LastName = textBoxLastName.Text,
                BirthDate = BirthDatePicker.Value,
                Position = textBoxPosition.Text,
                EmploymentDate = EmploymentDatePicker.Value
            };

            using (CompaniesServiceClient client = new CompaniesServiceClient())  
                try
                {
                    client.AddEmployee(employee);
                    this.Close();
                }
                catch (EndpointNotFoundException ex)
                {
                    MessageBox.Show("Сервер недоступен", "Ошибка");
                }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
