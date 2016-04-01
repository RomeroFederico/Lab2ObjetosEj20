using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    class Punto
    {
        private int _x;
        private int _y;

        /// <summary>
        /// Asigna las cordenadas al nuevo punto.
        /// </summary>
        /// <param name="x">
        /// Cordenada en el eje x.
        /// </param>
        /// <param name="y">
        /// Cordenada en el eje y.
        /// </param>
        public Punto(int x, int y)
        {
            this._x = x;
            this._y = y;
        }

        /// <summary>
        /// Devuelve la cordenada en x del punto.
        /// </summary>
        public int GetX()
        {
            return this._x;
        }

        /// <summary>
        /// Devuelve la cordenada en y del punto.
        /// </summary>
        public int GetY()
        {
            return this._y;
        }
    }
}
