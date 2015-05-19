using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using WebApplication13.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication13.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var post = new BlogPost
            {
                Id = 123,
                Title = "Hello ASP.NET 5",
                Content = "ASP.NET 5 styrer!",
                DateTimePosted = DateTime.Now
            };

            return View("ShowPost2", post);
        }
    }
}
