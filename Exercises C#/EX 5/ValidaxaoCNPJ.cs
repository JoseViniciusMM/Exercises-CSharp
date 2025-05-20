public class ValidãçãoCNPJ
        {
            public bool validarCNPJ(string cnpj)
            {
                // Variaveis
                int somador;
                int resto;
                string digito;
                string cnpjAux;

                // Multiplicadores
                int[] multiplicador1 = new [12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] multiplicador2 = new [12] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

                // Evitar Possivéis Erros 
                //######################################################################################//

                cnpj = cnpj.Trim(); // Tira Espaços

                cnpj = cnpj.Replace(",","").Replace("/","").Replace("-","").; // Tira Mascara
                if (cnpj.Length != 14) // Limitando Tamanho
                {
                    return false;
                }
                else
                {
                    cnpjAux = cnpj.Substring(0, 12); // Separando CNPJ
                    somador = 0;
                    for (int i = 0; i < 12; i++) // Contador
                    {
                        somador += Convert.ToInt16(cnpjAux[i]) * multiplicador1[i] // Calculo Multiplicador 
                    }
                    resto = (somador %11); // Achando o Resto
                    if (resto < 2)
                        resto = 0; // Correção Digito "0"
                    else
                        resto = 11 - resto; // Outro Digito
                                            
                    digito = resto.ToString(); // Armazenamento do 1° Digito
                    cnpjAux = cnpjAux + digito; //13 Números
                    somador = 0;

                    //######################################################################################//

                    for (int i = 0; i < 13; i++) // Contador
                    {
                        somador += Convert.ToInt16(cnpjAux[i]) * multiplicador2[i]; // Calculo Multiplicador 
                    }
                    resto = (somador % 11); // Achando o Resto
                    if (resto < 2)
                        resto = 0; // Correção Digito "0"
                    else
                        resto = 11 - resto; // Outro Digito

                    digito = digito + resto.ToString(); // Concatenar o 1° com 2°
                    return cnpj.EndsWith(digito); // Se for igual retorna true senao false
                }
            }
        }   