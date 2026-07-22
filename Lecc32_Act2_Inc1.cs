internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nombre: Andrés Pérez\n" +
            "IV Bachillerato C\n" +
            "Clave: 28");

        Console.WriteLine("Dame tu día de nacimiento: ");
        int dia = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Dame tu mes de nacimiento (1-12): ");
        int mes = Convert.ToInt32(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("-------- MI HORÓSCOPO ----------");

        switch (mes)
        {
            case 1:
                if (dia <= 19)
                {
                    Console.WriteLine("Signo: Capricornio");
                }
                else
                {
                    Console.WriteLine("Signo: Acuario");
                }
                Console.WriteLine("Horóscopo: Tendrás un día lleno de buenas noticias.");
                break;

            case 2:
                if (dia <= 18)
                {
                    Console.WriteLine("Signo: Acuario");
                }
                else
                {
                    Console.WriteLine("Signo: Piscis");
                }
                Console.WriteLine("Horóscopo: Es un buen día para descansar.");
                break;

            case 3:
                if (dia <= 20)
                {
                    Console.WriteLine("Signo: Piscis");
                }
                else
                {
                    Console.WriteLine("Signo: Aries");
                }
                Console.WriteLine("Horóscopo: Lograrás tus objetivos escolares.");
                break;

            case 4:
                if (dia <= 19)
                {
                    Console.WriteLine("Signo: Aries");
                }
                else
                {
                    Console.WriteLine("Signo: Tauro");
                }
                Console.WriteLine("Horóscopo: Mantén la calma ante cualquier problema.");
                break;

            case 5:
                if (dia <= 20)
                {
                    Console.WriteLine("Signo: Tauro");
                }
                else
                {
                    Console.WriteLine("Signo: Géminis");
                }
                Console.WriteLine("Horóscopo: Buen momento para convivir con amigos.");
                break;

            case 6:
                if (dia <= 20)
                {
                    Console.WriteLine("Signo: Géminis");
                }
                else
                {
                    Console.WriteLine("Signo: Cáncer");
                }
                Console.WriteLine("Horóscopo: Tu creatividad estará al máximo.");
                break;

            case 7:
                if (dia <= 22)
                {
                    Console.WriteLine("Signo: Cáncer");
                }
                else
                {
                    Console.WriteLine("Signo: Leo");
                }
                Console.WriteLine("Horóscopo: Recibirás una grata sorpresa.");
                break;

            case 8:
                if (dia <= 22)
                {
                    Console.WriteLine("Signo: Leo");
                }
                else
                {
                    Console.WriteLine("Signo: Virgo");
                }
                Console.WriteLine("Horóscopo: Sigue trabajando duro por tus sueños.");
                break;

            case 9:
                if (dia <= 22)
                {
                    Console.WriteLine("Signo: Virgo");
                }
                else
                {
                    Console.WriteLine("Signo: Libra");
                }
                Console.WriteLine("Horóscopo: Todo saldrá bien hoy.");
                break;

            case 10:
                if (dia <= 22)
                {
                    Console.WriteLine("Signo: Libra");
                }
                else
                {
                    Console.WriteLine("Signo: Escorpio");
                }
                Console.WriteLine("Horóscopo: Buen día para aprender cosas nuevas.");
                break;

            case 11:
                if (dia <= 21)
                {
                    Console.WriteLine("Signo: Escorpio");
                }
                else
                {
                    Console.WriteLine("Signo: Sagitario");
                }
                Console.WriteLine("Horóscopo: Confía más en tus capacidades.");
                break;

            case 12:
                if (dia <= 21)
                {
                    Console.WriteLine("Signo: Sagitario");
                }
                else
                {
                    Console.WriteLine("Signo: Capricornio");
                }
                Console.WriteLine("Horóscopo: Disfruta el tiempo en familia.");
                break;

            default:
                Console.WriteLine("Mes no válido");
                break;
        }

        Console.WriteLine("\nPara salir presione una tecla");
        Console.ReadKey();
    }
}
