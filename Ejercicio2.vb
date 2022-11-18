Module Ejercicio2
    Sub Main()

        MsgBox("Ejercicio 2, de un clic para ver en consola.")

        Dim numero As Double
        Console.WriteLine("Ingrese un numero:")
        numero = Console.ReadLine()

        If numero > 0 Then
            Console.WriteLine("Ese numero es positivo")
        ElseIf numero = 0 Then
            Console.WriteLine("Ese numero es cero")
        Else
            Console.WriteLine("Ese numero es negativo")
        End If

        Console.ReadKey()

        'Modifique para identificar si el numero es cero

    End Sub

End Module
