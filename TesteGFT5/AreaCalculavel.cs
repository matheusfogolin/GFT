namespace TesteGFT5
{
    public interface AreaCalculavel
    {


        public decimal CalcularAreaRetangulo(decimal largura, decimal altura)
        {
            return largura * altura;
        }

        public decimal CalcularAreaCirculo (decimal raio, decimal pi)
        {
            
            return pi * (raio * raio);
        }

    }
}