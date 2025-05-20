using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaMsg;
using BibliotecaValidacoes.Formatações;

namespace AtividadePOOdois
{
    class Program
    {
        static void Main(string[] args)
        {
            int escolha = 0;
            do
            {
                Console.WriteLine("---------------------- Alunos: ------------------------------");
                Console.WriteLine("|> Renan da Rocha Santos                                    |");
                Console.WriteLine("|> José Vinícius Machado Martines                           |");
                Console.WriteLine("-------------------------------------------------------------");
                Console.WriteLine("[-][-][-][-][-][-][-][-]BANCO CENTRAL[-][-][-][-][-][-][-][-]\n");
                Console.WriteLine("Faça seu Cadastro já!!:)\n");

                Console.WriteLine("Selecione [1] Para:[Criar Conta no CitiBank]....");
                Console.WriteLine("Selecione [2] Para:[Criar Conta no ITAU]........");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Selecione [3] Para:[Verificar Conta CitiBank]...");
                Console.WriteLine("Selecione [4] Para:[Verificar Conta ITAU].......");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("[Digite Qualquer número diferente para SAIR]....\n");

                Console.WriteLine("Digite sua Escolha: ");
                escolha = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("[-][-][-][-][-][-][-][-][-][-][-][-][-][-][-][-][-][-][-][-]\n");
                Console.Clear();
                
                Mensagens msg = new Mensagens("POO - 4° Módulo");
   
                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("[-][-][-][-][-][-][-][-]BANCO CENTRAL[-][-][-][-][-][-][-][-]\n");
                        Console.WriteLine("Bem-vindo ao CitiBank\n");
                        Console.WriteLine("-------------------------------------------------------");
                        Console.WriteLine("Selecione [1] Para:[Criar Conta como Pessoa Física]....");
                        Console.WriteLine("Selecione [2] Para:[Criar Conta como Pessoa Jurídica]..");
                        Console.WriteLine("-------------------------------------------------------");
                        Console.WriteLine("Digite sua Escolha: ");
                        escolha = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        switch (escolha)
                        {
                            case 1:
                                Console.WriteLine("[-][-][-][-][-][-][-][-]BANCO CENTRAL[-][-][-][-][-][-][-][-]\n");
                                Console.WriteLine("------------------Cadastro de Pessoa Física------------------");
                                Console.Write("Digite seu CPF:");
                                string cpfCB = Console.ReadLine();
                                Console.Clear();
                                if (Validadores.ValidarCpf(cpfCB))
                                {
                                    msg.MsgInformacao("CPF Válido! Cadastro Realizado com Sucesso!");
                                    msg.MsgInformacao("CitiBank Agradece por Escolher Nosso Banco :)");
                                }
                                else
                                {
                                    msg.MsgErro("Erro de Cadastro! CPF Inválido!");
                                }

                                break;

                            case 2:
                                Console.WriteLine("[-][-][-][-][-][-][-][-]BANCO CENTRAL[-][-][-][-][-][-][-][-]\n");
                                Console.WriteLine("-----------------Cadastro de Pessoa Jurídica-----------------");
                                Console.Write("Digite seu CNPJ:");
                                string cnpjCB = Console.ReadLine();
                                Console.Clear();
                                if (Validadores.ValidarCnpj(cnpjCB))
                                {
                                    msg.MsgInformacao("CNPJ Válido! Cadastro Realizado com Sucesso!");
                                    msg.MsgInformacao("CitiBank Agradece por Escolher Nosso Banco :)");
                                }
                                else
                                {
                                    msg.MsgErro("Erro de Cadastro! CNPJ Inválido!");
                                }

                                break;
                        }
                                                                                                                                                                                       
                        break;
                    
                    case 2:
                        Console.WriteLine("[-][-][-][-][-][-][-][-]BANCO CENTRAL[-][-][-][-][-][-][-][-]\n");
                        Console.WriteLine("Bem-vindo ao Itaú\n");
                        Console.WriteLine("-------------------------------------------------------");
                        Console.WriteLine("Selecione [1] Para:[Criar Conta como Pessoa Física]....");
                        Console.WriteLine("Selecione [2] Para:[Criar Conta como Pessoa Jurídica]..");
                        Console.WriteLine("-------------------------------------------------------");
                        Console.WriteLine("Digite sua Escolha: ");
                        escolha = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        switch (escolha)
                        {
                            case 1:
                                Console.WriteLine("[-][-][-][-][-][-][-][-]BANCO CENTRAL[-][-][-][-][-][-][-][-]\n");
                                Console.WriteLine("------------------Cadastro de Pessoa Física------------------");
                                Console.Write("Digite seu CPF:");
                                string cpfIT = Console.ReadLine();
                                Console.Clear();
                                if (Validadores.ValidarCpf(cpfIT))
                                {
                                    msg.MsgInformacao("CPF Válido! Cadastro Realizado com Sucesso!");
                                    msg.MsgInformacao("Itaú Agradece por Escolher Nosso Banco :)");
                                }
                                else
                                {
                                    msg.MsgErro("Erro de Cadastro! CPF Inválido!");
                                }

                                break;

                            case 2:
                                Console.WriteLine("[-][-][-][-][-][-][-][-]BANCO CENTRAL[-][-][-][-][-][-][-][-]\n");
                                Console.WriteLine("-----------------Cadastro de Pessoa Jurídica-----------------");
                                Console.Write("Digite seu CNPJ:");
                                string cnpjIT = Console.ReadLine();
                                Console.Clear();
                                if (Validadores.ValidarCnpj(cnpjIT))
                                {
                                    msg.MsgInformacao("CNPJ Válido! Cadastro Realizado com Sucesso!");
                                    msg.MsgInformacao("Itaú Agradece por Escolher Nosso Banco :)");
                                }
                                else
                                {
                                    msg.MsgErro("Erro de Cadastro! CNPJ Inválido!");
                                }

                                break;
                        }

                        break;
                    
                    case 3:
                        Console.WriteLine("[-][-][-][-][-][-][-][-]BANCO CENTRAL[-][-][-][-][-][-][-][-]\n");
                        Console.WriteLine("Vamos Verificar sua Conta do CitiBank :)\n");
                        Console.WriteLine("[Informe a ~Agência~ e o ~N° da Conta~\n");

                        Console.WriteLine("Digite o Número da sua Agência:");
                        string agenCB = Console.ReadLine();
                        Console.WriteLine();

                        Console.WriteLine("Digite o Número da sua Conta:");
                        string numeroContCB = Console.ReadLine();
                        Console.Clear();

                        bool verificacaoCit = Validadores.ValidarCitiBank(agenCB, numeroContCB);                     

                        if (verificacaoCit)
                            msg.MsgInformacao("Conta Verificada Com Sucesso!");
                        else
                        {
                            msg.MsgInformacao("Tente Novamanete Mais Tarde :)");
                        }

                        break;
                    
                    case 4:
                        Console.WriteLine("[-][-][-][-][-][-][-][-]BANCO CENTRAL[-][-][-][-][-][-][-][-]\n");
                        Console.WriteLine("Vamos Verificar sua Conta do ITAU :)\n");
                        Console.WriteLine("[Informe a ~Agência~ e o ~N° da Conta~\n");

                        Console.WriteLine("Digite o Número da sua Agência:");
                        string agenIT = Console.ReadLine();
                        Console.WriteLine();

                        Console.WriteLine("Digite o Número da sua Conta:");
                        string numeroContIT = Console.ReadLine();
                        Console.Clear();

                        bool verificacaoIta = Validadores.ValidarContaItau(agenIT, numeroContIT);                        

                        if (verificacaoIta)
                            msg.MsgInformacao("Conta Verificada Com Sucesso!");
                        else
                        {
                            msg.MsgInformacao("Tente Novamanete Mais Tarde :)");
                        }

                        break;
                    
                }
                Console.WriteLine("[-][-][-][-][-][-][-][-]BANCO CENTRAL[-][-][-][-][-][-][-][-]\n");
                Console.WriteLine("Pressione Qualquer Tecla Para Voltar ao Menu...");
                Console.ReadKey();
                Console.Clear();
            } while ((escolha < 4) && (escolha > 0));
        }
    }
}
