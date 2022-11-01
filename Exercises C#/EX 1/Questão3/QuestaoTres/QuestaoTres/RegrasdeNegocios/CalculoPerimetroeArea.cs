using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestaoTres.RegrasdeNegocios
{
    class CalculoPerimetroeArea
    {
        private int valorBase;
        private int valorAltura;
        private int totalArea;
        private int totalPerimetro;

        public void SetValorBase(int valorBase)
        {
            this.valorBase = valorBase;
        }

        public void SetValorAltura(int valorAltura)
        {
            this.valorAltura = valorAltura;
        }

        public void ValorArea()
        {
            totalArea = valorBase * valorAltura;
        }
       
        public void TotalPerimetro()
        {
            totalPerimetro = 2 * valorBase + 2*valorAltura;
        }
        public double GetTotalArea()
        {
            return totalArea;
        }
        public double GetTotalPerimetro()
        {
            return totalPerimetro;
        }

    }

}