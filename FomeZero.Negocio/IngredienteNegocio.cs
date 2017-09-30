using FomeZero.Entidades;
using FomeZero.Entidades.Dominio;
using FomeZero.Negocio.Entidades.Out;

namespace FomeZero.Negocio
{
    public class IngredienteNegocio
    {
        /// <summary>
        /// Obtém o domínio de ingredientes
        /// </summary>
        /// <returns></returns>
        public ObterDominioIngredienteOut ObterDominioIngrediente()
        {
            ObterDominioIngredienteOut obterDominioIngredienteOut = new ObterDominioIngredienteOut();

            obterDominioIngredienteOut.Ingredientes.Add(new Ingrediente { Nome = NomeIngrediente.Alface });
            obterDominioIngredienteOut.Ingredientes.Add(new Ingrediente { Nome = NomeIngrediente.Bacon });
            obterDominioIngredienteOut.Ingredientes.Add(new Ingrediente { Nome = NomeIngrediente.HamburguerCarne });
            obterDominioIngredienteOut.Ingredientes.Add(new Ingrediente { Nome = NomeIngrediente.Ovo });
            obterDominioIngredienteOut.Ingredientes.Add(new Ingrediente { Nome = NomeIngrediente.Queijo });

            return obterDominioIngredienteOut;
        }
    }
}
