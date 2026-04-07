Algoritmo eje3_Letras
	Definir letra Como Caracter
	
	//Solicitar al usuario
	Escribir Sin Saltar "Dame una letra"
	Leer letra 
	
	Segun letra Hacer
		"A":
			Escribir "Excelente"
		"B":
			Escribir "Bueno"
		"C":
			Escribir "Regular"
		"D":
			Escribir "Deficiente"
		"F":
			Escribir "Reprobado"
		De Otro Modo:
			Escribir "Error en la letra"
	Fin Segun
FinAlgoritmo