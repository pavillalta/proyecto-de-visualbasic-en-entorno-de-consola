Module Ejercicio5
    Sub Main()
        MsgBox("Ejercicio 5, de un clic para ver en consola.")
        Console.WriteLine("Ejercicio 5: Muestra la suma de los números naturales desde 1 hasta n. Ejemplo: 1+2+3+4+5=15")

        'Declaracion de variables
        Dim contador = 1, numero, suma As Double

        'Inbgrese numero limite
        Console.WriteLine("Ingrese hasta que numero se realizara la suma:")
        numero = Console.ReadLine()

        'Es necesario inicializar la variable suma
        suma = 0

        While contador <= numero
            suma = suma + contador
            contador = contador + 1
        End While

        Console.WriteLine("La suma de los numeros del 1 al {0} es:{1}", numero, suma)
        Console.ReadKey()

    End Sub

End Module
