using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestaoUm.RegrasdeNegocio
{
    class Conversão
    {
        private double minutos;
        private double horas;

        public void SetMinutos(double minutos)
        {
        this.minutos = minutos;
        }

        public void ConverterMinutos ()
        {
            horas = minutos / 60;
        }

        public double GetHoras()
        {
            return horas;
        }
    
    }

}
