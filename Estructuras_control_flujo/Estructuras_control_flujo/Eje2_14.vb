Module Eje2_14
    'Informar por
    'cada producto subtotal (cantidad por precio unitario), porcentaje de descuento aplicado, monto
    'descontado y el total (subtotal – monto descontado). Al finalizar el ingreso, por cantidad igual a
    'cero, informar el total de pesos descontados y el total a cobrar.
    Sub main()
        Dim cant As UShort
        Dim precio_uni As Single
        Dim subtotal As Single
        Dim porcentajeDesc As Byte
        Dim total_descontado As Single
        Dim total_cobrar As Single

        Do

            Console.Write("Ingrese cantidad: ")
            cant = Console.ReadLine()

            If cant = 0 Then
                Exit Do
            End If

            Console.Write("Ingrese precio unitario: ")
            precio_uni = Console.ReadLine()

            subtotal = cant * precio_uni

            If cant < 10 Then
                porcentajeDesc = 1
            ElseIf cant >= 10 And cant <= 50 Then
            porcentajeDesc = 5
            ElseIf cant >= 51 And cant <= 250 Then
                porcentajeDesc = 10
            ElseIf cant > 250 Then
                porcentajeDesc = 20
            End If

            If porcentajeDesc = 1 Then
                Console.WriteLine("Subtotal: " & subtotal)
                Console.WriteLine("% de descuentoaplicado: 0%")
                Console.WriteLine("Monto descontado: No posee descuento")
                Console.WriteLine("Total: " & subtotal)
                total_cobrar += subtotal
            Else
                Console.WriteLine("Subtotal: " & subtotal)
                Console.WriteLine("% de descuentoaplicado: {0}%", porcentajeDesc)
                Console.WriteLine("Monto descontado: " & subtotal * porcentajeDesc / 100)
                Console.WriteLine("Total: " & subtotal - subtotal * porcentajeDesc / 100)
                total_descontado += subtotal * porcentajeDesc / 100
                total_cobrar += subtotal - subtotal * porcentajeDesc / 100
            End If

        Loop While cant <> 0

        Console.WriteLine("Total Descontado: " & total_descontado)
        Console.WriteLine("Total a cobrar: " & total_cobrar)


        Console.ReadKey()
    End Sub
End Module
