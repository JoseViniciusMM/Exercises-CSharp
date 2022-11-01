using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestaoTres.RegrasdeNegocios;

namespace QuestaoTres
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculoPerimetroeArea calculo = new CalculoPerimetroeArea();
          
            Console.WriteLine("~~~~~~~~~~Calcular Área e Perímitro~~~~~~~~~~");

            Console.WriteLine();
            Console.Write("Informe o Valor da Base: ");
            calculo.SetValorBase(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine();
            Console.Write("Informe o Valor do Altura: ");
            calculo.SetValorAltura(Convert.ToInt32(Console.ReadLine()));
            calculo.TotalPerimetro();
            calculo.ValorArea();

            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~Resultados~~~~~~~~~~");
            Console.WriteLine();
           
            Console.WriteLine("O valor da Área é.......: " + calculo.GetTotalArea());

            Console.WriteLine("O valor do Perímetro é..: " + calculo.GetTotalPerimetro());
            Console.ReadKey();


        }
    }
}
