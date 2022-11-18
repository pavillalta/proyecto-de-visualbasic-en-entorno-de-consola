Module Ejercicio3
    Sub Main()

        MsgBox("Ejercicio 3, de un clic para ver en consola.")

        'Desarrolle ejercicio usando IF/ELSE

        'Declaracion de variables
        Dim monto, total As Double

        'En el caso se ingrese descuento
        'Dim descuento As Integer

        Console.WriteLine("Ingrese monto de compra:")
        monto = Console.ReadLine()

        'En el caso se modifique para ingresar descuento
        'Console.WriteLine("Ingrese descuento que se aplica(0/100%):")
        'descuento = Console.ReadLine()

        If monto >= 1000 Then
            total = monto - (monto * 0.3)
            Console.WriteLine("Monto de compra : {0:N2}", monto)
            Console.WriteLine("Descuento: 30%")
            Console.WriteLine("Monto a pagar: {0:N2}", total)
        ElseIf monto >= 500 And monto < 1000 Then
            total = monto - (monto * 0.2)
            Console.WriteLine("Monto de compra : {0:C2}", monto)
            Console.WriteLine("Descuento: 20%")
            Console.WriteLine("Monto a pagar : {0:C2}", total)
        ElseIf monto >= 250 And monto < 500 Then
            total = monto - (monto * 0.1)
            Console.WriteLine("Monto de compra :" & monto)
            Console.WriteLine("Descuento: 10%")
            Console.WriteLine("Monto a pagar: " & total)
        Else
            total = monto - (monto * 0.05)
            Console.WriteLine("Monto de compra :" & monto)
            Console.WriteLine("Descuento: 5%")
            Console.WriteLine("Monto a pagar: " & total)
        End If

        Console.ReadKey()

        'Desarrolle ejercicio usando Select Case

    End Sub

End Module
