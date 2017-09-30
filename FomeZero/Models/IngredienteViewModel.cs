namespace FomeZero.Models
{
    public class IngredienteViewModel
    {
        /// <summary>
        /// Construtor
        /// </summary>
        public IngredienteViewModel()
        {
            this.Nome = null;
            this.Valor = null;
        }

        /// <summary>
        /// Nome do ingrediente
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Valor do ingrediente
        /// </summary>
        public string Valor { get; set; }
    }
}