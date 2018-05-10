Module case2_6
    Sub main()
        Dim cant As UShort
        Dim precio_uni As Single
        Dim subtotal As Single

        Console.Write("Ingrese cantidad: ")
        cant = Console.ReadLine()

        Console.Write("Ingrese precio unitario: ")
        precio_uni = Console.ReadLine()

        subtotal = cant * precio_uni

        Select Case cant
            Case 10 To 50
                Console.WriteLine("Subtotal: " & subtotal)
                Console.WriteLine("% de descuentoaplicado: 5%")
                Console.WriteLine("Monto descontado: " & subtotal * 0.05)
                Console.WriteLine("Total: " & subtotal - subtotal * 0.05)
            Case 51 To 250
                Console.WriteLine("Subtotal: " & subtotal)
                Console.WriteLine("% de descuentoaplicado: 10%")
                Console.WriteLine("Monto descontado: " & subtotal * 0.1)
                Console.WriteLine("Total: " & subtotal - subtotal * 0.1)
            Case Is > 205
                Console.WriteLine("Subtotal: " & subtotal)
                Console.WriteLine("% de descuentoaplicado: 20%")
                Console.WriteLine("Monto descontado: " & subtotal * 0.2)
                Console.WriteLine("Total: " & subtotal - subtotal * 0.2)
            Case Is < 10
                Console.WriteLine("cantidad invalida")
        End Select

        Console.ReadKey()
    End Sub
End Module
