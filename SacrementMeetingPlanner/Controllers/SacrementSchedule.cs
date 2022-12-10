using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class SacramentScheduleController : Controller
    {
        // 
        // GET: /SacramentSchedule/

        public string Index()
        {
            return "This is my default action...";
        }

        // 
        // GET: /SacramentSchedule/Welcome/ 

        public string Welcome(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }
    }
}