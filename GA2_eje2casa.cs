internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Analizando si es vocal o digito");

        string carac;

        Console.WriteLine("Digite algo:");
        carac=Console.ReadLine();

        switch (carac)
        {
            case "a":
            case "e":
            case "i":
            case "o":
            case "u":
            case "A":
            case "E":
            case "I":
            case "O":
            case "U":
                Console.WriteLine("El caracter es Vocal");
                break;
            case "0":
            case "1":
            case "2":
            case "3":
            case "4":
            case "5":
            case "6":
            case "7":
            case "8":
            case "9":
                Console.WriteLine("El caracter es Digito");
                break;
            default:
                Console.WriteLine("Opcion invalida");
                break;
        }

    }
}