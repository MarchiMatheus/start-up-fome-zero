using FomeZero.Entidades;

namespace FomeZero.Negocio.Entidades.Out
{
    public class MontarLanchePersonalizadoOut
    {
        /// <summary>
        /// Construtor
        /// </summary>
        public MontarLanchePersonalizadoOut()
        {
            this.Lanche = new Lanche();
        }

        /// <summary>
        /// Lanche personalizado
        /// </summary>
        public Lanche Lanche { get; set; }
    }
}
