using Domain.Interfaces;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IClientService _service;
        public HomeController(IClientService service)
        {
            _service = service;
        }

        public ActionResult Index()
        {
            var model = _service.Get();
            return View(model);
        }
    }
}