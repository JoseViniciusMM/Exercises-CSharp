using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestaoQuatro.RegrasdeNegocio
{
    class Reajuste
    {
        private string nome;
        private double salarioAtual        ;
        private double persentual;
        private double salarioReajustado;

        public void SetNome(string nome)
        {
            this.nome = nome.ToUpper();
        }
        public string GetNome()
        {
            return nome;
        }

        public void SetSalarioAtual(double salarioAtual)
        {
            this.salarioAtual = salarioAtual;
        }
        public void SetPercentual(double persentual)
        {
            this.persentual = persentual;
        }
        public void SalarioReajustado()
        {
            salarioReajustado = salarioAtual + (persentual * (salarioAtual / 100));
        }

        public double GetSalarioReajustado()
        {
            return salarioReajustado;
        }
    }
}