internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nombre: Andrés Pérez\nIV Bachillerato C\nClave: 28\n");

        Console.WriteLine("1- Decimal a Binario");
        Console.WriteLine("2- Binario a Decimal");
        Console.Write("Opción: ");
        int opc = Convert.ToInt32(Console.ReadLine());

        if (opc == 1)
        {
            Console.Write("Dame un número decimal: ");
            int num = Convert.ToInt32(Console.ReadLine());
            
            string binario = Convert.ToString(num, 2);
            Console.WriteLine("En binario es: " + binario);
        }
        else if (opc == 2)
        {
            Console.Write("Dame un número binario: ");
            string binario = Console.ReadLine();

            int decimalResultado = 0;
            int posicion = 1;

            for (int i = binario.Length - 1; i >= 0; i--)
            {
                if (binario[i] == '1')
                {
                    decimalResultado = decimalResultado + posicion;
                }
                posicion = posicion * 2;
            }

            Console.WriteLine("En decimal es: " + decimalResultado);
        }
        else
        {
            Console.WriteLine("Opción inválida");
        }

        Console.ReadKey();
    }
}
