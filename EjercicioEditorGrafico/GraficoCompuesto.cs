using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEditorGrafico
{
    public class GraficoCompuesto : IGrafico
    {
        List<IGrafico> Elementos = new List<IGrafico>();

        public override void Dibujar()
        {
            Console.WriteLine("Dibujo Gráfico Compuesto");
        }

        override public bool Mover(int x, int y)
        {
            foreach (var item in Elementos)
            {
                item.Mover(x, y);
            }
        }

        public void AñadirGrafico (IGrafico grafico)
        {
            Elementos.Add(grafico);
        }
    } 
}
