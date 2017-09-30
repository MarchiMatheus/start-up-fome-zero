using System.Collections.Generic;

namespace FomeZero.Models
{
    public class LancheViewModel
    {
        /// <summary>
        /// Construtor
        /// </summary>
        public LancheViewModel()
        {
            this.Nome = null;
            this.Ingredientes = new List<string>();
            this.Preco = null;
        }

        /// <summary>
        /// Nome do lanche
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Ingredientes
        /// </summary>
        public List<string> Ingredientes { get; set; }

        /// <summary>
        /// Valor do lanche
        /// </summary>
        public string Preco { get; set; }
    }
}