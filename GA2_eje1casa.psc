Algoritmo GA2_eje1casa
	Definir opc como Entero
	Definir grados, radianes como Real
	Escribir "    * CALCULADORA FUNCIONES TRIGONOMETRICAS BASICAS"
    Escribir "    ***********************************************"
    Escribir "    * Lista de funciones trigonometricas          *"
    Escribir "    * 1- Seno                                   *"
    Escribir "    * 2- Coseno                                 *"
    Escribir "    * 3- Tangente                               *"
    Escribir "    ***********************************************"
	
	Escribir "Digite la opción del 1-3: "
	Leer opc
	Escribir "Ingrese el angulo en grados"
	Leer grados
	
	radianes = (grados)*(Pi/180)
	
	Segun opc Hacer
		1:
			resultado = Sen(radianes)
			Escribir "El seno de " ,grados, "es" ,  resultado
		2:
			resultado = Cos(radianes)
			Escribir "El coseno de " ,grados, "es"  ,resultado 
		3:
			Escribir "La Tangente de "  ,grados,  "es"   ,resultados
		De Otro Modo:
			Escribir"Opcion invalida"
	Fin Segun
FinAlgoritmo
