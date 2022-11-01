using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAtividadeDois.RegrasDeNegocio
{
    class ImparPar
    {
        //Atributos da Classe
        private int valorInicial;
        private int valorFinal;
        private int soma;
        
        //Método Construtor
        public ImparPar(int valorInicial, int valoFinal)
        {
            this.valorInicial = valorInicial;

            this.valorFinal = valoFinal;
        }

        //Método Normal
        public void CalcularImparPar()
        {
            Console.WriteLine("──────────────────────────────");
            Console.Write("Números Pares: ");
            Console.WriteLine();

            for (int Contador0 = valorInicial; Contador0 <= valorFinal; Contador0 = Contador0 + 1)
            {
                if (Contador0 % 2 == 0)
                {
                    Console.Write(Contador0 + ",");
                }
                soma = soma + Contador0;
            }
           
            Console.WriteLine();
            Console.Write("Números Ímpares: ");
            Console.WriteLine();
          
            for (int Contador1 = valorInicial; Contador1 <= valorFinal; Contador1 = Contador1 + 1)
            {
                if (Contador1 % 2 != 0)
                {
                    Console.Write(Contador1 + ",");
                }
            }
        }
        public int GetSoma()
        {
            return soma;
        }
    }
}
