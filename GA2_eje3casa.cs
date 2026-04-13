internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Entradas al estadio");

        int entradas, opc, total;

        Console.WriteLine("Digite la cantidad de entradas deseadas:");
        entradas = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("**** MENU DE OPCIONES ****");
        Console.WriteLine("1. PALCO = Q300.00");
        Console.WriteLine("2. TRIBUNA = Q125.00");
        Console.WriteLine("3. PREFERENCIA = Q100.00");
        Console.WriteLine("4. GENERAL = Q50.00");

        Console.Write("Digite la opcion que desea: ");
        opc = Convert.ToInt32(Console.ReadLine());

        switch (opc)
        {
            case 1:
                total = (entradas * 300);
                Console.WriteLine("Escogio Palco y su total será de: " + total);
                break;
            case 2:
                total = (entradas * 125);
                Console.WriteLine("Escogio Tribuna y su total será de: " + total);
                break;
            case 3:
                total = (entradas * 100);
                Console.WriteLine("Escogio Preferencia y su total será de: " + total);
                break;
            case 4:
                total = (entradas * 50);
                Console.WriteLine("Escogio General y su total será de: " + total);
                break;
            default:
                Console.WriteLine("Localidad Inexistente");
                break;
        }
    }
}