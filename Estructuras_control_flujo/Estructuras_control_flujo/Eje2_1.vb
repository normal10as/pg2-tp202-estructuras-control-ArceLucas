Module Eje2_1
    'IF: Crear un módulo en el cual se ingresan dos valores numéricos e informar por pantalla cuál es
    'la relación entre ambos: mayor, menor o igual
    Sub main()
        Dim num1 As Byte
        Dim num2 As Byte

        Console.Write("Ingrese 1er numero: ")
        num1 = Console.ReadLine()
        Console.Write("Ingrese 2do numero: ")
        num2 = Console.ReadLine()

        If num1 > num2 Then
            Console.WriteLine("El 1er es mayor")
        ElseIf num1 < num2 Then
            Console.WriteLine("El 1er es menor")
        ElseIf num1 = num2 Then
            Console.WriteLine("son iguales")
        End If

        Console.ReadKey()
    End Sub
End Module
