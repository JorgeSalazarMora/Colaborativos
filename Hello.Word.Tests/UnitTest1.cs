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
            // preparar el escenario
            string myName = "Jorge";
            string resultadoEsperado = "Hello world, Jorge";
            string resultadoReal;
            HelloWorldClient client = new HelloWorldClient();

            // invoco al metodo correspondiente
            resultadoReal = client.SayHello(myName);


            // comparacion de resultados
            Assert.AreEqual(resultadoEsperado, resultadoReal);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
