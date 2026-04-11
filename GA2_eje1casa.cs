internal     class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("* CALCULADORA FUNCIONES TRIGONOMETRICAS BASICAS");
        Console.WriteLine("***********************************************");
        Console.WriteLine("* Lista de funciones trigonometricas          *");
        Console.WriteLine("* 1- Seno                                   *");
        Console.WriteLine("* 2- Coseno                                 *");
        Console.WriteLine("* 3- Tangente                               *");
        Console.WriteLine("***********************************************");

        int opc;
        double grados;
        double radianes;
        double resultado = 0;


        Console.WriteLine("Digite la opcion del 1-3: ");
        opc= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite la cantidad de grados: ");
        grados = double.Parse(Console.ReadLine());

        radianes = grados * (Math.PI / 180.0);

        switch (opc)
        {
            case 1:
                resultado = Math.Sin(radianes);
                Console.WriteLine("El seno de" + (grados) + "es"  +(resultado)) ;
                break;
            case 2:
                resultado = Math.Cos(radianes);
                Console.WriteLine("El Coseno de " +(grados)+ "es" + (resultado));
                break;
            case 3:
                resultado = Math.Tan(radianes);
                Console.WriteLine("La tangente de " + (grados) + "es" + (resultado));
                break;
            default:
                Console.WriteLine("Opcion invalida");
                break;
        }
    }
}