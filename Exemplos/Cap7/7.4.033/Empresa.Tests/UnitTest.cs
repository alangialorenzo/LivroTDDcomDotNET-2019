using Empresa;
using NUnit.Framework;

namespace Tests
{

    public class CalculadoraDeSalarioTest
    {

        private CalculadoraDeSalario calculadora;

        [SetUp]
        public void Inicializa()
        {
            calculadora = new CalculadoraDeSalario();
        }

        [Test]
        public void DeveCalcularSalarioParaDesenvolvedoresComSalarioAbaixoDoLimite()
        {
            Funcionario desenvolvedor = new Funcionario("Mauricio", 1500.0, Cargo.DESENVOLVEDOR);

            double salario = calculadora.CalculaSalario(desenvolvedor);

            Assert.AreEqual(1500.0 * 0.9, salario);
        }

        [Test]
        public void DeveCalcularSalarioParaDesenvolvedoresComSalarioAcimaDoLimite()
        {
            Funcionario desenvolvedor = new Funcionario("Mauricio", 4000.0, Cargo.DESENVOLVEDOR);

            double salario = calculadora.CalculaSalario(desenvolvedor);

            Assert.AreEqual(4000.0 * 0.8, salario);
        }

        [Test]
        public void DeveCalcularSalarioParaDBAsComSalarioAbaixoDoLimite()
        {
            Funcionario dba = new Funcionario("Mauricio", 500.0, Cargo.DBA);

            double salario = calculadora.CalculaSalario(dba);

            Assert.AreEqual(500.0 * 0.85, salario);
        }

        [Test]
        public void DeveCalcularSalarioParaDBAsComSalarioAcimaDoLimite()
        {
            Funcionario dba = new Funcionario("Mauricio", 3500.0, Cargo.DBA);

            double salario = calculadora.CalculaSalario(dba);

            Assert.AreEqual(3500.0 * 0.75, salario);
        }

        [Test]
        public void DeveCalcularSalarioParaTestadoresComSalarioAbaixoDoLimite()
        {
            Funcionario dba = new Funcionario("Mauricio", 700.0, Cargo.TESTADOR);

            double salario = calculadora.CalculaSalario(dba);

            Assert.AreEqual(700 * 0.85, salario);
        }

        [Test]
        public void DeveCalcularSalarioParaTestadoresComSalarioAcimaDoLimite()
        {
            Funcionario dba = new Funcionario("Mauricio", 3700.0, Cargo.TESTADOR);

            double salario = calculadora.CalculaSalario(dba);

            Assert.AreEqual(3700.0 * 0.75, salario);
        }
    }
}