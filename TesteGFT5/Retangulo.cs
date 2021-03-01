namespace TesteGFT5
{
    public class Retangulo : AreaCalculavel
    {
        public Retangulo(decimal largura, decimal altura)
        {
            Largura = largura;
            Altura = altura;
        }
        public decimal Largura { get; set; }
        public decimal Altura { get; set; }

        public decimal CalcularAreaRetangulo(decimal largura, decimal altura)
        {
            return largura * altura;
        }



    }
}