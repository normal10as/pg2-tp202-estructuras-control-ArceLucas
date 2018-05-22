Module case2_6
    Sub main()
        Dim cant As UShort
        Dim precio_uni As Single
        Dim subtotal As Single
        Dim porcentajeDesc As Byte

        Console.Write("Ingrese cantidad: ")
        cant = Console.ReadLine()

        Console.Write("Ingrese precio unitario: ")
        precio_uni = Console.ReadLine()

        subtotal = cant * precio_uni

        Select Case cant
            Case Is < 10
                porcentajeDesc = 0
            Case 10 To 50
                porcentajeDesc = 5
            Case 51 To 250
                porcentajeDesc = 10
            Case Is > 205
                porcentajeDesc = 20
        End Select

        Console.WriteLine("Subtotal: " & subtotal)
        Console.WriteLine("% de descuentoaplicado: {0}%", porcentajeDesc)
        Console.WriteLine("Monto descontado: " & subtotal * porcentajeDesc / 100)
        Console.WriteLine("Total: " & subtotal - subtotal * porcentajeDesc / 100)

        Console.ReadKey()

    End Sub
End Module
