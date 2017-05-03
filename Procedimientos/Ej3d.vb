Module Ej3d

    Sub main()
        Dim ladoA, ladoB, hipotenusa As Single

        Do
            Console.WriteLine("Ingrese lado A")
            ladoA = Console.ReadLine()
        Loop While consistencia(ladoA) = 0

        Do
            Console.WriteLine("Ingrese lado B")
            ladoB = Console.ReadLine()
        Loop While consistencia(ladoB) = 0

        hipotenusa = calculo_hipotenusa(ladoA, ladoB)

        Console.WriteLine("La hipotenusa es: " & hipotenusa)
        Console.ReadKey()
    End Sub

    Public Function consistencia(dato As Single) As Integer
        Return dato = Int(dato) And dato > 0
    End Function

    Public Function calculo_hipotenusa(ladoA As Integer, ladoB As Integer) As Single
        Return Math.Sqrt(ladoA ^ 2 + ladoB ^ 2)
    End Function

End Module
