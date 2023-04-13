using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double d;
            double r;
            double cd;

            Console.Write("Qual a cotação do Dólar atualmente: ");
            cd=double.Parse(Console.ReadLine());
            Console.Write("Qual o valor em Dólar que deseja converter para Reais: ");
            d=double.Parse(Console.ReadLine());

            r = d * cd;
            Console.WriteLine("O valor em Dólar {0}U$ convertido em Reais é R${1}",d,r);
        }
    }
}
