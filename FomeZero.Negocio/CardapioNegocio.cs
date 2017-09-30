using FomeZero.Entidades;
using FomeZero.Entidades.Dominio;
using FomeZero.Negocio.Entidades.Out;
using System.Collections.Generic;

namespace FomeZero.Negocio
{
    public class CardapioNegocio
    {
        #region [ Obtém cardápio ]        

        /// <summary>
        /// Obtém cardápio
        /// </summary>
        /// <returns></returns>
        public ObterCardapioOut ObterCardapio()
        {
            ObterCardapioOut obterCardapioOut = new ObterCardapioOut();

            obterCardapioOut.Cardapio.Add(ObterXBacon());
            obterCardapioOut.Cardapio.Add(ObterXBurguer());
            obterCardapioOut.Cardapio.Add(ObterXEgg());
            obterCardapioOut.Cardapio.Add(ObterXEggBacon());

            return obterCardapioOut;
        }

        #endregion

        #region [ Métodos privados ]

        #region [ Obter X-Bacon ]

        /// <summary>
        /// Obtém lanche X-Bacon
        /// </summary>
        /// <returns></returns>
        private Lanche ObterXBacon()
        {
            List<Ingrediente> ingredientes = new List<Ingrediente>
            {
                new Ingrediente { Nome = NomeIngrediente.Bacon },
                new Ingrediente { Nome = NomeIngrediente.HamburguerCarne },
                new Ingrediente { Nome = NomeIngrediente.Queijo }
            };

            return new Lanche
            {
                Nome = NomeLanche.XBacon,
                Ingredientes = ingredientes
            };
        }

        #endregion

        #region [ Obter X-Burguer ]

        /// <summary>
        /// Obtém lanche X-Burguer
        /// </summary>
        /// <returns></returns>
        private Lanche ObterXBurguer()
        {
            List<Ingrediente> ingredientes = new List<Ingrediente>
            {
                new Ingrediente { Nome = NomeIngrediente.HamburguerCarne },
                new Ingrediente { Nome = NomeIngrediente.Queijo }
            };

            return new Lanche
            {
                Nome = NomeLanche.XBurguer,
                Ingredientes = ingredientes
            };
        }

        #endregion

        #region [ Obter X-Egg ]

        /// <summary>
        /// Obtém lanche X-Egg
        /// </summary>
        /// <returns></returns>
        private Lanche ObterXEgg()
        {
            List<Ingrediente> ingredientes = new List<Ingrediente>
            {
                new Ingrediente { Nome = NomeIngrediente.Ovo },
                new Ingrediente { Nome = NomeIngrediente.HamburguerCarne },
                new Ingrediente { Nome = NomeIngrediente.Queijo }
            };

            return new Lanche
            {
                Nome = NomeLanche.XEgg,
                Ingredientes = ingredientes
            };
        }

        #endregion

        #region [ Obter X-Egg Bacon ]

        /// <summary>
        /// Obtém lanche X-Egg Bacon
        /// </summary>
        /// <returns></returns>
        private Lanche ObterXEggBacon()
        {
            List<Ingrediente> ingredientes = new List<Ingrediente>
            {
                new Ingrediente { Nome = NomeIngrediente.Ovo },
                new Ingrediente { Nome = NomeIngrediente.Bacon },
                new Ingrediente { Nome = NomeIngrediente.HamburguerCarne },
                new Ingrediente { Nome = NomeIngrediente.Queijo }
            };

            return new Lanche
            {
                Nome = NomeLanche.XEggBacon,
                Ingredientes = ingredientes
            };
        }

        #endregion

        #endregion
    }
}
