using AutoMapper;
using FomeZero.Entidades;
using FomeZero.Models;
using FomeZero.Negocio;
using FomeZero.Negocio.Entidades.In;
using FomeZero.Negocio.Entidades.Out;
using System.Web.Mvc;

namespace FomeZero.Controllers
{
    public class LanchePersonalizadoController : Controller
    {
        private LanchePersonalizadoNegocio lanchepersonalizadoNegocio = new LanchePersonalizadoNegocio();

        /// <summary>
        /// Index
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            MontarLanchePersonalizadoViewModel montarLanchePersonalizadoVM = new MontarLanchePersonalizadoViewModel();
            return View(montarLanchePersonalizadoVM);
        }

        /// <summary>
        /// Monta o lanche personalizado
        /// </summary>
        /// <param name="montarLanchePersonalizadoViewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult MontarLanchePersolanizado(MontarLanchePersonalizadoViewModel montarLanchePersonalizadoViewModel)
        {
            //Monta o lanche personalizado
            MontarLanchePersonalizadoIn montarLanchePersonalizadoIn = Mapper.Map<MontarLanchePersonalizadoViewModel, MontarLanchePersonalizadoIn>(montarLanchePersonalizadoViewModel);
            MontarLanchePersonalizadoOut montarLanchePersonalizadoOut = lanchepersonalizadoNegocio.MontarLanchePersonalizado(montarLanchePersonalizadoIn);

            LanchePersonalizadoViewModel lanchePersonalizadoViewModel = new LanchePersonalizadoViewModel();
            lanchePersonalizadoViewModel.Lanche = Mapper.Map<Lanche, LancheViewModel>(montarLanchePersonalizadoOut.Lanche);

             return View("LancheDetalhe", lanchePersonalizadoViewModel);
        }
    }
}