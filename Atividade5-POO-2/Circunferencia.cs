namespace Atividade5_POO_2
{
    public class Circunferencia : Forma
    {
        public double Raio;
        public override void CalcularArea()
        {
            Area = Math.PI * (Raio * Raio);

            Console.WriteLine($"\nA área da circunferência é {Area}");
        }
        public override void CalcularPerimetro()
        {
            Perimetro = 2 * Math.PI * Raio;

            Console.WriteLine($"O perímetro da circunferência é {Perimetro}");
        }
    }
}
