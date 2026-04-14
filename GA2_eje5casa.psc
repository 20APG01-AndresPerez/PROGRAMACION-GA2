Algoritmo GA2_eje5casa
	Definir cantidad Como Entero
	Definir opcionPago Como Entero
	Definir precioSinIva, precioConIva, totalSinDescuento Como Real
	Definir descuentoPorcentaje, montoDescuento, totalAPagar Como Real
	precioSinIva = 650.00
	Escribir "Ingrese la cantidad de impresores a comprar:"
	Leer cantidad
	
	Escribir "Seleccione la forma de pago (1:Efectivo, 2:Tarjeta, 3:Vale):"
	Leer opcionPago
	
	Segun opcionPago Hacer
		1:
			descuentoPorcentaje = 0.10
			precioConIva = precioSinIva * 1.12
			totalSinDescuento = precioConIva * cantidad
			montoDescuento = totalSinDescuento * descuentoPorcentaje
			totalAPagar = totalSinDescuento - montoDescuento
			
			Escribir "Esta pagando con efectivo; el total es de ", totalAPagar
		2:
			descuentoPorcentaje = 0.05
			precioConIva = precioSinIva * 1.12
			totalSinDescuento = precioConIva * cantidad
			montoDescuento = totalSinDescuento * descuentoPorcentaje
			totalAPagar = totalSinDescuento - montoDescuento
			
			Escribir "Esta pagando con tarjeta; el total es de ", totalAPagar
		3:
			descuentoPorcentaje = 0.15
			precioConIva = precioSinIva * 1.12
			totalSinDescuento = precioConIva * cantidad
			montoDescuento = totalSinDescuento * descuentoPorcentaje
			totalAPagar = totalSinDescuento - montoDescuento
			Escribir "Esta pagando con vale; el total es de ", totalAPagar
			
		De Otro Modo:
			descuentoPorcentaje = 0
			precioConIva = precioSinIva * 1.12
			totalSinDescuento = precioConIva * cantidad
			Escribir "No tiene descuento; el total es de ", totalAPagar
	Fin Segun
FinAlgoritmo
