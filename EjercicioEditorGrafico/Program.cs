
using EjercicioEditorGrafico;

Punto punto1 = new Punto(200, 340);
Console.WriteLine(punto1.Dibujar());
Console.WriteLine(punto1.Mover(20, 100));
Console.WriteLine(punto1.Dibujar());

Circulo Circulo1 = new Circulo(32,64,12);
Console.WriteLine(Circulo1.Dibujar());
Console.WriteLine(Circulo1.Mover(23,4));
Console.WriteLine(Circulo1.Dibujar());

Rectangulo Rectangulo1 = new Rectangulo(34, 27, 12, 22);
Console.WriteLine(Rectangulo1.Dibujar());
Console.WriteLine(Rectangulo1.Mover(200, 210));
Console.WriteLine(Rectangulo1.Dibujar());

Punto Punto1 = new Punto(320, 400);
Console.WriteLine(Punto1.Dibujar());
Console.WriteLine(Punto1.Mover(120,50));
Console.WriteLine(Punto1.Dibujar());

Punto PuntoGraficoComp = new Punto(33, 44);
Rectangulo RectanguloGraficoComp = new Rectangulo(100, 120, 10, 12);
GraficoCompuesto GraficoCompuesto1 = new GraficoCompuesto();
GraficoCompuesto1.AñadirGrafico(PuntoGraficoComp);
GraficoCompuesto1.AñadirGrafico(RectanguloGraficoComp);
Console.WriteLine(GraficoCompuesto1.Dibujar());
Console.WriteLine(GraficoCompuesto1.Mover(10, 20));
Console.WriteLine(GraficoCompuesto1.Dibujar());
