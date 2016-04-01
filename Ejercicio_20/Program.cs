using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Geometria;

namespace PruebaGeometria
{

    /*
    20.  Escribir una aplicación con estos dos espacios de nombres 
    (namespaces): Geometría y PruebaGeometria.  
    Dentro del espacio de nombres Geometría se deberán escribir dos 
    clases: Punto y Rectangulo.  
   
    La clase Punto ha de tener dos atributos privados con acceso de 
    sólo lectura (sólo con getters), que serán las coordenadas del 
    punto.  
    La clase Rectangulo tiene los atributos de tipo Punto vertice1, 
    vertice2, vertice3 y vertice4 (que corresponden a los cuatro 
    vértices del rectángulo).  
    La base de todos los rectángulos de esta clase será siempre 
    horizontal. Por lo tanto, debe tener un constructor para 
    construir el rectángulo por medio de los vértices 1 y 3 (Utilizar 
    el método Abs de la clase Math, dicho método retorna el valor 
    absoluto de un número, para obtener la distancia entre puntos).  
    Los atributos lado, área y perímetro se deberán inicializar una 
    vez construido el rectángulo.  
    En el espacio de nombres PruebaGeometria es donde se escribirá 
    una clase con el método Main para probar si funcionan las clases 
    escritas anteriormente. En este espacio de nombres se utilizará 
    la directiva 'using' para poder utilizar todos los miembros del 
    espacio de nombres Geometría directamente.  
    En la clase que contiene el Main, desarrollar un método de clase 
    que muestre todos los datos del rectángulo que recibe como 
    parámetro.
    */

    class Ejercicio_20
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro. 20";
        }
    }
}
