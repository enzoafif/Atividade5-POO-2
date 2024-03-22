namespace Atividade5_POO_2
{
    public class Quadrado : Forma
    {
        public double Lado;
        public override void CalcularArea()
        {
            Area = Lado * Lado;

            Console.WriteLine($"\nA área do quadrado é {Area}");
        }
        public override void CalcularPerimetro()
        {
            Perimetro = Lado * 4;

            Console.WriteLine($"O perímetro do quadrado é {Perimetro}");
        }
    }
}
