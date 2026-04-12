Algoritmo GA2_eje2casa
	Definir carac Como Caracter
	
	Escribir "Digite una tecla"
	Leer carac
	
	Segun carac Hacer
		"A","E","I","O","U","a","e","i","o","u":
			Escribir "El caracter  " , carac, "  es Vocal"
		"0","1","2","3","4","5","6","7","8","9":
			Escribir "El caracter ", carac, "es Digito"
		De Otro Modo:
			Escribir "El caracter no es ni digito ni vocal"
	Fin Segun
FinAlgoritmo
