using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestaoDois.RegrasdeNegocios
{
    class CalculoRaiz
    {
        private double valordoRadicando;
        private double valordaRaiz;

        public void SetRadicando(double valordoRadicando)
        {
            this.valordoRadicando = valordoRadicando;
        }

        public void ConverterRadicando()
        {
            valordaRaiz = Math.Sqrt(valordoRadicando);    
        }

        public double GetValorRaiz()
        {
            return valordaRaiz;
        }

    }

}
