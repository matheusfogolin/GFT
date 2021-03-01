using System;

namespace TesteGFT5
{
    class Program : AreaCalculavel
    {
        static void Main(string[] args)
        {
            Quadrado quadrado = new Quadrado(10);
            Retangulo retangulo = new Retangulo (10, 10);
            Circulo circulo = new Circulo (10, 3.14);

             Console.WriteLine(quadrado.CalcularAreaQuadrado(10));
             Console.WriteLine(retangulo.CalcularAreaRetangulo(10,10));
             Console.WriteLine(circulo.CalcularAreaCirculo(10,));

        }
    }
}
