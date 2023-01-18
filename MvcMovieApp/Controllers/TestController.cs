using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovieApp.Controllers
{
    public class TestController : Controller
    {
        public string Index()
        {
            return "Welcome to the test page.";
        }
        public string Test(string input)
        {
            return "This page will print anything you put as the input GET parameter: " + input;
        }
    }
}
