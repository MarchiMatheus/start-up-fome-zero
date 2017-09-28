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
                if (VerificaDescontoLancheLight())
                {
                    return Ingredientes.Sum(s => s.ValorAgregado) * ConstantesDesconto.ValorDescontoPadraoLancheLight;
                }

                return Ingredientes.Sum(s => s.ValorAgregado);
            }
        }

        #region [ Métodos ]

        /// <summary>
        /// Verifica se o lanche é light
        /// </summary>
        /// <returns></returns>
        private bool VerificaDescontoLancheLight()
        {
            var aplicaDesconto = false;
            var listaIngredientes = Ingredientes.Select(s => s.Nome).Distinct();

            if (listaIngredientes.Contains(ConstantesIngrediente.Alface) &&
                !listaIngredientes.Contains(ConstantesIngrediente.Bacon))
            {
                aplicaDesconto = true;
            }

            return aplicaDesconto;
        }

        #endregion
    }
}