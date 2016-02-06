using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hello.Word.Tests.Client;

namespace Hello.Word.Tests
{
    [TestClass]
    public class UnitTest1
    {
        string myName;
        string resultadoEsperado;
        string resultadoReal;
        HelloWorldClient client = new HelloWorldClient();
        const string mensajeAssert = "El Resultado Esperado = [{0}], pero el Resultado real es [{1}]";
        [TestMethod]
        public void TestSayHelloMyName()
        {
            // Tres partes de las pruebas unitarias.
            //--------------------------------------/////////
            // 1. Preparar el escenario
             myName = "Jorge";
             resultadoEsperado = "Hello world, Jorge";

            // 2. Invoco al metodo correspondiente
            resultadoReal = client.SayHello(myName);


            // 3. Comparacion de resultados, Todos los resultados se van por Assert
            Assert.AreEqual(resultadoEsperado, resultadoReal,
               string.Format(
               mensajeAssert,
               resultadoEsperado.ToString(), resultadoReal.ToString())
               );
            // las [{}] es para saber que viene vacio.
            
        }

        [TestMethod]
        public void TestSayHelloEmptyName()
        {
            // Tres partes de las pruebas unitarias.
            //--------------------------------------/////////
            // 1. Preparar el escenario
            string myName = string.Empty;
            string resultadoEsperado = "Hello world";
            string resultadoReal;
            HelloWorldClient client = new HelloWorldClient();

            // 2. Invoco al metodo correspondiente
            resultadoReal = client.SayHello(myName);


            // 3. Comparacion de resultados, Todos los resultados se van por Assert
            Assert.AreEqual(resultadoEsperado, resultadoReal,
              string.Format(
              mensajeAssert,
              resultadoEsperado.ToString(), resultadoReal.ToString())
              );
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
