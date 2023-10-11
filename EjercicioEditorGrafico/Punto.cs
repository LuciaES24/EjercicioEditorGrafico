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
            this.x = x;
            this.y = y;
        }

        public int x { get; set; }

        public int y { get; set; }

        public void Dibujar()
        {
            
        }

        public bool Mover(int x, int y)
        {
            if (x > EditorGrafico.Ancho && y > EditorGrafico.Alto || x < 0 && y < 0)
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
