using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAtividadeDois.RegrasDeNegocio
{
    class COMISSAO
    {
        //Atributos da Classe
        private string nome;
        private double valorTotalVendas;
        private double salarioVendedor;
        private double calculoComissao;
        private double somaComissao;

        //Método Construtor
        public COMISSAO(string nome, double valorTotalVendas, double salarioVendedor)
        { 
            this.nome = nome;

            this.valorTotalVendas = valorTotalVendas;

            this.salarioVendedor = salarioVendedor;
        }
       
        //Método Normal
        public void CalcularComissao()
        {  
            if (valorTotalVendas > 50.000)
            {
              calculoComissao = (valorTotalVendas/100) * 12;
            }
        
            if (valorTotalVendas >= 30.000 && valorTotalVendas >= 50.000)
            {
              calculoComissao =(valorTotalVendas/100)* 9.5;  
            }
            
            else 
            {
              calculoComissao = (valorTotalVendas/100) * 7;
            }
        }

        public void SomaComissao()
        {
            somaComissao = salarioVendedor + calculoComissao;
        }
        public double GetCalculoComissao()
        {
          return calculoComissao; 
        }

        public double GetSomaComissao()
        {
           return somaComissao;
        }

    }
}
