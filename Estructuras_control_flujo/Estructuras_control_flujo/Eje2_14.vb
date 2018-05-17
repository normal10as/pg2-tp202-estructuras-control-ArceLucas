Module Eje2_14
    'Informar por
    'cada producto subtotal (cantidad por precio unitario), porcentaje de descuento aplicado, monto
    'descontado y el total (subtotal – monto descontado). Al finalizar el ingreso, por cantidad igual a
    'cero, informar el total de pesos descontados y el total a cobrar.
    Sub main()
        Dim cant As UShort
        Dim precio_uni As Single
        Dim subtotal As Single
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

            If cant >= 10 And cant <= 50 Then
                'recibe descuento del 5%
                Console.WriteLine("Subtotal: " & subtotal)
                Console.WriteLine("% de descuentoaplicado: 5%")
                Console.WriteLine("Monto descontado: " & subtotal * 0.05)
                Console.WriteLine("Total: " & subtotal - subtotal * 0.05)
                total_descontado += subtotal * 0.05
                total_cobrar += subtotal - subtotal * 0.05
            ElseIf cant >= 51 And cant <= 250 Then
                'recibe descuento del 10%
                Console.WriteLine("Subtotal: " & subtotal)
                Console.WriteLine("% de descuentoaplicado: 10%")
                Console.WriteLine("Monto descontado: " & subtotal * 0.1)
                Console.WriteLine("Total: " & subtotal - subtotal * 0.1)
                total_descontado += subtotal * 0.1
                total_cobrar += subtotal - subtotal * 0.1
            ElseIf cant > 250 Then
                'recibe un descuento del 20%
                Console.WriteLine("Subtotal: " & subtotal)
                Console.WriteLine("% de descuentoaplicado: 20%")
                Console.WriteLine("Monto descontado: " & subtotal * 0.2)
                Console.WriteLine("Total: " & subtotal - subtotal * 0.2)
                total_descontado += subtotal * 0.2
                total_cobrar += subtotal - subtotal * 0.2
            End If
        Loop While cant <> 0

        Console.WriteLine("Total Descontado: " & total_descontado)
        Console.WriteLine("Total a cobrar: " & total_cobrar)


        Console.ReadKey()
    End Sub
End Module
