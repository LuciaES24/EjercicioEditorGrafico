using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEditorGrafico
{
    public class Circulo : Punto
    {
        public Circulo(int x, int y, int radio):base(x,y) {
            this.Radio = radio;
        }

        public int Radio { get; set; }

        public override void Dibujar()
        {
            Console.WriteLine($"Dibujo Circulo || X:{X} Y:{Y} Radio:{Radio}");
        }

        public override bool Mover(int x, int y)
        {
            X = X + x + Radio;
            Y = Y + y + Radio;
            if (X > EditorGrafico.Ancho || Y > EditorGrafico.Alto || X < 0 || Y < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
