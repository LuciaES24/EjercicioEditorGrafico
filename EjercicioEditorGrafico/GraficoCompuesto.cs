using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEditorGrafico
{
    public class GraficoCompuesto : IGrafico
    {
        List<IGrafico> elementos = new List<IGrafico>();

        public void Dibujar()
        {
            throw new NotImplementedException();
        }

        public bool Mover(int x, int y)
        {
            throw new NotImplementedException();
        }
    } 
}
