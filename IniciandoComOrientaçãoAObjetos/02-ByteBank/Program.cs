﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.titular = "Gabriela";
            conta.saldo = 200;

            Console.WriteLine(conta.titular);
            Console.WriteLine("Saldo: " + conta.saldo);

            Console.WriteLine("\nFim da execução...");
            Console.ReadLine();
        }
    }
}
