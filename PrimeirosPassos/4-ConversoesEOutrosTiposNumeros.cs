using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando 4-ConversoesEOutrosTiposNumeros");

            double salario;
            salario = 1200.50;

            int salarioEmInteiro;
            salarioEmInteiro = (int)salario;//Chama Casting

            Console.WriteLine("O salario em double é: " + salario + "O salario em inteiro é: " + salarioEmInteiro);

            long idade;
            idade = 130000000;//Inteiro que suporta 64bits

            Console.WriteLine(idade);

            short quantidadeProdutos;
            quantidadeProdutos = 150;//Ocupa 16bits de memória

            float altura = 1.80f;//Não trás precisão para casas decimais

            Console.WriteLine(altura);
            Console.WriteLine(idade);
            Console.WriteLine(quantidadeProdutos);
            Console.WriteLine("Fim da execução... Tecle enter para sair");
            Console.ReadLine();
        }
    }
}
