using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hello.Word.Tests.Client;

namespace Hello.Word.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSayHelloMyName()
        {
            // Tres partes de las pruebas unitarias.
            //--------------------------------------/////////
            // 1. Preparar el escenario
            string myName = "Jorge";
            string resultadoEsperado = "Hello world, Jorge";
            string resultadoReal;
            HelloWorldClient client = new HelloWorldClient();

            // 2. Invoco al metodo correspondiente
            resultadoReal = client.SayHello(myName);


            // 3. Comparacion de resultados
            Assert.AreEqual(resultadoEsperado, resultadoReal);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
