using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorema_pitagoras_b
{
   

    class Operaciones
    {
        
        private string resultado;

        public string Resultado
        {
            get { return resultado; }
            set { resultado = value; }
        }
        public Operaciones()
        {
            resultado = "";
        }
        public string Suma(double n1, double n2)
        {
            resultado = Convert.ToString(n1 + n2);
            return resultado;
        }
        public string Cuadrado(double n1)
        {
            resultado = Convert.ToString(Math.Pow(n1, 2));
            return resultado;
        }
        public string Raiz(double n1)
        {
            resultado = Convert.ToString(Math.Sqrt(n1));
            return resultado;
        }
        public string Resta(double n1, double n2)
        {
            resultado = Convert.ToString(n1 - n2);
            return resultado;
        }
    }
}
