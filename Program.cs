using Projeto05.App;
using System;

namespace Projeto05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AjustarSalario pessoa1 = new AjustarSalario("Douglas", 1400);

            AjustarSalario pessoa2 = new AjustarSalario("Andréa", 1600);
            double novoSalario1 = pessoa1.novoSalario();
            double novoSalario2 = pessoa2.novoSalario();

            Console.WriteLine(pessoa1.NomeFuncionario + " R$ " + novoSalario1);

            Console.WriteLine(pessoa2.NomeFuncionario + " R$ " + novoSalario2);
          
        }
    }
}
