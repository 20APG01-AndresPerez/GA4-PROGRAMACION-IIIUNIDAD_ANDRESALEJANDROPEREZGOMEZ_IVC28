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

            Console.WriteLine("-------- JUEGO ----------");
            Console.WriteLine("1- Piedra");
            Console.WriteLine("2- Papel");
            Console.WriteLine("3- Tijeras");
            Console.WriteLine("Selecciona una opción []: ");
            int usuario = Convert.ToInt32(Console.ReadLine());

            int computadora = 1;

            Console.Clear();
            Console.WriteLine("Tú elegiste opción: " + usuario);
            Console.WriteLine("Computadora eligió opción: " + computadora);

            if (usuario == computadora)
            {
                Console.WriteLine("\n¡Empate!");
            }
            else if ((usuario == 1 && computadora == 3) ||
                     (usuario == 2 && computadora == 1) ||
                     (usuario == 3 && computadora == 2))
            {
                Console.WriteLine("\n¡Ganaste tú!");
            }
            else
            {
                Console.WriteLine("\nGana la computadora.");
            }

            Console.WriteLine("\n¿Deseas jugar de nuevo? (s/n): ");
            respuesta = Console.ReadLine();
        }

        Console.WriteLine("\nPara salir presione una tecla");
        Console.ReadKey();
    }
}
