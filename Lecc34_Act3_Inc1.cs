internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nombre: Andrés Pérez\n" +
            "IV Bachillerato C\n" +
            "Clave: 28");

        double celsius, resultado;

        Console.WriteLine("Dame la temperatura en grados Centígrados: ");
        celsius = double.Parse(Console.ReadLine());

        Console.WriteLine("--------Menu Principal----------");
        Console.WriteLine("1- Fahrenheit\n" +
            "2- Celsius\n" +
            "3- Kelvin\n" +
            "Seleccionar una opcion []:");
        int opc = Convert.ToInt32(Console.ReadLine());

        switch (opc)
        {
            case 1:
                Console.Clear();
                Console.WriteLine("CONVERSIÓN A FAHRENHEIT");
                resultado = (celsius * 9 / 5) + 32;
                Console.WriteLine(celsius + " °C son " + resultado + " °F");
                break;

            case 2:
                Console.Clear();
                Console.WriteLine("CONVERSIÓN A CELSIUS");
                Console.WriteLine(celsius + " °C son " + celsius + " °C");
                break;

            case 3:
                Console.Clear();
                Console.WriteLine("CONVERSIÓN A KELVIN");
                resultado = celsius + 273.15;
                Console.WriteLine(celsius + " °C son " + resultado + " K");
                break;

            default:
                Console.WriteLine("Opción inválida");
                break;
        }

        Console.WriteLine("\nPara salir presione una tecla");
        Console.ReadKey();
    }
}
