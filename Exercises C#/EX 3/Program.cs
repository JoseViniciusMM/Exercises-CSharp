using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoAtividadeTres.RegrasDeNegocio;

namespace ProjetoAtividadeTres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("___________________>ALGORITMO MULTIFUÇÕES<____________________");
            Console.WriteLine("____________________________[MENU]____________________________");
            Console.WriteLine("                                                              ");
            Console.WriteLine("                                                              ");
            Console.WriteLine("      Digite 1 Para - Cadrasto ou Votaçao de Candidatos       ");
            Console.WriteLine("      Digite 2 Para - Reajuste Salarial dos Empregados        ");
            Console.WriteLine("      Digite 3 Para - Conversão de Temperatura                ");
            Console.WriteLine("      Digite 4 Para - Sair                                    ");
            Console.WriteLine("                                                              ");
            Console.WriteLine("                                                              ");
            Console.WriteLine("______________________________________________________________");
            int escolha;
            escolha = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
           
            switch (escolha)
            {
                case 1:

                    string nomeCandidato;
                    int numeroCandidato;

                        Console.WriteLine("_______________-Cadrasto do Candidato-_______________");
                        Console.WriteLine();
                       
                        Console.WriteLine("───────────────────────────────");
                        Console.WriteLine("Informe o Nome do Candidato:   ");
                        Console.WriteLine("───────────────────────────────");
                        nomeCandidato = Console.ReadLine();

                        Console.WriteLine("────────────────────────────────");
                        Console.WriteLine("Informe o Numero do Canditato:  ");
                        Console.WriteLine("────────────────────────────────");
                        numeroCandidato = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                      
                        Candidato resultadoCandidato = new Candidato(nomeCandidato, numeroCandidato);

                    do {
                        Console.WriteLine("_______________-Votação no Candidato-_______________");
                        Console.WriteLine();

                        Console.WriteLine("──────────────────────────────────────");
                        Console.WriteLine(nomeCandidato + "//Digite 1 Para votar");
                        Console.WriteLine("──────────────────────────────────────");
                        resultadoCandidato.Votacao();
                       
                        Console.WriteLine("─────────────────────────");
                        Console.WriteLine("A Quantidade Votos:" +resultadoCandidato.GetQuantDeVotos());
                        Console.WriteLine("─────────────────────────");
                        Console.WriteLine();
                      
                        Console.WriteLine("Digite 0 para Sair");
                        numeroCandidato = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                    
                    } while (numeroCandidato != 0);
                   
                    Console.ReadKey();
                    break;

                    case 2:

                    string nomeEmpregado;
                    string funcaoEmpregado;
                    double salarioMensal;
                    double porcertagem;

                    Console.WriteLine("_______________Reajuste Salarial dos Empregados_______________");
                    Console.WriteLine();
                   
                    Console.WriteLine("────────────────────────────");
                    Console.WriteLine("Informe o Nome do Empregado: ");
                    Console.WriteLine("────────────────────────────");
                    nomeEmpregado = Console.ReadLine();
                  
                    Console.WriteLine("───────────────────");
                    Console.WriteLine("Informe a Função:  ");
                    Console.WriteLine("───────────────────");
                    funcaoEmpregado = Console.ReadLine();
                  
                    Console.WriteLine("───────────────────────────");
                    Console.WriteLine("Informe o Salário Mensal:  ");
                    Console.WriteLine("───────────────────────────");
                    salarioMensal = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                   
                    Empregado informacoes = new Empregado(nomeEmpregado, funcaoEmpregado, salarioMensal);

                    Console.WriteLine("_______________Dados dos Empregados_______________");
                    Console.WriteLine("__________________________________________________");
                    Console.WriteLine();

                    Console.WriteLine("─────────────────────────────");
                    Console.WriteLine("Nome:" + nomeEmpregado);
                    Console.WriteLine("─────────────────────────────");
                    Console.WriteLine();

                    Console.WriteLine("─────────────────────────────");
                    Console.WriteLine("Função:" + funcaoEmpregado);
                    Console.WriteLine("─────────────────────────────");
                    Console.WriteLine();
                   
                    Console.WriteLine("───────────────────────────────────────");
                    Console.WriteLine("Informe o Reajuste Salário Mensal (%): ");
                    Console.WriteLine("───────────────────────────────────────");
                    porcertagem = Convert.ToDouble(Console.ReadLine());
                    informacoes.SalarioReajustado( porcertagem);
                   
                    Console.WriteLine("────────────────────────────");
                    Console.WriteLine("Reajuste Salarial (%):" + informacoes.GetSalarioReajustado());
                    Console.WriteLine("────────────────────────────");
                    Console.ReadKey();
                    break;
               
                case 3:
                  
                    double celsius;
                    double farenheit;
                    double kelvin;

                    Console.WriteLine("_____________________________________________________________________");
                    Console.WriteLine("                                                                     ");
                    Console.WriteLine("                        >Tabela de Converção<                        ");
                    Console.WriteLine("     Menu                                                            ");
                    Console.WriteLine("                                                                     ");
                    Console.WriteLine("           Digite 1 Para - Converte Célsius para Farenheit:          ");
                    Console.WriteLine("           Digite 2 Para - Converte Farenheit para Célsius:          ");
                    Console.WriteLine("           Digite 3 Para - Converte Célsius para Kelvin:             ");
                    Console.WriteLine("           Digite 4 Para - Converte Kelvin para Celsius:             ");
                    Console.WriteLine("           Digite 5 Para - Converte Kelvin para Farenheit:           ");
                    Console.WriteLine("           Digite 6 Para - Converte Farenheit para Kelvin:           ");
                    Console.WriteLine("                                                                     ");
                    Console.WriteLine("_____________________________________________________________________");
                    
                    escolha = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    switch (escolha)
                    {
                        case 1:
                           
                            Console.WriteLine("──────────────────────────────────────");
                            Console.WriteLine("Informe a Quantidade de Grau Célsius: ");
                            Console.WriteLine("──────────────────────────────────────");
                            celsius = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("────────────────────────────────────────────");
                            Console.WriteLine("A Converção Célsius para Farenheit:" +Temperatura.ConversaoCelsiusParaFarenheit(celsius));
                            Console.WriteLine("────────────────────────────────────────────");
                            Console.ReadKey();
                           
                            break;
                          

                        case 2:
                           
                            Console.WriteLine("──────────────────────────────────────");
                            Console.WriteLine("Informe a Quantidade de Grau Farenheit:" );
                            Console.WriteLine("──────────────────────────────────────");
                            farenheit = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("────────────────────────────────────────────");
                            Console.WriteLine("A Converção Farenheit para Célsius:" + Temperatura.ConversaoFarenheitParaCelsius(farenheit));
                            Console.WriteLine("────────────────────────────────────────────");
                            Console.ReadKey();
                            break;
                           
                        case 3:
                            
                            Console.WriteLine("──────────────────────────────────────");
                            Console.WriteLine("Informe a Quantidade de Grau Célsius:");
                            Console.WriteLine("──────────────────────────────────────");
                            celsius = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("────────────────────────────────────────────");
                            Console.WriteLine("A Converção Célsius para Kelvin"+ Temperatura.ConversaoCelsiusParaKelvin(celsius));
                            Console.WriteLine("────────────────────────────────────────────");
                            Console.ReadKey();
                            break;

                        case 4:
                           
                            Console.WriteLine("──────────────────────────────────────");
                            Console.WriteLine("Informe a Quantidade de Kelvin: " );
                            Console.WriteLine("──────────────────────────────────────");
                            kelvin = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("────────────────────────────────────────────");
                            Console.WriteLine("A Converção Kelvin para Celsius:"+Temperatura.ConversaoKelvinParaCelsius(kelvin));
                            Console.WriteLine("────────────────────────────────────────────");
                            Console.ReadKey();
                            break;
                       
                        case 5:
                          
                            Console.WriteLine("──────────────────────────────────────");
                            Console.WriteLine("Informe a Quantidade de Kelvin: ");
                            Console.WriteLine("──────────────────────────────────────");
                            kelvin = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("────────────────────────────────────────────");
                            Console.WriteLine("A Converção Kelvin para Farenheit: "+Temperatura.ConversaoKelvinParaFarenheit(kelvin));
                            Console.WriteLine("────────────────────────────────────────────");
                            Console.ReadKey();
                            break;
                       
                        case 6:
                           
                            Console.WriteLine("──────────────────────────────────────");
                            Console.WriteLine("Informe a Quantidade Grau Farenheit: ");
                            Console.WriteLine("──────────────────────────────────────");
                            farenheit = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("────────────────────────────────────────────");
                            Console.WriteLine("A Converção Farenheit para Kelvin: "+Temperatura.ConversaoFarenheitparaKelvin(farenheit));
                            Console.WriteLine("────────────────────────────────────────────");
                            Console.ReadKey();
                            break;
                    }

                    break;
           
            } while (escolha > 0 && escolha < 4) ;
        }
    }
}
