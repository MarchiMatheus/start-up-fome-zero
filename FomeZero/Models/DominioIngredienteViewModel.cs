using System.Collections.Generic;

namespace FomeZero.Models
{
    public class DominioIngredienteViewModel
    {
        /// <summary>
        /// Construtor
        /// </summary>
        public DominioIngredienteViewModel()
        {
            this.Ingredientes = new List<IngredienteViewModel>();
        }

        /// <summary>
        /// Ingredientes
        /// </summary>
        public List<IngredienteViewModel> Ingredientes { get; set; }
    }
}