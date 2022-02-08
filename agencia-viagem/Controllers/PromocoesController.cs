using Microsoft.AspNetCore.Mvc;

namespace agencia_viagem.Controllers
{
    public class PromocoesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
