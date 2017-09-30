using FomeZero.Entidades;
using FomeZero.Entidades.Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace FomeZero.Testes
{
    [TestClass]
    public class FomeZeroTestes
    {
        #region [ Valida preço do X-Bacon ]

        /// <summary>
        /// Critério de aceite: Valor do lanche X-Bacon deve ser 6,50 sem inflação
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

            Assert.AreEqual(ExecutaCalculo(listaIngredientes), xBacon.Preco);
        }

        #endregion

        #region [ Valida preço do X-Burguer ]

        /// <summary>
        /// Critério de aceite: Valor do lanche X-Burguer deve ser 4,50 sem inflação
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

            Assert.AreEqual(ExecutaCalculo(listaIngredientes), xBurguer.Preco);
        }

        #endregion

        #region [ Valida preço do X-Egg ]

        /// <summary>
        /// Critério de aceite: Valor do lanche X-Egg deve ser 5,30 sem inflação
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

            Assert.AreEqual(ExecutaCalculo(listaIngredientes), xEgg.Preco);
        }

        #endregion

        #region [ Valida preço do X-Egg Bacon ]

        /// <summary>
        /// Critério de aceite: Valor do lanche X-Egg Bacon deve ser 7,30 sem inflação
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

            Assert.AreEqual(ExecutaCalculo(listaIngredientes), xEggBacon.Preco);
        }

        #endregion

        #region [ Valida promoção lanche light ]

        /// <summary>
        /// Critério de aceite: Valor do lanche light deve ser 4,41 sem inflação
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

            Assert.AreEqual(ExecutaCalculo(listaIngredientes), xLight.Preco);
        }

        #endregion

        #region [ Valida promoção muita carne ]

        /// <summary>
        /// Critério de aceite: Valor do lanche com muita carne deve ser 7,50 sem inflação
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

            Assert.AreEqual(ExecutaCalculo(listaIngredientes), xMuitaCarne.Preco);
        }

        #endregion

        #region [ Valida promoção muito queijo ]

        /// <summary>
        /// Critério de aceite: Valor do lanche com muito queijo deve ser 6 sem inflação
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

            Assert.AreEqual(ExecutaCalculo(listaIngredientes), xMuitoQueijo.Preco);
        }

        #endregion

        #region [ Valida promoção com descontos acumulativos ]

        /// <summary>
        /// Critério de aceite: Valor do lanche com muito queijo deve ser 11,16 sem inflação
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

            Assert.AreEqual(ExecutaCalculo(listaIngredientes), lancheDescontoAcumulativo.Preco);
        }

        #endregion

        #region [ Métodos privádos ]        

        #region [ Realiza cálculo do lanche ]        

        /// <summary>
        /// Realiza cálculo do valor do lanche
        /// </summary>
        /// <returns></returns>
        private decimal ExecutaCalculo(List<Ingrediente> listaIngredientes)
        {
            decimal valorTotal = 0.0M;

            #region [ Realiza cálculo dos ingredientes ]            

            foreach (var ingrediente in listaIngredientes)
            {
                var quantidadeComDesconto = (decimal)ingrediente.Quantidade;
                
                if (ingrediente.Nome == NomeIngrediente.HamburguerCarne && ingrediente.Quantidade >= 3)
                {
                    quantidadeComDesconto = (decimal)ingrediente.Quantidade * ConstantesDesconto.ValorDescontoMuitaCarne;
                }
                else if (ingrediente.Nome == NomeIngrediente.Queijo && ingrediente.Quantidade >= 3)
                {
                    quantidadeComDesconto = (decimal)ingrediente.Quantidade * ConstantesDesconto.ValorDescontoMuitoQueijo;
                }

                valorTotal += (ObterValorUnitarioIngrediente(ingrediente.Nome) * quantidadeComDesconto);
            }

            #endregion

            #region [ Verifica desconto de lanche light ]

            var nomeIngredientes = listaIngredientes.Select(s => s.Nome).Distinct();

            if (nomeIngredientes.Contains(NomeIngrediente.Alface) &&
                !nomeIngredientes.Contains(NomeIngrediente.Bacon))
            {
                valorTotal = valorTotal * ConstantesDesconto.ValorDescontoPadraoLancheLight;
            }

            #endregion

            return valorTotal;
        }

        #endregion

        #region [ Obtém valor padrão do ingrediente ]        

        /// <summary>
        /// Obtém o valor padrão do ingrediente para compor o cálculo
        /// </summary>
        /// <returns></returns>
        private decimal ObterValorUnitarioIngrediente(string nomeIngrediente)
        {
            var valoringrediente = 0.0M;

            if (nomeIngrediente.Equals(NomeIngrediente.Alface))
                valoringrediente = ValorIngrediente.Alface;

            if (nomeIngrediente.Equals(NomeIngrediente.Bacon))
                valoringrediente = ValorIngrediente.Bacon;

            if (nomeIngrediente.Equals(NomeIngrediente.HamburguerCarne))
                valoringrediente = ValorIngrediente.HamburguerCarne;

            if (nomeIngrediente.Equals(NomeIngrediente.Ovo))
                valoringrediente = ValorIngrediente.Ovo;

            if (nomeIngrediente.Equals(NomeIngrediente.Queijo))
                valoringrediente = ValorIngrediente.Queijo;

            return valoringrediente;
        }

        #endregion

        #endregion
    }
}
