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
    public partial class AddCompanyForm : Form
    {
        public AddCompanyForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var company = new Company() 
            { 
                Name = textBoxCompanyName.Text,
                Address = textBoxCompanyAddress.Text,
                Phone = textBoxCompanyPhone.Text           
            };

            using (CompaniesServiceClient client = new CompaniesServiceClient())  
                try
                {
                    client.AddCompany(company);
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
