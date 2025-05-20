using Microsoft.AspNetCore.Mvc;

namespace To_do_list.Controllers
{
    public class TasksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        // 
        // GET: /HelloWorld/Welcome/ 
        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}
