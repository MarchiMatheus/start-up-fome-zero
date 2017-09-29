using System.Collections.Generic;

namespace FomeZero.Models
{
    public class CardapioViewModel
    {
        /// <summary>
        /// Construtor
        /// </summary>
        public CardapioViewModel()
        {
            this.Lanches = new List<LancheViewModel>();
        }

        /// <summary>
        /// Lanches
        /// </summary>
        public List<LancheViewModel> Lanches { get; set; }
    }
}