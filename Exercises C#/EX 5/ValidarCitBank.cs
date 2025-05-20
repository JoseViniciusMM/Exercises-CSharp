public static bool ValidarCitiBank(string agencia, string conta)
        {
            // Variaveis
            bool verificado = false;
            int digitoCont = 0;
            int total = 0;
            int peso = 11;

            // Mensagens
            Mansagens msg = new Mansagens("POO - 4° Módulo");
            //######################################################################################//

            if (conta.Substring(10, 1).ToUpper() == "X")
            {
                digitoCont = 10;
            }
            else digitoCont = Convert.ToInt32(conta.Substring(10, 1));

            for (int i = 0; i < 10; i++)
            {
                total = peso * Convert.ToInt32(conta.Substring(i, 1)) + total;
                peso--;
            }

            int resto = total % 11;
            int dvCont = 11 - resto;
            if (dvCont == 11)
            {
                dvCont = 0;
            }
            if (dvCont == digitoCont)
            {
                verificado = true;
            }
            else
            
            msg.MsgErro("CONTA INVÁLIDA!");
            
            return verificado;
        }