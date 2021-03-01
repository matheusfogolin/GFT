namespace TesteGFT5
{
    public class Quadrado : AreaCalculavel
    {
        public Quadrado(decimal lado)
        {
            Lado = lado;
        }
        public decimal Lado { get; set; }

        public decimal CalcularAreaQuadrado(decimal lado)
        {
            return lado * lado;
        }
    }

}