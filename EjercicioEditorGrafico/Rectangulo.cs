using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEditorGrafico
{
    public class Rectangulo : Punto
    {
        public Rectangulo(int x, int y, int ancho, int alto) : base(x,y)
        {
            if (x + ancho > EditorGrafico.Ancho || y + alto > EditorGrafico.Alto || x - ancho < 0 || y - alto < 0)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                this.AnchoR = ancho;
                this.AltoR = alto;
            }
        }

        public int AnchoR { get; set; }

        public int AltoR { get; set; }

        public override string Dibujar()
        {
            return $"Dibujo Rectángulo || X:{X} Y:{Y} Ancho:{AnchoR} Alto:{AltoR}";
        }

        public override bool Mover(int x, int y)
        {
            X = X + x + AnchoR;
            Y = Y + y + AltoR;
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
