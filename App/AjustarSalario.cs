namespace Projeto05.App
{
    public class AjustarSalario
    {
        public string NomeFuncionario { get; private set; }
        public double Salario { get; private set; }

        public AjustarSalario(string nomeQueVeio, double salarioQueVeio )
        {
            NomeFuncionario = nomeQueVeio;
            Salario = salarioQueVeio;
        }

        public double novoSalario()
        {
            if ( Salario < 1500)
                return Salario * 1.1;
            return Salario * 1.05;

            //return (Salario < 1500) ? Salario * 1.1 : Salario 1.05;
        }
    }
}
