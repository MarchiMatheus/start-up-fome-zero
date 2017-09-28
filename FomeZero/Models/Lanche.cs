using System.Collections.Generic;
using System.Linq;

namespace FomeZero.Models
{
    public class Lanche
    {
        /// <summary>
        /// Construtor
        /// </summary>
        public Lanche()
        {
            this.Ingredientes = new List<Ingrediente>();
        }

        /// <summary>
        /// Lista com ingredientes do lanche
        /// </summary>
        public List<Ingrediente> Ingredientes { get; set; }

        /// <summary>
        /// Preço do lanche
        /// </summary>
        public decimal Preco
        {
            get
            {
                return Ingredientes.Sum(s => s.ValorIngrediente);
            }
        }
    }
}