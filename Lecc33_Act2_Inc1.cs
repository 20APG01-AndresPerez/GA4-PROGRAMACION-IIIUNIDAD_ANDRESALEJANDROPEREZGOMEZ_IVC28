internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nombre: Andrés Pérez\n" +
            "IV Bachillerato C\n" +
            "Clave: 28");

        Console.WriteLine("Dame una frase: ");
        string frase = Console.ReadLine();

        string fraseInver = "";

        for (int i = frase.Length - 1; i >= 0; i--)
        {
            fraseInver = fraseInver + frase[i];
        }

        Console.Clear();
        Console.WriteLine("Frase original: " + frase);
        Console.WriteLine("Frase al revés: " + fraseInver);

        Console.WriteLine("\nPara salir presione una tecla");
        Console.ReadKey();
    }
}
