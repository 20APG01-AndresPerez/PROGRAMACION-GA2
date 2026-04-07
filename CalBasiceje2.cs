internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("*********************");
        Console.WriteLine("* MENU DE OPCIONES *");
        Console.WriteLine("*********************");
        int opc;
        int num1;
        int num2;

        Console.WriteLine("Digite un numero del 1 al 4");
        opc= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite dos valores numericos");
        num1 = Convert.ToInt32(Console.ReadLine());
        num2 = Convert.ToInt32(Console.ReadLine());

        switch (opc)
        {
            case 1:
                Console.WriteLine("Escribir la suma es: "+(num1+num2));
                break;
            case 2:
                Console.WriteLine("Escribir la resta es: " + (num1 - num2));
                break;
            case 3:
                Console.WriteLine("Escribir la Multiplicacion es: " + (num1 * num2));
                break;
            case 4:
                Console.WriteLine("Escribir la Division es: " + (num1 / num2));
                break;
            default:
                Console.WriteLine("Error al operar numeros");
                break;
        }
    }
}