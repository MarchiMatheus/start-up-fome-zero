using System.Collections.Generic;

namespace FomeZero.Models
{
    public class MontarLanchePersonalizadoViewModel
    {
        /// <summary>
        /// Construtor
        /// </summary>
        public MontarLanchePersonalizadoViewModel()
        {
            this.Ingredientes = new List<string>();
        }

        /// <summary>
        /// Lista de ingredientes
        /// </summary>
        public List<string> Ingredientes { get; set; }
    }
}