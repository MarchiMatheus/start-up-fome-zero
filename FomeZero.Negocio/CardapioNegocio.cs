﻿using FomeZero.Entidades;
using FomeZero.Entidades.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace FomeZero.Negocio
{
    public class CardapioNegocio
    {
        #region [ Obtém cardápio ]        

        /// <summary>
        /// Obtém cardápio
        /// </summary>
        /// <returns></returns>
        public List<Lanche> ObterCardapio()
        {
            List<Lanche> cardapio = new List<Lanche>();

            cardapio.Add(ObterXBacon());
            cardapio.Add(ObterXBurguer());
            cardapio.Add(ObterXEgg());
            cardapio.Add(ObterXEggBacon());

            return cardapio;
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
