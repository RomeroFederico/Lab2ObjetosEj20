using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    class Rectangulo
    {   
        public float lado;
        public float b;
        public float area;
        public float perimetro;
        public Punto vertice1;
        public Punto vertice2;
        public Punto vertice3;
        public Punto vertice4;
        
        /// <summary>
        /// Construye un nuevo rectangulo a partir de sus vertices.
        /// </summary>
        /// <param name="vertice1">
        /// Primer vertice del rectangulo.
        /// </param>
        /// <param name="vertice3">
        /// Segundo vertice del rectangulo.
        /// </param>
        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
            this.vertice2 = new Punto(this.vertice3.GetX(), this.vertice1.GetY());
            this.vertice4 = new Punto(this.vertice1.GetX(), this.vertice3.GetY());
            this.lado = Math.Abs(this.vertice1.GetX() - this.vertice2.GetX());
            this.b = Math.Abs(this.vertice4.GetY() - this.vertice1.GetY());
            this.perimetro = this.lado * 2 + this.b * 2;
            this.area = this.lado * this.b;
        }
    }
}
