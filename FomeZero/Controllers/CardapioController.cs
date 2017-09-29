using FomeZero.Models;
using System.Web.Mvc;

namespace FomeZero.Controllers
{
    public class CardapioController : Controller
    {
        /// <summary>
        /// Index
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            CardapioViewModel cardapio = new CardapioViewModel();

            return View("Cardapio");
        }
    }
}