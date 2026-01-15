using Microsoft.AspNetCore.Mvc;

namespace CircleApp.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View("Chat");
        }
    }
}
