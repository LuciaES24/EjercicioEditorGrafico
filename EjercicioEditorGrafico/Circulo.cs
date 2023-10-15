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

#pragma warning disable CS0108 // El miembro oculta el miembro heredado. Falta una contraseña nueva
        public void Dibujar()
#pragma warning restore CS0108 // El miembro oculta el miembro heredado. Falta una contraseña nueva
        {
            Console.WriteLine($"Dibujo Circulo || X:{X} Y:{Y} Radio:{Radio}");
        }

#pragma warning disable CS0108 // El miembro oculta el miembro heredado. Falta una contraseña nueva
        public bool Mover(int x, int y)
#pragma warning restore CS0108 // El miembro oculta el miembro heredado. Falta una contraseña nueva
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
