using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiceASMX
{
    /// <summary>
    /// Summary description for CalculService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CalculService : System.Web.Services.WebService
    {

        [WebMethod]
        public double Add(int a, int b)
        {
            return a + b;
        }
        [WebMethod]
        public double Substract(int a, int b)
        {
            return a - b;
        }
        [WebMethod]
        public double Multiply(int a, int b)
        {
            return a * b;
        }
        [WebMethod]
        public double Divide(int a, int b)
        {
            if (b == 0) return 0;
            else
            {
                return a / b;
            }

        }
    }
}
