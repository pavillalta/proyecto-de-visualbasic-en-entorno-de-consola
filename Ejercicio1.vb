Module Ejercicio1
    Sub Main()
        MsgBox("Ejercicio 1, de un clic para ver en consola.")

        Dim edad As Integer
        Console.WriteLine("Ingresar su edad:")
        edad = Console.ReadLine()

        If edad > 18 Then
            Console.WriteLine("Es mayor de edad, puede ir de fiesta")
        Else
            Console.WriteLine("Meor de edad, usted no puede salir")
        End If

        Console.ReadKey()

    End Sub

    'Realice ejercicio usando funciones
    Function edad(ByVal e As Integer)

    End Function

End Module
