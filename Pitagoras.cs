using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorema_pitagoras_b
{
    class Pitagoras
    {
        protected string definicion = "El teorema de Pitágoras establece que, en todo triángulo rectángulo, la longitud de la hipotenusa es igual a la raíz cuadrada de la suma del área de los cuadrados de las respectivas longitudes de los catetos.";
        protected string año = "500 a.n.e";
        protected string tipodematematica = "Geometria y trigonometria";

        public Pitagoras(string definicion, string año, string tipodematematica)
        {
            this.definicion = definicion;
            this.año = año;
            this.tipodematematica = tipodematematica;
        }
        public string Definicion
        {
            get { return definicion; }
            set { definicion = value; }
        }
        public string Año
        {
            get { return año; }
            set { año = value; }
        }
        public string Tipodematematica
        {
            get { return tipodematematica; }
            set { tipodematematica = value; }
        }
    }
}
