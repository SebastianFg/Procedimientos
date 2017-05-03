Module Ej3e
    Sub main()
        Dim base, altura, resultado As Single

        Do
            Console.WriteLine("Ingrese Base")
            base = Console.ReadLine()
        Loop While Control(base) = 0
        Do
            Console.WriteLine("Ingrese Altura")
            altura = Console.ReadLine()
        Loop While Control(altura) = 0

        resultado = calculo(base, altura)

        Console.WriteLine("El radio es de: " & resultado)
        Console.ReadKey()
    End Sub

    Function calculo(numero1 As Single, numero2 As Single) As Single
        Return Math.PI * (numero1 ^ 2) * numero2
    End Function


    Function Control(numero) As Boolean
        Return numero > 0
    End Function


    '003345
End Module
