internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nombre: Andrés Pérez\n" +
            "IV Bachillerato C\n" +
            "Clave: 28");

        string[] nombres = new string[10];
        string[] telefonos = new string[10];

        Console.WriteLine("--- REGISTRO DE CONTACTOS ---");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Ingrese el nombre " + (i + 1) + ": ");
            nombres[i] = Console.ReadLine();

            Console.WriteLine("Ingrese el teléfono " + (i + 1) + ": ");
            telefonos[i] = Console.ReadLine();
        }

        Console.Clear();
        Console.WriteLine("Dame el número de posición que quieres consultar (1 al 10): ");
        int posicion = Convert.ToInt32(Console.ReadLine());

        int indice = posicion - 1;
        Console.WriteLine("Contacto en la posición " + posicion + ":");
        Console.WriteLine("Nombre: " + nombres[indice]);
        Console.WriteLine("Teléfono: " + telefonos[indice]);

        Console.WriteLine("\nPara salir presione una tecla");
        Console.ReadKey();
    }
}
