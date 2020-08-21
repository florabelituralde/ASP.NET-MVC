using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Asp.netFundamentals.Controllers
{
    public class HomeController1 : Controller
    {
        //Every public method in a controller is a callable HTTP endpoint.
        public string Index()
        {
            return "This is my default action..";
        }

        public string Welcome(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }
        public string SomethingElse()
        {
            return "This is something else!";
        }
    }
}
