namespace Atividade5_POO_2
{
    public class GerarForma
    {
        Circunferencia circunferencia = new();
        Triangulo triangulo = new();
        Quadrado quadrado = new();
        Hexagono hexagono = new();
        public void SolicitarForma()
        {

            bool loop = true;

            while (loop)
            {

                try
                {
                    Console.WriteLine("Qual forma deseja calcular?\n");

                    Console.WriteLine("1-Circunferência");
                    Console.WriteLine("2-Triângulo");
                    Console.WriteLine("3-Quadrado");
                    Console.WriteLine("4-Hexágono");
                    Console.WriteLine("5-Sair");

                    int escolha = Convert.ToInt32(Console.ReadLine());

                    switch (escolha)
                    {
                        case 1:

                            Console.Write("Digite o raio da circunferência: ");

                            circunferencia.Raio = Convert.ToDouble(Console.ReadLine());

                            circunferencia.CalcularArea();
                            circunferencia.CalcularPerimetro();
                            break;

                        case 2:

                            Console.Write("Digite o tamanho do primeiro lado do triângulo: ");
                            triangulo.LadoA = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Digite o tamanho do segundo lado(base) do triângulo: ");
                            triangulo.LadoB = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Digite o tamanho do terceiro lado do triângulo: ");
                            triangulo.LadoC = Convert.ToDouble(Console.ReadLine());

                            triangulo.CalcularArea();
                            triangulo.CalcularPerimetro();
                            break;

                        case 3:

                            Console.Write("Digite o tamanho do lado do quadrado: ");
                            quadrado.Lado = Convert.ToDouble(Console.ReadLine());

                            quadrado.CalcularArea();
                            quadrado.CalcularPerimetro();
                            break;

                        case 4:

                            Console.Write("Digite o tamanho do lado do hexágono: ");
                            hexagono.Lado = Convert.ToDouble(Console.ReadLine());

                            hexagono.CalcularArea();
                            hexagono.CalcularPerimetro();
                            break;

                        case 5:
                            loop = false;

                            break;

                        default:
                            Console.WriteLine("Opção inválida");

                            break;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro: " + ex.Message);
                }
            }
        }

    }
}
