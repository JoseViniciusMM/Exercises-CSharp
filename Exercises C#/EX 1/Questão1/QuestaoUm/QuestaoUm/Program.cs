using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestaoUm.RegrasdeNegocio;

namespace QuestaoUm
{
    class Program
    {
        static void Main(string[] args)
        {
            Conversão calculo = new Conversão();
            Console.WriteLine("~~~~~~~~~~~~~~~CONVERSO DE TEMPO~~~~~~~~~~~~~~~");
            
            Console.Write("Informe um Valor em Minutos: ");
            calculo.SetMinutos(Convert.ToInt32(Console.ReadLine()));
            calculo.ConverterMinutos();

            Console.WriteLine("O valor de Minutos em Horas é: " + calculo.GetHoras());
            Console.ReadKey();
      
        }
    }
}
