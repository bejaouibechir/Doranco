using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFramework.Controllers
{
    public class TestController : Controller
    {
        int _port;
        string _connection;
        public TestController()
        {
            _port = int.Parse(ConfigurationManager.AppSettings["port"].ToString());
            _connection = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        }
        
        public ActionResult Page()
        {
            //utilisation de port ici _port
            //utilisation de la connection dans notre code
            return View();
        }
    }
}