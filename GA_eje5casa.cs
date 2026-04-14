public class Program
{
    private static void Main(string[] args)
    {
        int cantidad;
        int opcionPago;
        double precioSinIva, precioConIva, totalSinDescuento;
        double descuentoPorcentaje, montoDescuento, totalAPagar;

        precioSinIva = 650.00;

        Console.WriteLine("Ingrese la cantidad de impresores a comprar:");
        cantidad = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Seleccione la forma de pago (1:Efectivo, 2:Tarjeta, 3:Vale):");
        opcionPago = Convert.ToInt32(Console.ReadLine());

        precioConIva = precioSinIva * 1.12;
        totalSinDescuento = precioConIva * cantidad;

        switch (opcionPago)
        {
            case 1:
                descuentoPorcentaje = 0.10;
                montoDescuento = totalSinDescuento * descuentoPorcentaje;
                totalAPagar = totalSinDescuento - montoDescuento;
                Console.WriteLine("El precio con IVA es de: " + precioConIva);
                Console.WriteLine("El total sin descuento es de: " + totalSinDescuento);
                Console.WriteLine("Esta pagando con efectivo; el total es de Q" + totalAPagar);
                break;

            case 2:
                descuentoPorcentaje = 0.05;
                montoDescuento = totalSinDescuento * descuentoPorcentaje;
                totalAPagar = totalSinDescuento - montoDescuento;
                Console.WriteLine("El precio con IVA es de: " + precioConIva);
                Console.WriteLine("El total sin descuento es de: " + totalSinDescuento);
                Console.WriteLine("Esta pagando con tarjeta; el total es de Q" + totalAPagar);
                break;

            case 3:
                descuentoPorcentaje = 0.15;
                montoDescuento = totalSinDescuento * descuentoPorcentaje;
                totalAPagar = totalSinDescuento - montoDescuento;
                Console.WriteLine("El precio con IVA es de: " + precioConIva);
                Console.WriteLine("El total sin descuento es de: " + totalSinDescuento);
                Console.WriteLine("Esta pagando con vale; el total es de Q" + totalAPagar);
                break;

            default:
                descuentoPorcentaje = 0;
                totalAPagar = totalSinDescuento;
                Console.WriteLine("El precio con IVA es de: " + precioConIva);
                Console.WriteLine("El total sin descuento es de: " + totalSinDescuento);
                Console.WriteLine("No tiene descuento; el total es de Q" + totalAPagar);
                break;
        }
    }
}