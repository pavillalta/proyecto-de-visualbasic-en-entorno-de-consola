
Module Ejercicio10
    Sub Main()

        'Declaracion de arreglos
        Dim nombres(2) As String
        Dim horas(2) As Integer
        Dim salariohora(2) As Double
        Dim contador = 0
        'Dim cantidad_empleados As Integer

        'En el caso se quiera ingresar cantidad de empleados
        'Console.WriteLine("Cantidad de empleados: ")
        'cantidad_empleados = Console.ReadLine()

        'Ciclo para llenar arreglos
        While contador < 2
            'While contador < cantidad_empleados

            Console.WriteLine("======= Datos de casilla {0} =======", contador)
            Console.WriteLine("====================================")

            Console.WriteLine("Nombre empleado {0}:  ", contador)
            nombres(contador) = Console.ReadLine()

            Console.WriteLine("Horas trabajadas por empleado {0}: ", contador)
            horas(contador) = Console.ReadLine()

            Console.WriteLine("Salario por hora del empleado {0}: ", contador)
            salariohora(contador) = Console.ReadLine()

            Console.WriteLine("=================================")

            contador = contador + 1

        End While


        'Iniciamos de nuevo el contador para mostrar arreglos
        contador = 0

        'Ciclo para mostrar datos de arreglos
        Console.WriteLine("====== Datos de los empleados ======")
        Console.WriteLine("====================================")

        While contador < 2
            Console.WriteLine("Empleado {0}", contador)
            Console.WriteLine("Nombre          : {0}", nombres(contador))
            Console.WriteLine("Horas trabajadas: {0}", horas(contador))
            Console.WriteLine("Salario por hora: {0}", salariohora(contador))
            Console.WriteLine("Salario Empleado: {0}", horas(contador) * salariohora(contador))
            contador = contador + 1
            Console.WriteLine("=================================")
        End While


        'Iniciamos de nuevo el contador para mostrar arreglos
        contador = 0

        'Tercer ciclo para mostrar arreglos un poco mas en orden
        'Para tabular use Space(5) donde 5 es la cantidad de espacios
        Console.WriteLine("'\n'\n")
        Console.WriteLine("====== Datos de los empleados ======")
        Console.WriteLine("====================================")

        Console.WriteLine("Casilla[N]" + Space(5) + "Nombre" + Space(5) + "Horas" + Space(5) + "PagoHora" + Space(5) + "Salario")

        While contador < 2
            'Observe que puede enviar a pantalla varias variables usando {0}
            'Para varios valores puede usar {1} {2} {3} {4}... {n}
            Console.WriteLine("Casilla[{0}]" + Space(5) + "{1}" + Space(5) + "{2}" + Space(5) + "{3}" + Space(5) + "{4}", contador, nombres(contador), horas(contador), salariohora(contador), horas(contador) * salariohora(contador))
            contador = contador + 1
        End While

        'Congelar pantalla hasta dar un enter
        Console.ReadKey()

    End Sub

End Module
