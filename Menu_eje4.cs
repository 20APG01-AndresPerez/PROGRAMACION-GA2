internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Menu de Opciones");
        Console.WriteLine("1- Hamburguesa");
        Console.WriteLine("2- Pizza");
        Console.WriteLine("3- Pollo Frito");
        Console.WriteLine("4- Ensalada");

        int opc;

        Console.WriteLine("Digite un numero del 1 al 4");
        opc = Convert.ToInt32(Console.ReadLine());

        switch (opc)
        {
            case 1:
                Console.WriteLine("Hamburguesa");
                break;
            case 2:
                Console.WriteLine("Pizza");
                break;
            case 3:
                Console.WriteLine("Pollo Frito");
                break;
            case 4:
                Console.WriteLine("Ensalada");
                break;
            default:
                Console.WriteLine("Opcion invalida");
                break;
        }
    }
}