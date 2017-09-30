using AutoMapper;
using FomeZero.Entidades;
using FomeZero.Models;
using FomeZero.Negocio;
using System.Collections.Generic;
using System.Web.Mvc;

namespace FomeZero.Controllers
{
    public class IngredientesController : Controller
    {
        private IngredienteNegocio ingredienteNegocio = new IngredienteNegocio();

        /// <summary>
        /// Index
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var obterDominioIngredienteOut = ingredienteNegocio.ObterDominioIngrediente();

            DominioIngredienteViewModel dominioIngredienteViewModel = new DominioIngredienteViewModel();
            dominioIngredienteViewModel.Ingredientes = Mapper.Map<List<Ingrediente>, List<IngredienteViewModel>>(obterDominioIngredienteOut.Ingredientes);

            return View(dominioIngredienteViewModel);
        }
    }
}