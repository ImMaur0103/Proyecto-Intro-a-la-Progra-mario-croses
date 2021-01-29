using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfas
{
    public class tiempo
    {
        int segundosnivel1;
        int segundosjugados;
        string label;
        public tiempo(int a, int b, string c)
        {
            segundosnivel1 = a;
            segundosjugados = b;
            label = c;
        }

        int gethoras(ref int segundos)
        {
            int horas = segundos / 3600;
            segundos = segundos % 3600;
            return horas;
        }
        int getminutos(ref int segundos)
        {
            int horas = segundos / 60;
            segundos = segundos % 60;
            return horas;
        }
        private void settiempo()
        {
            int segundos = segundosnivel1 - segundosjugados;
            int horas = gethoras(ref segundos);
            int min = getminutos(ref segundos);
            string ssegundos = segundos.ToString("00");
            string shoras = horas.ToString("00");
            string smin = min.ToString("00");
            label = "Tiempo:  " + shoras + ":" + smin + ":" + ssegundos;
        }
        public string retornar()
        {
            settiempo();
            return label;
        }

    }
}
