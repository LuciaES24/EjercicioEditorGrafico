using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEditorGrafico
{
    public interface IGrafico
    {
        public bool Mover(int x, int y);

        public void Dibujar();
    }
}
