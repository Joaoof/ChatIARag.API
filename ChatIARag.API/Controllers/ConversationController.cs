using Microsoft.AspNetCore.Mvc;

namespace ChatIARag.API.Controllers
{
    public class ConversationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
