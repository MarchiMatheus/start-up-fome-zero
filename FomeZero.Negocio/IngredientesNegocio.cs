using FomeZero.Entidades;
using FomeZero.Entidades.Dominio;
using System.Collections.Generic;

namespace FomeZero.Negocio
{
    public class IngredientesNegocio
    {
        #region [ Obtém o domínio de ingredientes ]

        /// <summary>
        /// Obtém o domínio de ingredientes
        /// </summary>
        /// <returns></returns>
        public List<Ingrediente> ObterDominioIngredientes()
        {
            List<Ingrediente> dominioIngredientes = new List<Ingrediente>();

            dominioIngredientes.Add(new Ingrediente { Nome = NomeIngrediente.Alface });
            dominioIngredientes.Add(new Ingrediente { Nome = NomeIngrediente.Bacon });
            dominioIngredientes.Add(new Ingrediente { Nome = NomeIngrediente.HamburguerCarne });
            dominioIngredientes.Add(new Ingrediente { Nome = NomeIngrediente.Ovo });
            dominioIngredientes.Add(new Ingrediente { Nome = NomeIngrediente.Queijo });

            return dominioIngredientes;
        }

        #endregion
    }
}
