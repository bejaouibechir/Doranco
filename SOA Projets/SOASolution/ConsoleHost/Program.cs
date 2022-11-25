using ProducServiceWCF;
using System;
using System.Diagnostics;
using System.ServiceModel;
using static System.Net.WebRequestMethods;


namespace ConsoleHost
{
    //net.tcp://locahost:8801/ProductService
    //http://localhost:8733/Design_Time_Addresses/ProducServiceWCF/Service1/
    internal class Program
    {
        static ServiceHost _host;

        static void Main(string[] args)
        {
            try
            {
                string baseaddress = "http://localhost:8802/";
                using (_host = new ServiceHost(typeof(ProductService), new Uri(baseaddress)))
                {
                    _host.Open();
                }
                foreach (var address in _host.BaseAddresses)
                {
                    Console.WriteLine(address);
                }
                Console.Read();
            }
            catch (Exception erreur)
            {
                Debug.WriteLine(erreur.Message);
                _host.Close();

            }
        }
    }
}
