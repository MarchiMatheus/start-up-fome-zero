using FomeZero.Entidades;
using System.Collections.Generic;

namespace FomeZero.Negocio.Entidades.Out
{
    public class ObterDominioIngredienteOut
    {
        /// <summary>
        /// Construtor
        /// </summary>
        public ObterDominioIngredienteOut()
        {
            this.Ingredientes = new List<Ingrediente>();
        }

        /// <summary>
        /// Ingredientes
        /// </summary>
        public List<Ingrediente> Ingredientes { get; set; }
    }
}
