using System;

namespace Conta
{
    public class Conta
    {
        public string NomeCompleto { get; set; }
        public int CPF { get; set; }
        public int nºagencia { get; set; }
        public int nºconta { get; set; }
        public int ContaPoupança { get; set; }
        public int ContaCorrente { get; set; }

        public double getSaldo()
        {
            return 1;
        }
        public double getSacar()
        {
            return 1;
        }
        public double getTransferência()
        {
            return 1;
        }
        public double getDepósito()
        {
            return 1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu Nome Completo:");
            Console.ReadLine();
            Console.WriteLine("Digite seu CPF:");
            Console.ReadLine();
            Console.WriteLine("Digite nºagencia:");
            Console.ReadLine();
            Console.WriteLine("Digite nºconta:");
            Console.ReadLine();

        }

    }
    }

