using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using gestionBancariaApp;

namespace gestionBancariaTest
{
    [TestClass]
    public class gestionBancariaTest
    {

        //MÉTODO INGRESO
        [TestMethod]
        public void validarMetodoIngreso()
        {
            double saldoInicial = 1000;
            double ingreso = 500;
            double saldoActual = 0;
            double saldoEsperado = 1500;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            cuenta.realizarIngreso(ingreso);

            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo no es correcto");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void validarMetodoIngresoNegativo()
        {
            double saldoInicial = 1000;
            double ingreso = -500;
            double saldoActual = 0;
            double saldoEsperado = 1500;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            cuenta.realizarIngreso(ingreso);

            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "Ingreso es negativo");
        }
        [TestMethod]
        public void validarMetodoIngresoNulo()
        {
            double saldoInicial = 1000;
            double ingreso = 0;
            double saldoActual = 0;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            cuenta.realizarIngreso(ingreso);
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoInicial, saldoActual, 0.001, "El valor introducido es nulo");
        }


        //MÉTODO REINTEGRO
        [TestMethod]
        public void validarMetodoReintegro()
        {
            double saldoInicial = 1000;
            double reintegro = 500;
            double saldoActual = 0;
            double saldoEsperado = 500;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            cuenta.realizarReintegro(reintegro);

            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo no es correcto");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void validarMetodoReintegroMayorSaldo()
        {
            double saldoInicial = 1000;
            double reintegro = 1500;
            double saldoActual = 0;
            double saldoEsperado = -500;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            cuenta.realizarReintegro(reintegro);

            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El reintegro es mayor que saldo");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void validarMetodoReintegroNegativoNulo()
        {
            double saldoInicial = 1000;
            double reintegro = -500;
            double saldoActual = 0;
            double saldoEsperado = 500;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            cuenta.realizarReintegro(reintegro);

            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "Reintegro es negativo");
        }
    }
}
