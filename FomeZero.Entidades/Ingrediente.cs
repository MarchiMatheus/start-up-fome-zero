using FomeZero.Entidades.Dominio;

namespace FomeZero.Entidades
{
    public class Ingrediente
    {
        /// <summary>
        /// Nome do ingrediente
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Valor do ingrediente
        /// </summary>
        public decimal ValorIngrediente { get; set; }

        /// <summary>
        /// Quantidade do ingrediente
        /// </summary>
        public int Quantidade { get; set; }

        /// <summary>
        /// Obtém valor agregado
        /// </summary>
        public decimal ValorAgregado
        {
            get
            {
                var quantidadeComDesconto = (decimal)Quantidade;

                //Aplica o desconto na quantidade do item
                if (Nome == ConstantesIngrediente.HamburguerCarne && Quantidade > 3)
                {
                    quantidadeComDesconto = (decimal)Quantidade * ConstantesDesconto.ValorDescontoMuitaCarne;
                }
                else if (Nome == ConstantesIngrediente.Queijo && Quantidade > 3)
                {
                    quantidadeComDesconto = (decimal)Quantidade * ConstantesDesconto.ValorDescontoMuitoQueijo;
                }

                return ValorIngrediente * quantidadeComDesconto;
            }
        }
    }
}