using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidacoaDLL1._0.Otimizado
{
    class CalculoDatas
    {
        private static TimeSpan DiferencaComInt(int diaI, int mesI, int anoI, int diaF, int mesF, int anoF)
        {
            DateTime dataInicial = new DateTime(anoI, mesI, diaI);
            DateTime dataFinal = new DateTime(anoF, mesF, diaF);
            TimeSpan diferenca = dataFinal - dataInicial;
            return diferenca;
        }

        private static TimeSpan DiferencaComString(string dataIni, string dataFin)
        {
            int diaI, mesI, anoI, diaF, mesF, anoF;

            diaI = Convert.ToInt32(dataIni.Substring(0, 2));
            mesI = Convert.ToInt32(dataIni.Substring(3, 2));
            anoI = Convert.ToInt32(dataIni.Substring(6, 4));

            diaF = Convert.ToInt32(dataFin.Substring(0, 2));
            mesF = Convert.ToInt32(dataFin.Substring(3, 2));
            anoF = Convert.ToInt32(dataFin.Substring(6, 4));

            TimeSpan diferenca = DiferencaComInt(diaI, mesI, anoI, diaF, mesF, anoF);
            return diferenca;
        }
        //###################################Diferença Entre Dias###################################//
        public static int DifDataDiasInt(int diaI, int mesI, int anoI, int diaF, int mesF, int anoF)
        {
            TimeSpan diferenca = DiferencaComInt(diaI, mesI, anoI, diaF, mesF, anoF);
            int dias = diferenca.Days;
            return dias;
        }
        public static int DifDataDiasString(string dataIni, string dataFin)
        {
            TimeSpan diferenca = DiferencaComString(dataIni, dataFin);
            int dias = diferenca.Days;
            return dias;
        }
        //###################################Diferença Entre Meses###################################//
        public static int DifDataMesesInt(int diaI, int mesI, int anoI, int diaF, int mesF, int anoF)
        {
            TimeSpan diferenca = DiferencaComInt(diaI, mesI, anoI, diaF, mesF, anoF);
            int meses = (int)(diferenca.Days / 30.436875);
            return meses;
        }
        public static int DifDataMesesString(string dataIni, string dataFin)
        {
            TimeSpan diferenca = DiferencaComString(dataIni, dataFin);
            int meses = (int)(diferenca.Days / 30.436875);
            return meses;
        }
        //###################################Diferença Entre Anos###################################//
        public static int DifDataAnosInt(int diaI, int mesI, int anoI, int diaF, int mesF, int anoF)
        {
            TimeSpan diferenca = DiferencaComInt(diaI, mesI, anoI, diaF, mesF, anoF);
            int anos = (int)(diferenca.Days / 365.2425);
            return anos;
        }
        public static int DifDataAnosString(string dataIni, string dataFin)
        {
            TimeSpan diferenca = DiferencaComString(dataIni, dataFin);
            int anos = (int)(diferenca.Days / 365.2425);
            return anos;
        }
    }
}