using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaMsg;

namespace BibliotecaValidacoes.Formatações
{
    public static class Validadores
    {      
        public static bool ValidarCpf(string cpf)
        {
            // Variaveis
            bool verificado = false;
            string digito1 = "0", digito2 = "0";
            int total = 0;
            int multiplicador = 10;

            // Mensagens
            Mensagens msg = new Mensagens("POO - 3º Módulo");

            // Ler quantidade de caracteres do CPF e comparar possibilidades de entrada para obter 1º digito
            int caracteres = cpf.Length;

            if (caracteres == 14)
            {
                for (int i = 0; i < 11; i++)
                {
                    if ((i != 3) & (i != 7))
                    {
                        total = multiplicador * Convert.ToInt32(cpf.Substring(i, 1)) + total;
                        multiplicador--;
                    }
                }
            }
            else
            {
                for (int i = 0; i < 9; i++)
                {
                    total = multiplicador * Convert.ToInt32(cpf.Substring(i, 1)) + total;
                    multiplicador--;
                }
            }

            // Calcular 1º Digito
            int resto = total % 11;
            if (resto >= 2) digito1 = (Convert.ToString(11 - resto));

            multiplicador = 11;
            total = 0;

            // Comparar possibilidades de entrada do CPF para obter 2º digito
            if (caracteres == 14)
            {
                string cpfVerificado = cpf.Substring(0, 12) + digito1;
                for (int i = 0; i < 13; i++)
                {
                    if ((i != 3) & (i != 7) & (i != 11))
                    {
                        total = multiplicador * Convert.ToInt32(cpfVerificado.Substring(i, 1)) + total;
                        multiplicador--;
                    }
                }
            }
            else
            {
                string cpfVerificado = cpf.Substring(0, 10) + digito1;
                for (int i = 0; i < 10; i++)
                {
                    total = multiplicador * Convert.ToInt32(cpfVerificado.Substring(i, 1)) + total;
                    multiplicador--;
                }
            }

            // Calcular 2º digito e verificar validação do CPF
            resto = total % 11;
            if (resto >= 2) digito2 = (Convert.ToString(11 - resto));

            string digitos = digito1 + digito2;
            if (caracteres == 14)
            {
                if (digitos == cpf.Substring(12, 2))
                    verificado = true;
                else
                    msg.MsgErro("CPF INVÁLIDO!");
            }
            if (caracteres == 11)
            {
                if (digitos == cpf.Substring(9, 2))
                    verificado = true;
                else
                    msg.MsgErro("CPF INVÁLIDO!");
            }

            return verificado;
        }

        public static bool ValidarCnpj(string cnpj)
        {
            bool verificado = false;
            string digito1 = "0", digito2 = "0";
            int total = 0;
            int multiplicador = 5;

            // Mensagens
            Mensagens msg = new Mensagens("POO - 3º Módulo");

            // Ler quantidade de caracteres do CNPJ e comparar possibilidades de entrada para obter 1º digito
            int caracteres = cnpj.Length;

            if (caracteres == 18)
            {
                for (int i = 0; i < 15; i++)
                {
                    if ((i != 2) & (i != 6) & (i != 10))
                    {
                        total = multiplicador * Convert.ToInt32(cnpj.Substring(i, 1)) + total;
                        if (multiplicador == 2)
                            multiplicador = 9;
                        else
                            multiplicador--;
                    }
                }
            }
            else
            {
                for (int i = 0; i < 12; i++)
                {
                    total = multiplicador * Convert.ToInt32(cnpj.Substring(i, 1)) + total;
                    if (multiplicador == 2)
                        multiplicador = 9;
                    else
                        multiplicador--;
                }
            }

            // Calcular 1º digito
            int resto = total % 11;
            if (resto >= 2) digito1 = (Convert.ToString(11 - resto));

            multiplicador = 6;
            total = 0;

            // Comparar possibilidades de entrada do CNPJ para obter 2º digito
            if (caracteres == 18)
            {
                string cnpjVerificado = cnpj.Substring(0, 16) + digito1;
                for (int i = 0; i < 17; i++)
                {
                    if ((i != 2) & (i != 6) & (i != 10) & (i != 15))
                    {
                        total = multiplicador * Convert.ToInt32(cnpjVerificado.Substring(i, 1)) + total;
                        if (multiplicador == 2)
                            multiplicador = 9;
                        else
                            multiplicador--;
                    }
                }
            }
            else
            {
                string cnpjVerificado = cnpj.Substring(0, 12) + digito1;
                for (int i = 0; i < 13; i++)
                {
                    total = multiplicador * Convert.ToInt32(cnpjVerificado.Substring(i, 1)) + total;
                    if (multiplicador == 2)
                        multiplicador = 9;
                    else
                        multiplicador--;
                }
            }

            // Calcular 2º digito e verificar validação do CNPJ
            resto = total % 11;
            if (resto >= 2) digito2 = (Convert.ToString(11 - resto));

            string digitos = digito1 + digito2;
            if (caracteres == 18)
            {
                if (digitos == cnpj.Substring(16, 2))
                    verificado = true;
                else
                    msg.MsgErro("CNPJ INVÁLIDO!");
            }
            if (caracteres == 14)
            {
                if (digitos == cnpj.Substring(12, 2))
                    verificado = true;
                else
                    msg.MsgErro("CNPJ INVÁLIDO!");
            }

            return verificado;
        }

        public static bool ValidarCitiBank(string agencia, string conta)
        {
            // Variaveis
            bool verificado = false;
            int digitoCont = 0;
            int total = 0;
            int peso = 11;
            int dvCont = 0;

            // Mensagens
            Mensagens msg = new Mensagens("POO - 4° Módulo");

            // Ler quantidade de caracteres da Conta e comparar possibilidades de entrada para obter digito de validação
            // Adicionar número 0 contas faltando caracteres
            int caracteres = conta.Length;

            if (caracteres == 12) 
            {
                digitoCont = Convert.ToInt32(conta.Substring(11, 1));

                for (int i = 0; i < 10; i++)
                {
                    total = peso * Convert.ToInt32(conta.Substring(i, 1)) + total;
                    peso--;
                }
            }

            if ((caracteres < 12) & (conta.Substring(caracteres - 2, 1) != "-"))
            {                     
                while (caracteres != 11)
                {
                    conta = "0" + conta;
                    caracteres++;
                }

                digitoCont = Convert.ToInt32(conta.Substring(10, 1));

                for (int i = 0; i < 10; i++)
                {
                    total = peso * Convert.ToInt32(conta.Substring(i, 1)) + total;
                    peso--;
                }   
            }
            if ((caracteres < 12) & (conta.Substring(caracteres - 2, 1) == "-"))
            {
                while (caracteres != 12)
                {
                    conta = "0" + conta;
                    caracteres++;
                }
               
                digitoCont = Convert.ToInt32(conta.Substring(11, 1));

                for (int i = 0; i < 10; i++)
                {
                    total = peso * Convert.ToInt32(conta.Substring(i, 1)) + total;
                    peso--;
                }
            }

            // Calcular digito de verificação e verificar validação da Conta
            int resto = total % 11;

            if (resto > 1) dvCont = 11 - resto;

            if (dvCont == digitoCont)           
                verificado = true;      
            else
                msg.MsgErro("Conta Não foi Aprovada, N° de Conta Inválido!");

            return verificado;
        }

        public static bool ValidarContaItau(string agencia, string conta)
        {
            // Variaveis
            bool verificado = false;
            int resultado = 0, altSequencia = 2, valor = 0, resto = 0, digito = 0; ;
            string unidadeDezena = "0";

            // Mensagens
            Mensagens msg = new Mensagens("POO - 3º Módulo");

            // Ler quantidade de caracteres da Agência e da Conta
            int caracteresAg = agencia.Length, caracteresCo = conta.Length;

            // Adicionar número 0 em agências ou contas faltando caracteres
            if (caracteresAg < 4)
            {
                while (caracteresAg != 4)
                {
                    agencia = "0" + agencia;
                    caracteresAg++;
                }
            }
            if (caracteresCo == 7) conta = conta.Substring(0, 1) + conta.Substring(1, 1) + conta.Substring(2, 1) + conta.Substring(3, 1) + conta.Substring(4, 1) + conta.Substring(6, 1);

            if ((caracteresCo < 7) & (conta.Substring(caracteresCo - 2, 1) != "-"))
            {
                while (caracteresCo != 6)
                {
                    conta = "0" + conta;
                    caracteresCo++;
                }
            }
            if ((caracteresCo < 7) & (conta.Substring(caracteresCo - 2, 1) == "-"))
            {
                while (caracteresCo != 7)
                {
                    conta = "0" + conta;
                    caracteresCo++;
                }
                conta = conta.Substring(0, 1) + conta.Substring(1, 1) + conta.Substring(2, 1) + conta.Substring(3, 1) + conta.Substring(4, 1) + conta.Substring(6, 1);
            }

            // Concaternar Agência e Conta e calcular digito de acordo com as possibilidades de entrada de agência e conta
            string concatenacao = agencia + conta;

            for (int i = 0; i < 9; i++)
            {
                if (altSequencia == 2)
                {
                    valor = Convert.ToInt32(concatenacao.Substring(i, 1)) * 2;
                    if (valor > 9)
                    {
                        unidadeDezena = Convert.ToString(valor);
                        valor = Convert.ToInt32(unidadeDezena.Substring(0, 1)) + Convert.ToInt32(unidadeDezena.Substring(1, 1));
                        resultado += valor;
                        altSequencia = 1;
                    }
                    else
                    {
                        resultado += valor;
                        altSequencia = 1;
                    }
                }
                else
                {
                    valor = Convert.ToInt32(concatenacao.Substring(i, 1)) * 1;
                    resultado += valor;
                    altSequencia = 2;
                }
            }

            // Calcular digito verificador e retornar validação da conta
            resto = resultado % 10;
            if (resto != 0) digito = 10 - resto;

            if (digito == Convert.ToInt32(conta.Substring(5, 1)))
                verificado = true;
            else
                msg.MsgErro("Conta Não foi Aprovada, N° de Conta ou Agência Inválido!");

            return verificado;
        }        
    }
}
