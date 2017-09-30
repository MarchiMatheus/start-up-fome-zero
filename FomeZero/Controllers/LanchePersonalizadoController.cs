using FomeZero.Models;
using FomeZero.Negocio;
using System.Linq;
using System.Web.Mvc;

namespace FomeZero.Controllers
{
    public class LanchePersonalizadoController : Controller
    {
        IngredientesNegocio ingredienteNegocio = new IngredientesNegocio();

        /// <summary>
        /// Index
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            MontarLanchePersonalizadoViewModel montarLanchePersonalizadoVM = new MontarLanchePersonalizadoViewModel();

            var ingredientes = ingredienteNegocio.ObterDominioIngredientes();

            montarLanchePersonalizadoVM.Ingredientes = ingredientes.Select(s => s.Nome).ToList();
            
            return View(montarLanchePersonalizadoVM);
        }
    }
}