using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAtividadeDois.RegrasDeNegocio
{
    class FATURA
    {
        //Atributos da Classe
        private string descricaoItem;
        private int numeroFaturado;
        private int quantidadeItem;
        private double precoUnitario;
        private double calculoFatura;

        //Método Construtor
        public FATURA(string descricaoItem, int numeroFaturado, int quantidadeItem, double precoUnitario)
        {
            this.descricaoItem = descricaoItem;

            this.numeroFaturado = numeroFaturado;

            this.quantidadeItem = quantidadeItem;

            this.precoUnitario = precoUnitario;
        }

        //Método Normal
        public void SetDescricaoItem()
        {
            this.descricaoItem = descricaoItem;
        }
        public string GetDescricaoItem()
        {
            return descricaoItem;
        }
        public void SetNumeroFaturado()
        {
            this.numeroFaturado = numeroFaturado;
        }
        public int GetNumeroFaturado()
        {
            return numeroFaturado;
        }
        public void SetQuantidadeItem()
        {
            this.quantidadeItem = quantidadeItem;
        }
        public void NumeroZero ()
        {
          if(quantidadeItem < 0)
          {
                quantidadeItem = 0;
          }
        }
        public int GetQuantidadeItem()
        {
            return quantidadeItem;
        }
        public void SetPrecoUnitario()
        {
            this.precoUnitario = precoUnitario;
        }
        public void NumeroZeroZero()
        {
           if (precoUnitario<0)
           {
                precoUnitario = 0.0;
           }
        }
        public void CalculoFatura()
        {
            calculoFatura = quantidadeItem * precoUnitario;
        }
        public double GetPrecoUnitario()
        {
            return precoUnitario;
        }
        public double GetCalculoFatura()
        {
            return calculoFatura;
        }
    }
}
