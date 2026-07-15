      internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nombre: Andrés Pérez\n" +
            "IV Bachillerato C\n" +
            "Clave: 28");

        double metros, resultado;
        Console.WriteLine("Dame una medida en metros: ");
        metros= double.Parse(Console.ReadLine());

        Console.WriteLine("--------Menu Principal----------");
        Console.WriteLine("1- Milimetros\n" +
            "2-Centímetros\n" +
            "3-Decímetros\n" +
            "4-Hectómetros\n" +
            "5-Kilómetros \n" +
            "6-Salir\n" +
            "Seleccionar una opcion []:");
        int opc=Convert.ToInt32(Console.ReadLine());

        switch (opc)
        {
            case 1:
                Console.Clear();
                Console.WriteLine("CONVERSIÓN A MILÍMETROS");
                resultado = metros * 1000;
                Console.WriteLine(metros+" metros son "+ resultado+" milimetros");
                break;
            case 2:
                Console.Clear();
                Console.WriteLine("CONVERSIÓN A CENTÍMETROS");
                resultado = metros * 100;
                Console.WriteLine(metros + " metros son " + resultado + " centímetros");
                break;
            case 3:
                Console.Clear();
                Console.WriteLine("CONVERSIÓN A DECÍMETROS");
                resultado = metros * 10;
                Console.WriteLine(metros + " metros son " + resultado + " decímetros");
                break;
            case 4:
                Console.Clear();
                Console.WriteLine("CONVERSIÓN A HECTÓMETROS");
                resultado = metros / 100;
                Console.WriteLine(metros + " metros son " + resultado + " hectómetros");
                break;
            case 5:
                Console.Clear();
                Console.WriteLine("CONVERSIÓN A KILÓMETROS");
                resultado = metros * 1000;
                Console.WriteLine(metros + " metros son " + resultado + " kilómetros");
                break;
            case 6:
                Console.Clear();
                Console.WriteLine("Para salir presione una tecla");
                Console.ReadKey();
                break;
            default:
                Console.WriteLine("Opción inválida ");
                break;
        }
    }
}
