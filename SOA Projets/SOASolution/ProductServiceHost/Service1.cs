using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using ProducServiceWCF;

namespace ProductServiceHost
{
    public partial class Service1 : ServiceBase
    {

        ServiceHost _host;
        Uri addresse1 = new Uri("net.tcp://locahost:8801/ProductService");
        Uri addresse2 = new Uri("http://localhost:8733/Design_Time_Addresses/ProducServiceWCF/Service1/");
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            _host = new ServiceHost(typeof(ProductService),addresse1,addresse2);
            try
            {
                _host.Open();
                EventLog.WriteEntry("Application", $"Le service à" +
                    $" démarée a {DateTime.Now.Hour}:{DateTime.Now.Minute}:", EventLogEntryType.Information);
            }
            catch (Exception erreur)
            {
                EventLog.WriteEntry("Application", 
                    $"Tentative de démarrage de ProductSerivce qui à échouée" +
                    $" {DateTime.Now.Hour}:{DateTime.Now.Minute}\n Raison: {erreur.Message}", EventLogEntryType.Error);

                    _host.Close();
            }
           
        }

        protected override void OnStop()
        {
            _host.Close();
            EventLog.WriteEntry("Application", $"Le service" +
                $" à stoppé a {DateTime.Now.Hour}:{DateTime.Now.Minute}:", EventLogEntryType.Information);
        }

        
    }
}
