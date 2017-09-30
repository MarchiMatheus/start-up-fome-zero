using AutoMapper;
using FomeZero.Entidades;
using FomeZero.Models;
using FomeZero.Negocio;
using System.Collections.Generic;
using System.Web.Mvc;

namespace FomeZero.Controllers
{
    public class CardapioController : Controller
    {
        private CardapioNegocio cardapioNegocio = new CardapioNegocio();

        /// <summary>
        /// Index
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            CardapioViewModel cardapioVM = new CardapioViewModel();

            var cardapio = cardapioNegocio.ObterCardapio();

            cardapioVM.Lanches = Mapper.Map<List<Lanche>, List<LancheViewModel>>(cardapio);

            return View(cardapioVM);
        }
    }
}