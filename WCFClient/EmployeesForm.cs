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
    public partial class EmployeesForm : Form
    {
        private const string MESSAGE_CAPTION = "Ошибка";
        private const string SERVER_IS_UNAVAILABLE = "Сервер недоступен";
        private const string NO_SELECTED_INDICES = "Не выбран сотрудник";
        private const string CAPTION_FORMAT = "Сотрудники \"{0}\"";
        private int _companyId;

        public EmployeesForm()
        {
            InitializeComponent();
        }

        public EmployeesForm(int companyId, string companyName) 
            : this()
        {
            _companyId = companyId;
            this.Text = string.Format(CAPTION_FORMAT, companyName);
            refreshListViewEmployees();
        }

        private void refreshListViewEmployees()
        {
            listViewEmployees.Items.Clear();
            using (CompaniesServiceClient client = new CompaniesServiceClient())
                try
                {
                    foreach (var employee in client.GetEmployees())
                        if (employee.CompanyId == _companyId)
                        {
                            string[] item = new string[] 
                            {
                                employee.FirstName, employee.LastName, 
                                employee.BirthDate.ToShortDateString(), employee.Position, 
                                employee.EmploymentDate.ToShortDateString(), employee.Id.ToString()
                            };

                            ListViewItem listViewItem = new ListViewItem(item);
                            listViewEmployees.Items.Add(listViewItem);
                        }         

                }
                catch (EndpointNotFoundException ex)
                {
                    MessageBox.Show(SERVER_IS_UNAVAILABLE, MESSAGE_CAPTION);
                }
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            var addEmployeeForm = new AddEmployeeForm(_companyId);
            addEmployeeForm.ShowDialog();
            refreshListViewEmployees();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (CompaniesServiceClient client = new CompaniesServiceClient())
                try
                {
                    client.DeleteEmployee(int.Parse(listViewEmployees.Items[listViewEmployees.SelectedIndices[0]].SubItems[5].Text));
                    refreshListViewEmployees();
                }
                catch (EndpointNotFoundException ex)
                {
                    MessageBox.Show(SERVER_IS_UNAVAILABLE, MESSAGE_CAPTION);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show(NO_SELECTED_INDICES, MESSAGE_CAPTION);
                }
        }
    }
}
