using Microsoft.AspNetCore.Mvc;
using ModeloDB;

namespace WebCole.Controllers
{
    public class PagosControllers :Controller
    {
        private readonly ColegioDB db;

        public PagosControllers(ColegioDB db)
        {
            this.db = db;
        }

        // Recupera la lista de materias y envía hacia la vista
        public IActionResult Index()
        {
            IEnumerable<Pagos> listaPagos = db.pagos;

            return View(listaMaterias);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }

    }
}
