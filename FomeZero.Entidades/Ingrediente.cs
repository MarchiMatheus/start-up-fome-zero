using FomeZero.Entidades.Dominio;

namespace FomeZero.Entidades
{
    public class Ingrediente
    {
        /// <summary>
        /// Construtor
        /// </summary>
        public Ingrediente()
        {
            if (!Quantidade.HasValue)
                Quantidade = 1;
        }

        /// <summary>
        /// Nome do ingrediente
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Valor do ingrediente
        /// </summary>
        private decimal ValorUnitario
        {
            get
            {
                switch (Nome)
                {
                    case NomeIngrediente.Alface:
                        return ValorIngrediente.Alface;
                        break;

                    case NomeIngrediente.Bacon:
                        return ValorIngrediente.Bacon;
                        break;

                    case NomeIngrediente.HamburguerCarne:
                        return ValorIngrediente.HamburguerCarne;
                        break;

                    case NomeIngrediente.Ovo:
                        return ValorIngrediente.Ovo;
                        break;

                    case NomeIngrediente.Queijo:
                        return ValorIngrediente.Queijo;
                        break;

                    default:
                        return 0.0M;
                        break;
                }
            }
        }

        /// <summary>
        /// Quantidade do ingrediente
        /// </summary>
        public int? Quantidade { get; set; }

        /// <summary>
        /// Obtém valor agregado do ingrediente
        /// </summary>
        public decimal Valor
        {
            get
            {
                var quantidadeComDesconto = (decimal)Quantidade;

                //Aplica o desconto na quantidade do item
                if (Nome == NomeIngrediente.HamburguerCarne && Quantidade >= 3)
                {
                    quantidadeComDesconto = (decimal)Quantidade * ConstantesDesconto.ValorDescontoMuitaCarne;
                }
                else if (Nome == NomeIngrediente.Queijo && Quantidade >= 3)
                {
                    quantidadeComDesconto = (decimal)Quantidade * ConstantesDesconto.ValorDescontoMuitoQueijo;
                }

                return ValorUnitario * quantidadeComDesconto;
            }
        }
    }
}