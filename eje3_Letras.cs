internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("--LETRAS DEPENDIENDO LA NOTA--");
        Console.WriteLine("A= EXCELENTE");
        Console.WriteLine("B= BUENO");
        Console.WriteLine("C= REGULAR");
        Console.WriteLine("D= DEFICIENTE");
        Console.WriteLine("F= REPROBADO");

        string letra;

        Console.WriteLine("Digite una letra");
        letra = Console.ReadLine();

        switch (letra)
        {
            case "A":
                Console.WriteLine("Excelente");
                break;
            case "B":
                Console.WriteLine("Bueno");
                break;
            case "C":
                Console.WriteLine("Regular");
                break;
            case "D":
                Console.WriteLine("Deficiente");
                break;
            case "F":
                Console.WriteLine("Reprobado");
                break;
            default:
                Console.WriteLine("Error en la letra");
                break;
        }
    }
}