Module Ej3a


    Public Sub impresion(x)
        Console.WriteLine(x)
    End Sub


    Public Function hora_impresion()
        Return TimeOfDay
    End Function

    Sub Main()
        Dim fecha_actual As Date = Date.Now

        impresion("Fecha " & fecha_actual.Date)

        Console.WriteLine("Hora " & hora_impresion())
        Console.ReadKey()
    End Sub

End Module
