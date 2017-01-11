using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

         public IActionResult Docker()
        {
            
            ViewData["MachineName"] = Environment.MachineName;
            ViewData["OSArchitecture"] = RuntimeInformation.OSArchitecture;
            ViewData["OSDescription"] = RuntimeInformation.OSDescription;
            ViewData["FrameworkDescription"] = RuntimeInformation.FrameworkDescription;

            var environmentVariables = new StringBuilder();
            foreach( DictionaryEntry environmentVariable in Environment.GetEnvironmentVariables()){
                environmentVariables.AppendFormat("{0} : {1}" + Environment.NewLine, environmentVariable.Key, environmentVariable.Value);
            }

           ViewData["EnvironmentVariables"] = environmentVariables.ToString();

            return View();
        }


        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
