internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nombre: Andrés Pérez\n" +
            "IV Bachillerato C\n" +
            "Clave: 28");

        double peso, altura, imc;

        Console.WriteLine("Dame el peso en kilogramos: ");
        peso = double.Parse(Console.ReadLine());

        Console.WriteLine("Dame la altura en metros (ejemplo 1.70): ");
        altura = double.Parse(Console.ReadLine());

        imc = peso / (altura * altura);

        Console.Clear();
        Console.WriteLine("------CÁLCULO DE IMC------");
        Console.WriteLine("Tu IMC es: " + imc);

        if (imc < 18.5)
        {
            Console.WriteLine("Resultado: Bajo peso");
        }
        else if (imc < 25)
        {
            Console.WriteLine("Resultado: Peso normal");
        }
        else if (imc < 30)
        {
            Console.WriteLine("Resultado: Sobrepeso");
        }
        else
        {
            Console.WriteLine("Resultado: Obesidad");
        }

        Console.WriteLine("\nPara salir presione una tecla");
        Console.ReadKey();
    }
}
