using FomeZero.Dicionario.Label.LanchePersonalizado;
using System.ComponentModel.DataAnnotations;

namespace FomeZero.Models
{
    public class MontarLanchePersonalizadoViewModel
    {
        /// <summary>
        /// Construtor
        /// </summary>
        public MontarLanchePersonalizadoViewModel()
        {
            this.Alface = null;
            this.Bacon = null;
            this.HamburguerCarne = null;
            this.Ovo = null;
            this.Queijo = null;
        }

        /// <summary>
        /// Alface
        /// </summary>
        [Display(Name = LanchePersonalizadoLabel.Alface)]
        public int? Alface { get; set; }

        /// <summary>
        /// Bacon
        /// </summary>
        [Display(Name = LanchePersonalizadoLabel.Bacon)]
        public int? Bacon { get; set; }

        /// <summary>
        /// Hambúrguer de carne
        /// </summary>
        [Display(Name = LanchePersonalizadoLabel.HamburguerCarne)]
        public int? HamburguerCarne { get; set; }

        /// <summary>
        /// Ovo
        /// </summary>
        [Display(Name = LanchePersonalizadoLabel.Ovo)]
        public int? Ovo { get; set; }

        /// <summary>
        /// Queijo
        /// </summary>
        [Display(Name = LanchePersonalizadoLabel.Queijo)]
        public int? Queijo { get; set; }
    }
}