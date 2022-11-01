using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestaoDois.RegrasdeNegocios;

namespace QuestaoDois
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculoRaiz calculoRaiz = new CalculoRaiz();
            Console.WriteLine("~~~~~~~~~~~~~~~~~CALCULAR RAIZ~~~~~~~~~~~~~~~~~");

            Console.Write("Informe o Radicando: ");
            calculoRaiz.SetRadicando(Convert.ToInt32(Console.ReadLine()));
            calculoRaiz.ConverterRadicando();

            Console.WriteLine("O valor da raiz: " + calculoRaiz.GetValorRaiz());
            Console.ReadKey();

        }
    }
}
