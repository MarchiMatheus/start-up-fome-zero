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
                new Ingrediente { Nome = NomeIngrediente.Bacon },
                new Ingrediente { Nome = NomeIngrediente.HamburguerCarne },
                new Ingrediente { Nome = NomeIngrediente.Queijo }
            };

            Lanche xBacon = new Lanche();
            xBacon.Ingredientes = listaIngredientes;

            Assert.AreEqual(6.5M, xBacon.Preco);
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
                new Ingrediente { Nome = NomeIngrediente.HamburguerCarne },
                new Ingrediente { Nome = NomeIngrediente.Queijo }
            };

            Lanche xBurguer = new Lanche();
            xBurguer.Ingredientes = listaIngredientes;

            Assert.AreEqual(4.5M, xBurguer.Preco);
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
                new Ingrediente { Nome = NomeIngrediente.Ovo },
                new Ingrediente { Nome = NomeIngrediente.HamburguerCarne },
                new Ingrediente { Nome = NomeIngrediente.Queijo }
            };

            Lanche xEgg = new Lanche();
            xEgg.Ingredientes = listaIngredientes;

            Assert.AreEqual(5.3M, xEgg.Preco);
        }

        #endregion

        #region [ Valida preço do X-Egg Bacon ]

        /// <summary>
        /// Critério de aceite: Valor do lanche X-Egg Bacon deve ser 7,30
        /// </summary>
        [TestMethod]
        public void ValidaValorLancheXEggBacon()
        {
            //Cria lista de ingredientes
            List<Ingrediente> listaIngredientes = new List<Ingrediente>
            {
                new Ingrediente { Nome = NomeIngrediente.Ovo },
                new Ingrediente { Nome = NomeIngrediente.Bacon },
                new Ingrediente { Nome = NomeIngrediente.HamburguerCarne },
                new Ingrediente { Nome = NomeIngrediente.Queijo }
            };

            Lanche xEggBacon = new Lanche();
            xEggBacon.Ingredientes = listaIngredientes;

            Assert.AreEqual(7.3M, xEggBacon.Preco);
        }

        #endregion

        #region [ Valida promoção lanche light ]

        /// <summary>
        /// Critério de aceite: Valor do lanche light deve ser 4,41
        /// </summary>
        [TestMethod]
        public void ValidaPromocaoLancheLight()
        {
            //Cria lista de ingredientes
            List<Ingrediente> listaIngredientes = new List<Ingrediente>
            {
                new Ingrediente { Nome = NomeIngrediente.Alface },
                new Ingrediente { Nome = NomeIngrediente.HamburguerCarne },
                new Ingrediente { Nome = NomeIngrediente.Queijo }
            };

            Lanche xLight = new Lanche();
            xLight.Ingredientes = listaIngredientes;

            Assert.AreEqual(4.41M, xLight.Preco);
        }

        #endregion

        #region [ Valida promoção muita carne ]

        /// <summary>
        /// Critério de aceite: Valor do lanche com muita carne deve ser 7,50
        /// </summary>
        [TestMethod]
        public void ValidaPromocaoMuitaCarne()
        {
            //Cria lista de ingredientes
            List<Ingrediente> listaIngredientes = new List<Ingrediente>
            {
                new Ingrediente { Nome = NomeIngrediente.HamburguerCarne, Quantidade = 3 },
                new Ingrediente { Nome = NomeIngrediente.Queijo, Quantidade = 1 }
            };

            Lanche xMuitaCarne = new Lanche();
            xMuitaCarne.Ingredientes = listaIngredientes;

            Assert.AreEqual(7.503M, xMuitaCarne.Preco);
        }

        #endregion

        #region [ Valida promoção muito queijo ]

        /// <summary>
        /// Critério de aceite: Valor do lanche com muito queijo deve ser 6
        /// </summary>
        [TestMethod]
        public void ValidaPromocaoMuitoQueijo()
        {
            //Cria lista de ingredientes
            List<Ingrediente> listaIngredientes = new List<Ingrediente>
            {
                new Ingrediente { Nome = NomeIngrediente.HamburguerCarne, Quantidade = 1 },
                new Ingrediente { Nome = NomeIngrediente.Queijo, Quantidade = 3 }
            };

            Lanche xMuitoQueijo = new Lanche();
            xMuitoQueijo.Ingredientes = listaIngredientes;

            Assert.AreEqual(6.0015M, xMuitoQueijo.Preco);
        }

        #endregion

        #region [ Valida promoção com descontos acumulativos ]

        /// <summary>
        /// Critério de aceite: Valor do lanche com muito queijo deve ser 11,16
        /// </summary>
        [TestMethod]
        public void ValidaPromocaoComDescontosAcumulativos()
        {
            //Cria lista de ingredientes
            List<Ingrediente> listaIngredientes = new List<Ingrediente>
            {
                new Ingrediente { Nome = NomeIngrediente.Alface, Quantidade = 1 },
                new Ingrediente { Nome = NomeIngrediente.HamburguerCarne, Quantidade = 4 },
                new Ingrediente { Nome = NomeIngrediente.Queijo, Quantidade = 4 }
            };

            Lanche lancheDescontoAcumulativo = new Lanche();
            lancheDescontoAcumulativo.Ingredientes = listaIngredientes;

            Assert.AreEqual(11.1654M, lancheDescontoAcumulativo.Preco);
        }

        #endregion
    }
}
