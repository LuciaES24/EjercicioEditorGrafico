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

        public bool Mover(int x, int y)
        {
            var esCorrecto = true;
            foreach (var item in Elementos)
            {
                if(item.Mover(x,y) == true)
                {
                    esCorrecto = true;
                }else 
                {
                    esCorrecto = false;
                    break;
                }
            }
            return esCorrecto;
        }

        public string Dibujar()
        {
            var grafico = "Dibujo Gráfico Compuesto || ";
            foreach (var item in Elementos)
            {
                grafico += item.Dibujar() + " || ";
            }
            return grafico;
        }

        public void AñadirGrafico (IGrafico grafico)
        {
            Elementos.Add(grafico);
        }
    } 
}
