using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace SaramentMeetingPlanner.Controllers
{
    public class PlannerController : Controller
    {
        // 
        // GET: /Planner/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /Planner/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        public string Welcome(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }
    }
}