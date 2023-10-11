using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEditorGrafico
{
    public class Circulo : Punto
    {
        public Circulo(int x, int y, int radio) {
            base.x = x;
            base.y = y;
            this.radio = radio;
        }

        public int radio { get; set; }

        override public void Mover(int x, int y)
        {

        }
    }
}
