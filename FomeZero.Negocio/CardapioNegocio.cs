using FomeZero.Negocio.Entidades.Out;

namespace FomeZero.Negocio
{
    public class CardapioNegocio
    {
        private LancheNegocio lancheNegocio = new LancheNegocio();

        #region [ Obtém cardápio ]        

        /// <summary>
        /// Obtém cardápio
        /// </summary>
        /// <returns></returns>
        public ObterCardapioOut ObterCardapio()
        {
            ObterCardapioOut obterCardapioOut = new ObterCardapioOut();

            obterCardapioOut.Cardapio.Add(lancheNegocio.ObterXBacon());
            obterCardapioOut.Cardapio.Add(lancheNegocio.ObterXBurguer());
            obterCardapioOut.Cardapio.Add(lancheNegocio.ObterXEgg());
            obterCardapioOut.Cardapio.Add(lancheNegocio.ObterXEggBacon());

            return obterCardapioOut;
        }

        #endregion
    }
}
