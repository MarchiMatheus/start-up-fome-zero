using FomeZero.Entidades;
using System.Collections.Generic;

namespace FomeZero.Negocio.Entidades.Out
{
    public class ObterCardapioOut
    {
        /// <summary>
        /// Construtor
        /// </summary>
        public ObterCardapioOut()
        {
            this.Cardapio = new List<Lanche>();
        }

        /// <summary>
        /// Lista de lanches
        /// </summary>
        public List<Lanche> Cardapio { get; set; }
    }
}
