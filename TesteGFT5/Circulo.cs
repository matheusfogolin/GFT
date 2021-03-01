namespace TesteGFT5
{
    public class Circulo : AreaCalculavel
    {
        public Circulo(double raio, double pi)
        {
            Raio = raio;
            Pi = pi;
        }
        public double Raio { get; set; }
        public double Pi { get; set; }

        public decimal CalcularAreaCirculo (double raio, double pi)
        {
            Pi = 3.14;
            
            return Pi * (Raio * Raio);
        }
    }
}