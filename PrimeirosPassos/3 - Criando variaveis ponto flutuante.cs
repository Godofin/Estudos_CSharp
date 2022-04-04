using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisPontoFlutuante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto Numero 3 - Criando variaveis ponto flutuante");

            double salario;
            salario = 1200.70;

            double idade;
            idade = 15.0 / 2;
            Console.WriteLine(idade);
            
            idade = 5 / 3;
            Console.WriteLine("5 / 3 = " + idade);

            idade = 5.0 / 3;
            Console.WriteLine("5.0 / 3 = " + idade);

            Console.WriteLine(salario);
            Console.WriteLine(idade);
            Console.WriteLine("Execução Finalizada... Tecle Enter para sair");
            Console.ReadLine();
        }
    }
}
