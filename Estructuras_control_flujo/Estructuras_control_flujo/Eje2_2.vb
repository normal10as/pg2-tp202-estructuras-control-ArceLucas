Module Eje2_2
    'IF: ingresar tres valores y mostrar el menor
    Sub main()
        Dim num1 As Byte
        Dim num2 As Byte
        Dim num3 As Byte

        Console.Write("Ingrese 1er numero: ")
        num1 = Console.ReadLine()
        Console.Write("Ingrese 2do numero: ")
        num2 = Console.ReadLine()
        Console.Write("Ingrese 3er numero: ")
        num3 = Console.ReadLine()

        If num1 < num2 And num1 < num3 Then
            Console.WriteLine("El menor es: " & num1)
        ElseIf num2 < num3 Then
            Console.WriteLine("El menor es: " & num2)
        Else
            Console.WriteLine("El menor es: " & num3)
        End If

        Console.ReadKey()
    End Sub
End Module
