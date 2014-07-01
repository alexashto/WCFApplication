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
    public partial class MainForm : Form
    {
        private const string NO_SELECTED_INDICES = "Не выбрана компания";
        private const string SERVER_IS_UNAVAILABLE = "Сервер недоступен";

        public MainForm()
        {
            InitializeComponent();
            refreshListViewCompanies();
        }

        private void buttonRefreshCompanies_Click(object sender, EventArgs e)
        {
            refreshListViewCompanies();
        }

        private void buttonWatchEmployee_Click(object sender, EventArgs e)
        {

            if (listViewCompanies.SelectedIndices.Count == 0)
            {
                toolStripStatusLabel.Text = NO_SELECTED_INDICES;
                return;
            }

            toolStripStatusLabel.Text = string.Empty;

            List<Employee> employees = new List<Employee>();
            ListViewItem selectedCompany = listViewCompanies.Items[listViewCompanies.SelectedIndices[0]];
            int companyId = int.Parse(selectedCompany.SubItems[3].Text);

            var employeeForm = new EmployeesForm(companyId, selectedCompany.SubItems[0].Text);
            employeeForm.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAddCompany_Click(object sender, EventArgs e)
        {
            var addCompanyForm = new AddCompanyForm();
            addCompanyForm.ShowDialog();
            refreshListViewCompanies();
        }

        private void refreshListViewCompanies()
        {
            listViewCompanies.Items.Clear();
            using (CompaniesServiceClient client = new CompaniesServiceClient())
            {
                try
                {
                    foreach (var company in client.GetCompanies())
                    {
                        string[] item = new string[] { company.Name, company.Address, company.Phone, company.Id.ToString() };
                        listViewCompanies.Items.Add(new ListViewItem(item));
                    }
                }
                catch (EndpointNotFoundException ex)
                {
                    toolStripStatusLabel.Text = SERVER_IS_UNAVAILABLE;
                }
            }
        }

        private void buttonDeleteCompany_Click(object sender, EventArgs e)
        {
            using (CompaniesServiceClient client = new CompaniesServiceClient())          
                try
                {
                    client.DeleteCompany(int.Parse(listViewCompanies.Items[listViewCompanies.SelectedIndices[0]].SubItems[3].Text));
                    refreshListViewCompanies();
                }
                catch (EndpointNotFoundException ex)
                {
                    toolStripStatusLabel.Text = SERVER_IS_UNAVAILABLE;
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    toolStripStatusLabel.Text = NO_SELECTED_INDICES;
                }          
        }

    }
}
