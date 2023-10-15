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

        public void Dibujar()
        {
            Console.WriteLine("Dibujo Gráfico Compuesto");
        }

        public bool Mover(int x, int y)
        {
            foreach (var item in Elementos)
            {
                return item.Mover(x, y);
            }
        }

        public string Dibujar()
        {
            Console.WriteLine("Gráfico Compuesto ");
            foreach (var item in Elementos)
            {
                item.Dibujar();
            }
        }

        public void AñadirGrafico (IGrafico grafico)
        {
            Elementos.Add(grafico);
        }
    } 
}
