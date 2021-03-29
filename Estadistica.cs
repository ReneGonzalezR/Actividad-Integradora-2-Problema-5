using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_Integradora_2_Problema_5
{
    class Estadistica
    {
        string[] semana = new string[] { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };
        string dato = string.Empty;
        public string VentasMenores(double[] dias)
        {
            for (int i = 0; i < dias.Length; i++)
            {
                if (dias[i] < 5000)
                {
                    dato = string.Format("{0} \r\n {1} ${2}", dato, semana[i], dias[i]);
                }
            }
            return dato;
        }
        public string TodasLasVentas(double[] dias)
        {
            for (int i = 0; i < dias.Length; i++)
            {
                dato = string.Format("{0} \r\n {1} ${2}", dato, semana[i], dias[i]);
            }
            return dato;
        }
        public string VentaMasBaja(double[] dias)
        {
            double min = dias[0];
            for (int i = 0; i < dias.Length; i++)
            {
                if (dias[i] < min)
                {
                    min = dias[i];
                    dato = string.Format("\r\n {0} ${1}", semana[i], min);
                }
            }
            return dato;
        }
    }
}
