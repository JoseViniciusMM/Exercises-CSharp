using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoAtividadeDois.RegrasDeNegocio;

namespace ProjetoAtividadeDois
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorInicial, valorFinal, opcao;
           
            string nome;
            double valorTotalVendas, salarioVendedor;

            string descricaoItem;
            int numeroFaturado, quantidadeItem;
            double precoUnitario;
           
            do
            {
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("/                                                            /");
                Console.WriteLine("/                    ▷Informaçães sobre o algoritmo◁         /");
                Console.WriteLine("/    ➤ Menu                                                  /");
                Console.WriteLine("/                                                            /");
                Console.WriteLine("/                1-§ Para Par e Impar.                       /");
                Console.WriteLine("/                2-§ Para Comissão.                          /");
                Console.WriteLine("/                3-§ Para Fatura.                            /");
                Console.WriteLine("/                4-§ Para Sair.                              /");
                Console.WriteLine("/                                                            /");
                Console.WriteLine("/                                                            /");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

                opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opcao)
                {
                    case 1:
                      
                        Console.WriteLine();
                        Console.WriteLine("----------------Identificador de Impares e pares----------------");
                        Console.WriteLine();

                        Console.WriteLine("─────────────────────────");
                        Console.WriteLine("Informe o Valor Inicial: ");
                        Console.WriteLine("─────────────────────────");
                        valorInicial = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("───────────────────────");
                        Console.WriteLine("Informe o Valor Final: ");
                        Console.WriteLine("───────────────────────");
                        valorFinal = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                      
                        ImparPar numero = new ImparPar(valorInicial, valorFinal);
                        numero.CalcularImparPar();
                        Console.WriteLine();

                        Console.WriteLine("──────────────────────────────");
                        Console.WriteLine("A soma de pares e ímpares é: " + numero.GetSoma());
                        Console.WriteLine("──────────────────────────────");
                        Console.WriteLine();

                        Console.ReadKey();
                      
                        break;

                    case 2:
                     
                        Console.WriteLine("-------Algoritmo que Calcula Comissão e reajusta Sálario-------");
                        Console.WriteLine();

                        Console.WriteLine("─────────────────────────");
                        Console.WriteLine("Informe seu Nome: ");
                        Console.WriteLine("─────────────────────────");
                        nome = Console.ReadLine();

                        Console.WriteLine("──────────────────────────────────");
                        Console.WriteLine("Informe o Valor Total das Vendas: ");
                        Console.WriteLine("──────────────────────────────────");
                        valorTotalVendas = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("──────────────────────────────────");
                        Console.WriteLine("Informe o Sálario do Funcionario: ");
                        Console.WriteLine("──────────────────────────────────");
                        salarioVendedor = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();

                        COMISSAO valor = new COMISSAO(nome, valorTotalVendas, salarioVendedor);
                        valor.CalcularComissao();
                        valor.SomaComissao();
                        Console.WriteLine();

                        Console.WriteLine("──────────────────────────────");
                        Console.WriteLine("O Valor da Comissão é: " + valor.GetCalculoComissao());
                        Console.WriteLine("──────────────────────────────");
                        Console.WriteLine();

                        Console.WriteLine("──────────────────────────────");
                        Console.WriteLine("O Sário Reajustado é: " + valor.GetSomaComissao());
                        Console.WriteLine("──────────────────────────────");
                        Console.WriteLine();
                      
                        Console.ReadKey();

                        break;

                    case 3:

                        Console.WriteLine("------- Algortmo de uma Loja de Suprimentos-------");
                        Console.WriteLine();

                        Console.WriteLine("──────────────────────────────────");
                        Console.WriteLine("Informe o Número do Item Faturado: ");
                        Console.WriteLine("──────────────────────────────────");
                        numeroFaturado = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("───────────────────────────────");
                        Console.WriteLine("Informe a Descrição do Item: ");
                        Console.WriteLine("───────────────────────────────");
                        descricaoItem = Console.ReadLine();
                       
                        Console.WriteLine("──────────────────────────────────────");
                        Console.WriteLine("Informe a Quantidade Comprada do Item: ");
                        Console.WriteLine("──────────────────────────────────────");
                        quantidadeItem = Convert.ToInt32(Console.ReadLine());
                       
                        Console.WriteLine("──────────────────────────────────");
                        Console.WriteLine("Informe o Preço Unitário do Item: ");
                        Console.WriteLine("──────────────────────────────────");
                        precoUnitario = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();

                        FATURA quantia = new FATURA(descricaoItem, numeroFaturado, quantidadeItem, precoUnitario);
                        quantia.NumeroZero();
                        quantia.NumeroZeroZero();
                        quantia.CalculoFatura();
                        Console.WriteLine();

                        Console.WriteLine("──────────────────────────────");
                        Console.WriteLine("Número do Item: " + quantia.GetNumeroFaturado());
                        Console.WriteLine("──────────────────────────────");
                        Console.WriteLine();

                        Console.WriteLine("──────────────────────────────");
                        Console.WriteLine("Descrição do Item: " + quantia.GetDescricaoItem());
                        Console.WriteLine("──────────────────────────────");
                        Console.WriteLine();

                        Console.WriteLine("──────────────────────────────");
                        Console.WriteLine("Quantidade Comprada do Item: " + quantia.GetQuantidadeItem());
                        Console.WriteLine("──────────────────────────────");
                        Console.WriteLine();

                        Console.WriteLine("──────────────────────────────");
                        Console.WriteLine("Preço Unitário do Item: " + quantia.GetPrecoUnitario());
                        Console.WriteLine("──────────────────────────────");
                        Console.WriteLine();

                        Console.WriteLine("──────────────────────────────");
                        Console.WriteLine("Valor da Fatura : " + quantia.GetCalculoFatura());
                        Console.WriteLine("──────────────────────────────");
                        Console.WriteLine();
                        Console.Clear();

                        Console.ReadKey();
                       
                        break;
                }
            } while (opcao > 0 && opcao < 4 );
        }
    }
}
