using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class SacrementScheduleController : Controller
    {
        // 
        // GET: /SacrementSchedule/

        public string Index()
        {
            return "This is my default action...";
        }

        // 
        // GET: /SacrementSchedule/Welcome/ 

        public string Welcome(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }
    }
}