Module Ej3b
    Sub main()
        Console.WriteLine("Ingrese fecha")
        Dim fecha_actual As Date = Console.ReadLine()

        Console.WriteLine("Ingrese cantidad de dias a agregar")
        Dim dias As UShort = Console.ReadLine()

        fecha_actual = calculo(fecha_actual, dias)

        Console.WriteLine("Dias agregados: " & dias & " Fecha Nueva: " & fecha_actual)

        Console.ReadKey()
    End Sub

    Function calculo(fecha_actual As Date, dias As Integer) As Date
        Return fecha_actual.AddDays(dias)
    End Function
End Module
