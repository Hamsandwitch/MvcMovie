using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.WebEncoders;
//using Microsoft.AspNetCore.Mvc;
//using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.HtmlEncode($"Hello {name}, numTimes: {numTimes}");
        }
    }
}