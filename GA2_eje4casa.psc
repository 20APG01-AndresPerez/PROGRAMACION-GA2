Algoritmo GA2_eje4casa
	Definir medida, total Como Real
	Definir opc como caracter
	
	Escribir "Digite el numero de la medida"
	Leer medida
	Escribir "a. Metros "
	Escribir "b. Pies"
	Escribir "c. Centímetros"
	Escribir "d. Pulgadas"
	Leer opc
	
	Segun opc Hacer
		"a":
			total= (medida*1)
			Escribir "La medida en m es: ", total
		"b":
			total =(medida*3.281)
			Escribir "La medida en pies es:  ", total
		"c":
			total =(medida*100)
			Escribir "La medida en centímetros es: ", total
		"d":
			total = (medida *39.37008)
			Escribir "La medida en pulgadas es: ", total
		De Otro Modo:
			Escribir "Medida no disponible"
	Fin Segun
	
FinAlgoritmo
