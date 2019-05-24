using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoIntegrado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrado.Tests
{
    [TestClass()]
    public class PedidosTests
    {
        [TestMethod()]
        public void HacerPedidoTest()
        {
            Pedidos pedido = new Pedidos();

            Assert.IsTrue(pedido.HacerPedido());
        }

        [TestMethod()]
        public void EliminarArticuloTest()
        {
            Pedidos pedido = new Pedidos();

            Assert.IsFalse(pedido.EliminarArticulo("Flan"));
        }

        [TestMethod()]
        public void CalcularPrecioTest()
        {
            Pedidos pedido = new Pedidos();
            double precio = pedido.CalcularPrecio();
            Assert.AreEqual(precio, 0);
        }
    }
}