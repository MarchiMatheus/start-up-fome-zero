using FomeZero.Entidades.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace FomeZero.Entidades
{
    public class Lanche
    {
        /// <summary>
        /// Construtor
        /// </summary>
        public Lanche()
        {
            this.Nome = null;
            this.Ingredientes = new List<Ingrediente>();
        }

        /// <summary>
        /// Nome do lanche
        /// </summary>
        public string Nome { get; set; }

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
                if (AplicaDescontoLancheLight)
                {
                    return Ingredientes.Sum(s => s.Valor) * ConstantesDesconto.ValorDescontoPadraoLancheLight;
                }

                return Ingredientes.Sum(s => s.Valor);
            }
        }

        /// <summary>
        /// Indicador de aplicação de desconto para lanches light
        /// </summary>
        private bool AplicaDescontoLancheLight
        {
            get
            {
                var listaIngredientes = Ingredientes.Select(s => s.Nome).Distinct();

                return (listaIngredientes.Contains(NomeIngrediente.Alface) &&
                        !listaIngredientes.Contains(NomeIngrediente.Bacon));
            }
        }
    }
}