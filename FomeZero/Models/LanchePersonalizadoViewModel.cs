namespace FomeZero.Models
{
    public class LanchePersonalizadoViewModel
    {
        /// <summary>
        /// Construtor
        /// </summary>
        public LanchePersonalizadoViewModel()
        {
            this.Lanche = new LancheViewModel();
        }

        /// <summary>
        /// Lanche
        /// </summary>
        public LancheViewModel Lanche { get; set; }
    }
}