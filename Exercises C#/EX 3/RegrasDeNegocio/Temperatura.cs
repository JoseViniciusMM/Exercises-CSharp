using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAtividadeTres.RegrasDeNegocio
{
    class Temperatura
    {
        public static double ConversaoCelsiusParaFarenheit(double celsius)
        {
            double calculo  = (celsius * 1.8) + 32;
            return calculo;
        }
       
        public static double ConversaoFarenheitParaCelsius(double farenheit)
        {
            double calculo = (farenheit - 32) / 1.8;
            return calculo;
        }

        public static double ConversaoCelsiusParaKelvin(double celsius)
        {
            double calculo = celsius + 273.15;
            return calculo;
        }

        public static double ConversaoKelvinParaCelsius(double kelvin)
        {
            double calculo = kelvin - 273.15;
            return calculo;
        }

        public static double ConversaoKelvinParaFarenheit(double kelvin)
        {
            double calculo =   (kelvin - 273.15) *9 / 5 + 32;
            return calculo;
        }
       
        public static double ConversaoFarenheitparaKelvin(double farenheit)
        {
            double calculo = (farenheit - 32)*5 / 9 + 273.15;
            return calculo;
        }  
    }
}
