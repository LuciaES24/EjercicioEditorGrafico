
using EjercicioEditorGrafico;

static void Main(string[] args){
    Circulo Circulo1 = new Circulo(3,4,12);
    Circulo1.Dibujar();
    Circulo1.Mover(23,4);
    Circulo1.Dibujar();

    Rectangulo Rectangulo1 = new Rectangulo(2, 6, 10, 2);
    Rectangulo1.Dibujar();
    Rectangulo1.Mover(200, 210);
    Rectangulo1.Dibujar();

    Punto Punto1 = new Punto(320, 400);
    Punto1.Dibujar();
    Punto1.Mover(120,50);
    Punto1.Dibujar();
}