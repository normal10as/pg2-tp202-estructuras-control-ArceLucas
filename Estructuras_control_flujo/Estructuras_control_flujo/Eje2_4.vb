Module Eje2_4

    'If: Se ingresan dos valores relativos a un producto en venta: cantidad y precio unitario. Si la
    'cantidad es entre a 10 y 50 el producto recibe un descuento de 5%, si es entre 51 y 250 el
    'descuento es del 10% y si es 251 o más el descuento es del 20%. Informar subtotal (cantidad por
    'precio unitario), porcentaje de descuento aplicado, monto descontado y el total (subtotal –
    'monto descontado).

    Sub Main()
        Dim cant As UShort
        Dim precio_uni As Single
        Dim subtotal As Single
        Dim porcentajeDesc As Single

        Console.Write("Ingrese cantidad: ")
        cant = Console.ReadLine()

        Console.Write("Ingrese precio unitario: ")
        precio_uni = Console.ReadLine()

        subtotal = cant * precio_uni

        If cant < 10 Then
            porcentajeDesc = 0
        ElseIf cant >= 10 And cant <= 50 Then
            porcentajeDesc = 5
        ElseIf cant >= 51 And cant <= 250 Then
            porcentajeDesc = 10
        ElseIf cant > 250 Then
            porcentajeDesc = 20
        End If

        Console.WriteLine("Subtotal: " & subtotal)
        Console.WriteLine("% de descuentoaplicado: {0}%", porcentajeDesc)
        Console.WriteLine("Monto descontado: " & subtotal * porcentajeDesc / 100)
        Console.WriteLine("Total: " & subtotal - subtotal * porcentajeDesc / 100)


        Console.ReadKey()

    End Sub

End Module
