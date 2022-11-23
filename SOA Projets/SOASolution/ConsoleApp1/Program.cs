using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    public class Program
    {
        

        static void Main(string[] args)
        {
            /* CalculatorService.CalculatorSoapClient Client
                 = new CalculatorService.CalculatorSoapClient();

             var resultat = Client.Multiply(10, 2);*/

            WheatherService.WeatherSoapClient client 
                = new WheatherService.WeatherSoapClient();
           string meteoresult =  client.GetWeather("Meaux", "48.9562° N", "2.8885° E");
        }
    }
}
