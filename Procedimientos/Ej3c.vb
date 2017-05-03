Module Ej3c
    Sub main()
        Console.WriteLine("Ingrese un numero")
        Dim numero As Integer = Console.ReadLine()

        For potencia = 2 To 6
            Console.WriteLine("{0}^{1} = " & calculo(numero, potencia), numero, potencia)
        Next
        Console.ReadKey()
    End Sub

    Function calculo(dato As Integer, potencia As Byte) As Integer
        Return dato ^ potencia
    End Function


End Module
