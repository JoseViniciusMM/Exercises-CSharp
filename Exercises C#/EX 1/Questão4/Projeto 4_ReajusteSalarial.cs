using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoReajusteSalarial.RegrasdeNegocio;

namespace QuestaoQuatro
{
        class Program
        {
            static void Main(string[] args)
            {
                Reajuste calculo = new Reajuste();
           
                Console.WriteLine("~~~~~~~~~~Reajuste Salarial~~~~~~~~~~");
                Console.WriteLine();
                
                Console.Write("Informe seu Nome: ");
                calculo.SetNome(Console.ReadLine());
                Console.WriteLine();
                
                Console.Write("Informe o Valor do Salário: ");
                calculo.SetSalarioAtual(Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine();
                
                Console.Write("Informe o Valor do Reajuste Percentual: ");
                calculo.SetPercentual(Convert.ToDouble(Console.ReadLine()));
                
                calculo.SalarioReajustado();

                Console.WriteLine("~~~~~~~~~~~~~~Resultados~~~~~~~~~~~~~");
                Console.WriteLine();

                Console.WriteLine("Nome......................: " + calculo.GetRetornoNome());
                Console.WriteLine("Salário Reajustado........: " + calculo.GetSalarioReajustado());
                Console.ReadKey();
            }
        }
}