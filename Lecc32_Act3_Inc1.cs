internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nombre: Andrés Pérez\n" +
            "IV Bachillerato C\n" +
            "Clave: 28");

        double lado1, lado2, lado3;

        Console.WriteLine("Dame la medida del lado 1: ");
        lado1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Dame la medida del lado 2: ");
        lado2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Dame la medida del lado 3: ");
        lado3 = double.Parse(Console.ReadLine());

        Console.Clear();

        if (lado1 == lado2 && lado2 == lado3)
        {
            Console.WriteLine("El triángulo es EQUILÁTERO.");
        }
        else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
        {
            Console.WriteLine("El triángulo es ISÓSCELES.");
        }
        else
        {
            Console.WriteLine("El triángulo es ESCALENO .");
        }

        Console.WriteLine("\nPara salir presione una tecla");
        Console.ReadKey();
    }
}
