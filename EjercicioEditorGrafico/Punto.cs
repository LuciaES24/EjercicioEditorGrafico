using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEditorGrafico
{
    public class Punto: IGrafico
    {
        public Punto(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X { get; set; }

        public int Y { get; set; }

        public void Dibujar()
        {
            Console.WriteLine($"Dibujo Punto || X:{X} Y:{Y}");
        }

        public bool Mover(int x, int y)
        {
            X = X + x;
            Y = Y + y;
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
