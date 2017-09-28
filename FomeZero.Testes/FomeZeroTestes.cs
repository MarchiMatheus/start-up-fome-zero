using FomeZero.Entidades;
using FomeZero.Entidades.Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace FomeZero.Testes
{
    [TestClass]
    public class FomeZeroTestes
    {
        #region [ Valida preço do X-Bacon ]

        /// <summary>
        /// Critério de aceite: Valor do lanche X-Bacon deve ser 6,50
        /// </summary>
        [TestMethod]
        public void ValidaPrecoXBacon()
        {
            //Cria lista de ingredientes
            List<Ingrediente> listaIngredientes = new List<Ingrediente>
            {
                new Ingrediente { Nome = ConstantesIngrediente.Bacon, ValorIngrediente = 2, Quantidade = 1 },
                new Ingrediente { Nome = ConstantesIngrediente.HamburguerCarne, ValorIngrediente = 3, Quantidade = 1 },
                new Ingrediente { Nome = ConstantesIngrediente.Queijo, ValorIngrediente = 1.5M, Quantidade = 1 }
            };

            Lanche XBacon = new Lanche();
            XBacon.Ingredientes = listaIngredientes;

            Assert.AreEqual(6.5M, XBacon.Preco);
        }

        #endregion

        #region [ Valida preço do X-Burguer ]
        
        /// <summary>
        /// Critério de aceite: Valor do lanche X-Burguer deve ser 4,50
        /// </summary>
        [TestMethod]
        public void ValidaValorLancheXBurguer()
        {
            //Cria lista de ingredientes
            List<Ingrediente> listaIngredientes = new List<Ingrediente>
            {                
                new Ingrediente { Nome = ConstantesIngrediente.HamburguerCarne, ValorIngrediente = 3, Quantidade = 1 },
                new Ingrediente { Nome = ConstantesIngrediente.Queijo, ValorIngrediente = 1.5M, Quantidade = 1 }
            };

            Lanche XBurguer = new Lanche();
            XBurguer.Ingredientes = listaIngredientes;

            Assert.AreEqual(4.5M, XBurguer.Preco);
        }

        #endregion

        #region [ Valida preço do X-Egg ]

        /// <summary>
        /// Critério de aceite: Valor do lanche X-Egg deve ser 5,30
        /// </summary>
        [TestMethod]
        public void ValidaValorLancheXEgg()
        {
            //Cria lista de ingredientes
            List<Ingrediente> listaIngredientes = new List<Ingrediente>
            {
                new Ingrediente { Nome = ConstantesIngrediente.Ovo, ValorIngrediente = 0.8M, Quantidade = 1 },
                new Ingrediente { Nome = ConstantesIngrediente.HamburguerCarne, ValorIngrediente = 3, Quantidade = 1 },
                new Ingrediente { Nome = ConstantesIngrediente.Queijo, ValorIngrediente = 1.5M, Quantidade = 1 }
            };

            Lanche XEgg = new Lanche();
            XEgg.Ingredientes = listaIngredientes;

            Assert.AreEqual(5.3M, XEgg.Preco);
        }

        #endregion

        #region [ Valida preço do X-Egg Bacon ]

        /// <summary>
        /// Critério de aceite: Valor do lanche X-Egg Bacon deve ser 7,50
        /// </summary>
        [TestMethod]
        public void ValidaValorLancheXEggBacon()
        {
            //Cria lista de ingredientes
            List<Ingrediente> listaIngredientes = new List<Ingrediente>
            {
                new Ingrediente { Nome = ConstantesIngrediente.Ovo, ValorIngrediente = 0.8M, Quantidade = 1 },
                new Ingrediente { Nome = ConstantesIngrediente.Bacon, ValorIngrediente = 2, Quantidade = 1 },
                new Ingrediente { Nome = ConstantesIngrediente.HamburguerCarne, ValorIngrediente = 3, Quantidade = 1 },
                new Ingrediente { Nome = ConstantesIngrediente.Queijo, ValorIngrediente = 1.5M, Quantidade = 1 }
            };

            Lanche XEggBacon = new Lanche();
            XEggBacon.Ingredientes = listaIngredientes;

            Assert.AreEqual(7.3M, XEggBacon.Preco);
        }

        #endregion
    }
}
