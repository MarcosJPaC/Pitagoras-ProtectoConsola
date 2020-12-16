using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorema_pitagoras_b
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            Catetos obj = new Catetos("El teorema de Pitágoras establece que, en todo triángulo rectángulo, la longitud de la hipotenusa es igual a la raíz cuadrada de la suma del área de los cuadrados de las respectivas longitudes de los catetos", "500 a.n.e", "Geometria y trigonometria", "El cateto opuesto es el lado que está enfrente del ángulo dado", "El cateto adyacente es el lado que está junto al ángulo dado, y que no es la hipotenusa..", "La hipotenusa es el lado opuesto al ángulo recto en un triángulo rectángulo, resultando ser su lado de mayor longitud");
            Console.WriteLine("La definicion es : " + obj.Definicion);
            Console.WriteLine("El año de origen es: " + obj.Año);
            Console.WriteLine("Pertenece al tipo de matematica : " + obj.Tipodematematica);
            Console.WriteLine("El cateto opuesto es : " + obj.CatetoA);
            Console.WriteLine("El cateto adyacente es : " + obj.Catetob);
            Console.WriteLine("La hipotenusa es : " + obj.Catetoc);
            Console.ReadKey();
            Console.Clear();
            //
            string ladofaltante,c1,c2,s,r;
            double d1, d2;
            Console.WriteLine("Introduzca el lado del triangulo que se busca.");
            Console.WriteLine("(a= Cateto Opuesto, b= Cateto Adyacente, c= Hipotenusa)");
            ladofaltante = Console.ReadLine();
            switch (ladofaltante)
            {
                case "a":
                    Console.WriteLine("Introduce el valor de b");
                    d1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Introduce el valor de c");
                    d2 = double.Parse(Console.ReadLine());
                    if (d2 > d1)
                    {
                        Console.WriteLine("El numero resultante es negativo, imposible calcualar raiz cuadrada");
                    }
                    else;
                    Operaciones cuadrado = new Operaciones();
                    c1 = cuadrado.Cuadrado(d1);
                    c2 = cuadrado.Cuadrado(d2);
                    Operaciones resta = new Operaciones();
                    s = resta.Resta(double.Parse(c1), double.Parse(c2));
                    Operaciones raiz = new Operaciones();
                    r = raiz.Raiz(double.Parse(s));
                    Console.WriteLine("a²= √ b² - c²");
                    Console.WriteLine("a²= √ " +d1 + "²"+" - " + d2 + "²" );
                    Console.WriteLine("a= √" + s );
                    Console.WriteLine("a= " + r);
                    Console.WriteLine("Presiona una tecla para salir");
                    Console.ReadKey();
                    break;
                case "b":
                    Console.WriteLine("Introduce el valor de a");
                    d1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Introduce el valor de c");
                    d2 = double.Parse(Console.ReadLine());
                    if (d2 > d1)
                    {
                        Console.WriteLine("El numero resultante es negativo, imposible calcular raiz cuadrada");
                        
                    }
                    else;
                    Operaciones cuadrado2 = new Operaciones();
                    c1 = cuadrado2.Cuadrado(d1);
                    c2 = cuadrado2.Cuadrado(d2);
                    Operaciones resta2 = new Operaciones();
                    s = resta2.Resta(double.Parse(c1), double.Parse(c2));
                    Operaciones raiz2 = new Operaciones();
                    r = raiz2.Raiz(double.Parse(s));
                    Console.WriteLine("b²= √ a² - c²");
                    Console.WriteLine("b²= √ " + d1 + "²" + " - " + d2 + "²");
                    Console.WriteLine("b= √" + s);
                    Console.WriteLine("b= " + r);
                    Console.WriteLine("Presiona una tecla para salir");
                    Console.ReadKey();
                    break;
                case "c":
                    Console.WriteLine("Introduce el valor de a");
                    d1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Introduce el valor de b");
                    d2 = double.Parse(Console.ReadLine());
                    Operaciones cuadrado3 = new Operaciones();
                    c1 = cuadrado3.Cuadrado(d1);
                    c2 = cuadrado3.Cuadrado(d2);
                    Operaciones suma = new Operaciones();
                    s = suma.Suma(double.Parse(c1), double.Parse(c2));
                    Operaciones raiz3 = new Operaciones();
                    r = raiz3.Raiz(double.Parse(s));
                    Console.WriteLine("c²= √ a² + b²");
                    Console.WriteLine("c²= √ " + d1 + "²" + " + " + d2 + "²");
                    Console.WriteLine("c= √" + s);
                    Console.WriteLine("c= " + r);
                    Console.WriteLine("Presiona una tecla para salir");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
