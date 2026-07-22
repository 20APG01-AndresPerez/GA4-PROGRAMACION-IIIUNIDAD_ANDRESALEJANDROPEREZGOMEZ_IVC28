internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nombre: Andrés Pérez\n" +
            "IV Bachillerato C\n" +
            "Clave: 28");

        Console.WriteLine("Ingrese el precio del producto: ");
        int precio = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese la cantidad pagada por el cliente: ");
        int pago = Convert.ToInt32(Console.ReadLine());

        if (pago < precio)
        {
            Console.WriteLine("El pago es insuficiente.");
        }
        else
        {
            int cambio = pago - precio;

            Console.Clear();
            Console.WriteLine("Cambio total a entregar: " + cambio);

            int bille200 = cambio / 200;
            cambio = cambio % 200;

            int bille100 = cambio / 100;
            cambio = cambio % 100;

            int bille50 = cambio / 50;
            cambio = cambio % 50;

            int bille20 = cambio / 20;
            cambio = cambio % 20;

            int monedas = cambio;

            Console.WriteLine("Billetes de 200: " + bille200);
            Console.WriteLine("Billetes de 100: " + bille100);
            Console.WriteLine("Billetes de 50: " + bille50);
            Console.WriteLine("Billetes de 20: " + bille20);
            Console.WriteLine("Monedas restantes: " + monedas);
        }

        Console.WriteLine("\nPara salir presione una tecla");
        Console.ReadKey();
    }
}
