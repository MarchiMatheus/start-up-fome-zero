using FomeZero.Entidades;
using FomeZero.Entidades.Dominio;
using FomeZero.Negocio.Entidades.In;
using FomeZero.Negocio.Entidades.Out;

namespace FomeZero.Negocio
{
    public class LanchePersonalizadoNegocio
    {
        /// <summary>
        /// Monta o lanche personalizado
        /// </summary>
        /// <param name="montarLanchePersonalizadoIn"></param>
        /// <returns></returns>
        public MontarLanchePersonalizadoOut MontarLanchePersonalizado(MontarLanchePersonalizadoIn montarLanchePersonalizadoIn)
        {
            MontarLanchePersonalizadoOut montarLanchePersonalizadoOut = new MontarLanchePersonalizadoOut();

            #region [ Monta lanche ]

            Lanche lanchePersonalizado = new Lanche();
            lanchePersonalizado.Nome = "Lanche personalizado";

            if (montarLanchePersonalizadoIn.QuantidadeAlface > 0)
                lanchePersonalizado.Ingredientes.Add(new Ingrediente { Nome = NomeIngrediente.Alface, Quantidade = montarLanchePersonalizadoIn.QuantidadeAlface });

            if (montarLanchePersonalizadoIn.QuantidadeBacon > 0)
                lanchePersonalizado.Ingredientes.Add(new Ingrediente { Nome = NomeIngrediente.Bacon, Quantidade = montarLanchePersonalizadoIn.QuantidadeBacon });

            if (montarLanchePersonalizadoIn.QuantidadeHamburguerCarne > 0)
                lanchePersonalizado.Ingredientes.Add(new Ingrediente { Nome = NomeIngrediente.HamburguerCarne, Quantidade = montarLanchePersonalizadoIn.QuantidadeHamburguerCarne });

            if (montarLanchePersonalizadoIn.QuantidadeOvo > 0)
                lanchePersonalizado.Ingredientes.Add(new Ingrediente { Nome = NomeIngrediente.Ovo, Quantidade = montarLanchePersonalizadoIn.QuantidadeOvo });

            if (montarLanchePersonalizadoIn.QuantidadeQueijo > 0)
                lanchePersonalizado.Ingredientes.Add(new Ingrediente { Nome = NomeIngrediente.Queijo, Quantidade = montarLanchePersonalizadoIn.QuantidadeQueijo });

            #endregion

            montarLanchePersonalizadoOut.Lanche = lanchePersonalizado;
            return montarLanchePersonalizadoOut;
        }
    }
}
