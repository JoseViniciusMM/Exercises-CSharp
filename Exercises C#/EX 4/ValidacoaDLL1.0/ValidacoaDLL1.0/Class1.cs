using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidacoaDLL1._0
{
    public static class CalculoDeDatas
    {
        public static int DifDatasDias(int diaI, int mesI, int anoI, int diaF, int mesF, int anoF)
        {
            DateTime dataInicial = new DateTime(anoI, mesI, diaI);
            DateTime dataFinal = new DateTime(anoF, mesF, diaF);
            TimeSpan diferenca = dataFinal - dataInicial;
            int dias = diferenca.Days;
            return dias;
        }

        public static int DifDatasDias(string dataIni, string dataFin)
        {
            int diaI, mesI, anoI, diaF, mesF, anoF;

            diaI = Convert.ToInt32(dataIni.Substring(0,2));
            mesI = Convert.ToInt32(dataIni.Substring(3, 2));
            anoI = Convert.ToInt32(dataIni.Substring(6, 4));

            diaF = Convert.ToInt32(dataFin.Substring(0, 2));
            mesF = Convert.ToInt32(dataFin.Substring(3, 2));
            anoF = Convert.ToInt32(dataFin.Substring(6, 4));

            DateTime dataInicial = new DateTime(anoI, mesI, diaI);
            DateTime dataFinal = new DateTime(anoF, mesF, diaF);
            TimeSpan diferenca = dataFinal - dataInicial;
            int dias = diferenca.Days;
            return dias;
        }

        public static int DifDatasMeses(int diaI, int mesI, int anoI, int diaF, int mesF, int anoF) 
        {
            DateTime dataInicial = new DateTime(anoI, mesI, diaI);
            DateTime dataFinal = new DateTime(anoF, mesF, diaF);
            TimeSpan diferenca = dataFinal - dataInicial;
            int meses = (int)(diferenca.Days / 30.436875);
            return meses;
        }

        public static int DifDatasMeses(string dataIni, string dataFin)
        {
            int diaI, mesI, anoI, diaF, mesF, anoF;

            diaI = Convert.ToInt32(dataIni.Substring(0, 2));
            mesI = Convert.ToInt32(dataIni.Substring(3, 2));
            anoI = Convert.ToInt32(dataIni.Substring(6, 4));

            diaF = Convert.ToInt32(dataFin.Substring(0, 2));
            mesF = Convert.ToInt32(dataFin.Substring(3, 2));
            anoF = Convert.ToInt32(dataFin.Substring(6, 4));

            DateTime dataInicial = new DateTime(anoI, mesI, diaI);
            DateTime dataFinal = new DateTime(anoF, mesF, diaF);
            TimeSpan diferenca = dataFinal - dataInicial;
            int meses = (int)(diferenca.Days / 30.436875);
            return meses;
        }

        public static int DifDatasAnos(int diaI, int mesI, int anoI, int diaF, int mesF, int anoF)
        {
            DateTime dataInicial = new DateTime(anoI, mesI, diaI);
            DateTime dataFinal = new DateTime(anoF, mesF, diaF);
            TimeSpan diferenca = dataFinal - dataInicial;
            int ano = (int)(diferenca.Days / 365.2425);
            return ano;
        }

        public static int DifDatasAnos(string dataIni, string dataFin)
        {
            int diaI, mesI, anoI, diaF, mesF, anoF;

            diaI = Convert.ToInt32(dataIni.Substring(0, 2));
            mesI = Convert.ToInt32(dataIni.Substring(3, 2));
            anoI = Convert.ToInt32(dataIni.Substring(6, 4));

            diaF = Convert.ToInt32(dataFin.Substring(0, 2));
            mesF = Convert.ToInt32(dataFin.Substring(3, 2));
            anoF = Convert.ToInt32(dataFin.Substring(6, 4));

            DateTime dataInicial = new DateTime(anoI, mesI, diaI);
            DateTime dataFinal = new DateTime(anoF, mesF, diaF);
            TimeSpan diferenca = dataFinal - dataInicial;
            int ano = (int)(diferenca.Days / 365.2425);
            return ano;
        }

        public static int DifDataAtual(int diaI, int mesI, int anoI)
        {
            DateTime dataInicial = new DateTime(anoI, mesI, diaI);
            DateTime dataFinal = DateTime.Now;
            TimeSpan diferenca = dataFinal - dataInicial;
            int dias = diferenca.Days;
            return dias;
        }

        public static DateTime SomarDiasData(int diaI, int mesI, int anoI, int qtdDias)
        {
            DateTime dataFutura = new DateTime(anoI, mesI, diaI);
            return dataFutura.AddDays(qtdDias);
        }
    }
}
