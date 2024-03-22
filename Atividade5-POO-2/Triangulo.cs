namespace Atividade5_POO_2
{
    public class Triangulo : Forma
    {
        public double LadoA;
        public double LadoB;
        public double LadoC;

        public override void CalcularArea()
        {
            double altura = (LadoA + LadoB + LadoC) / 2;

            Area = LadoB * altura / 2;

            Console.WriteLine($"\nA área do triângulo é {Area}");
        }
        public override void CalcularPerimetro()
        {
            Perimetro = LadoA + LadoB + LadoC;

            Console.WriteLine($"O perímetro do triângulo é {Perimetro}");
        }
    }
}
