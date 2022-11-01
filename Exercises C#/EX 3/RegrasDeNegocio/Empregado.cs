using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAtividadeTres.RegrasDeNegocio
{
    class Empregado
    {
        private string nomeEmpregado;
        private string funcaoEmpregado;
        private double salarioMensal;
        private double salarioReajustado;
        private double percentual;
      
        public Empregado(string nomeEmpregado)
        {
            this.nomeEmpregado = nomeEmpregado;
        }
        public Empregado(string nomeEmpregado, string funcaoEmpregado)
        {
            this.nomeEmpregado = nomeEmpregado;

            this.funcaoEmpregado = funcaoEmpregado;
        }
        
        public Empregado(string nomeEmpregado, string funcaoEmpregado, double salarioMensal)
  
        {
            this.nomeEmpregado = nomeEmpregado;

            this.funcaoEmpregado = funcaoEmpregado;

            this.salarioMensal = salarioMensal;
        }

        public void SetNomeEmpregado(string nomeEmpregado)
        {
            this.nomeEmpregado = nomeEmpregado;
        }
        public void SetFuncaoEmpregado(string funcaoEmpregado)
        {
            this.funcaoEmpregado = funcaoEmpregado;
        }
        public void SetSalarioMensal(double salarioMensal)
        {
            this.salarioMensal = salarioMensal;
        }
        public void SetPercentual(double percentual)
        {
            this.percentual = percentual;
        }
        public void SetSalarioReajustado(double salarioReajustado)
        {
            this.salarioReajustado = salarioReajustado;
        }
        
        public void SalarioReajustado(double percentual)
        {
            if (salarioMensal < 1100)
                salarioMensal = 1100;

             salarioReajustado = salarioMensal + ((salarioMensal / 100) * percentual);
        }

        public string GetNomeEmpregado()
        {
            return nomeEmpregado;
        }
        public string GetFuncaoEmpregado()
        {
            return funcaoEmpregado;
        }
        public double GetSalarioMensal()
        {
            return salarioMensal;
        }
        public double GetPercentual()
        {
            return percentual;
        }
        public double GetSalarioReajustado()
        {
            return salarioReajustado;
        }
    }
}
