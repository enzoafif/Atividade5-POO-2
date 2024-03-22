namespace Atividade5_POO_2
{
    public class Hexagono : Forma
    {
        public double Lado;
        public override void CalcularArea()
        {
            Area = 3 * (Lado * Lado) * Math.Sqrt(3) / 2;

            Console.WriteLine($"\nA área do hexágono é {Area}");
        }
        public override void CalcularPerimetro()
        {
            Perimetro = Lado * 6;

            Console.WriteLine($"O perímetro do hexágono é {Perimetro}");
        }
    }
}
