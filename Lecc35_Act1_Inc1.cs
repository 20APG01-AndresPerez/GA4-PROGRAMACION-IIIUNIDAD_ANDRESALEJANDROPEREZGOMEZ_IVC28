internal class Program
{
    private static void Main(string[] args)
    {
        string respuesta = "s";

        while (respuesta == "s" || respuesta == "S")
        {
            Console.Clear();
            Console.WriteLine("Nombre: Andrés Pérez\n" +
                "IV Bachillerato C\n" +
                "Clave: 28");

            Console.WriteLine("Dame la cantidad en moneda local (Quetzales): ");
            double quetzales = double.Parse(Console.ReadLine());

            Console.WriteLine("\n--- EQUIVALENCIAS ---");
            Console.WriteLine("Dólares " + (quetzales / 7.8));
            Console.WriteLine("Euros: " + (quetzales / 8.5));
            Console.WriteLine("Pesos Mexicanos " + (quetzales * 2.2));
            Console.WriteLine("Yenes Japoneses " + (quetzales * 19.5));
            Console.WriteLine("Libras Esterlinas " + (quetzales / 10.0));

            Console.WriteLine("\n¿Desea convertir otra cantidad? ");
            respuesta = Console.ReadLine();
        }

        Console.WriteLine("\nPara salir presione una tecla");
        Console.ReadKey();
    }
}
