internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Convertidor de medidas");

        double medida, total;
        string opc;

        Console.WriteLine("Digite el numero de medida");
        medida= Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("a. Metros");
        Console.WriteLine("b. Pies");
        Console.WriteLine("c. Centimetros");
        Console.WriteLine("d. Pulgadas");
        Console.WriteLine("Digite la letra deseada: ");
        opc= Console.ReadLine();

        switch (opc)
        {
            case "a":
                total = (medida * 1);
                Console.WriteLine("La cantidad en metros es: "+ total);
                break;
            case "b":
                total = (medida * 3.281);
                Console.WriteLine("La cantidad en Pies es: " + total);
                break;
            case "c":
                total = (medida * 100);
                Console.WriteLine("La cantidad en metros es: " + total);
                break;
            case "d":
                total = (medida * 39.37008);
                Console.WriteLine("La cantidad en metros es: " + total);
                break;
            default:
                Console.WriteLine("Medida No disponible");
                break;
        }


    }
}