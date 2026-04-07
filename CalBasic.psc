Algoritmo CalBasic
	Definir opc Como Entero
	Definir num1, num2 Como Entero
	
	Escribir "**************************"
	Escribir "*   MENU DE OPCIONES  *"
	Escribir "**************************"
	Escribir "1- SUMA"
	Escribir "2- RESTA"
	Escribir "3- MULTIPLICACION"
	Escribir "4- DIVISION"
	Escribir sin saltar "Digite la opcion []: "
	Leer opc
	Escribir "Digite dos valores numericos"
	leer num1
	leer num2
	
	Segun opc Hacer
		1:
			Escribir "La suma es: ", (num1 +num2)
		2:
			Escribir "La resta es: ", (num1 -num2)
		3:
			Escribir "La multiplicacion es: ", (num1 * num2)
		4:
			Escribir "La division es: ", (num1 / num2)
		De Otro Modo:
			Escribir "Error al operar los numeros"
	Fin Segun
FinAlgoritmo
