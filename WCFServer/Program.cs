using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace WCFServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:8080/companies");

            using (ServiceHost host = new ServiceHost(typeof(CompaniesService), baseAddress))
            {
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                smb.MetadataExporter.PolicyVersion = PolicyVersion.Policy15;
                host.Description.Behaviors.Add(smb);

                host.Open();

                Console.WriteLine("Служба доступна по адресу: {0}", baseAddress);
                Console.WriteLine("Нажмите Enter, чтобы остановить службу");
                Console.ReadLine();

                host.Close();
            }
        }
    }
}
