Algoritmo GA2_eje3casa
	Definir entradas, opc, total Como Entero
	Escribir "Digite la cantidad de entradas deseadas"
	Leer entradas
	
	Escribir "**** MENU DE OPCIONES ****"
	Escribir "1. PALCO = Q300.00"
	Escribir "2. TRIBUNA = Q125.00"
	Escribir "3. PREFERENCIA = Q100.00"
	Escribir "4. GENERAL = Q50.00"
	
	Escribir "Digite la opcion que desea: "
	Leer opc
	
	
	Segun opc Hacer
		1:
			total= (entradas*300)
			Escribir "Escogio Palco, su total será de: Q", total
		2:
			total= (entradas*125)
			Escribir "Escogio Tribuna, su total será de: Q", total
		3:
			total= (entradas*100)
			Escribir "Escogio Preferencia, su total será de: Q", total
		4:
			total= (entradas*50)
			Escribir "Escogio General, su total será de: Q", total
		De Otro Modo:
			Escribir "Localidad Inexistente"
	Fin Segun
FinAlgoritmo
