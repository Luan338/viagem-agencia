using Microsoft.AspNetCore.Mvc;


namespace agencia_viagem.Controllers
{
    public class DestinosController : Controller
    {
        private object dbcontext;

        public IActionResult Index()
        {
            var dbcontext = new Contexto();
            var usuario = new Usuario();

            usuario.Nome = "Luan";

            dbcontext.Add(usuario);
            dbcontext.SaveChanges();

            ViewData["clientes"] = dbcontext.Clientes.Where(p => p.id > 0).ToList();
            return View();
        }
    }
}
