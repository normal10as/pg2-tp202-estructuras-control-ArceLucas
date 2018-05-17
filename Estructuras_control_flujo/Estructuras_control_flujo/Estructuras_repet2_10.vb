Module Estructuras_repet2_10
    Sub main()
        Dim x As Integer
        Dim y As Integer
        Dim aux As Integer
        Dim multiplo As Byte

        Console.Write("Ingrese un numero: ")
        x = Console.ReadLine()

        aux = x

        Console.Write("Ingrese otro numero: ")
        y = Console.ReadLine()


        Console.WriteLine("DO WHILE")
        Do While x <= y  'Repite el bucle hasta que condition es False.
            If x Mod 5 = 0 Then
                multiplo += 1
            End If
            x += 1
        Loop
        Console.WriteLine("Tiene {0} multiplos de 5", multiplo)

        Console.WriteLine("DO UNTIL")
        x = aux
        multiplo = 0
        Do Until x > y 'Repite el bucle hasta que condition es True.
            If x Mod 5 = 0 Then
                multiplo += 1
            End If
            x += 1
        Loop
        Console.WriteLine("Tiene {0} multiplos de 5", multiplo)

        Console.WriteLine("DO...WHILE")
        x = aux
        multiplo = 0
        Do
            If x Mod 5 = 0 Then
                multiplo += 1
            End If
            x += 1
        Loop While x <= y
        Console.WriteLine("Tiene {0} multiplos de 5", multiplo)

        Console.WriteLine("DO...UNTIL")
        x = aux
        multiplo = 0
        Do
            If x Mod 5 = 0 Then
                multiplo += 1
            End If
            x += 1
        Loop Until x > y
        Console.WriteLine("Tiene {0} multiplos de 5", multiplo)

        Console.WriteLine("FOR")
        x = aux
        multiplo = 0
        For i As Integer = x To y Step +1
            If i Mod 5 = 0 Then
                multiplo += 1
            End If
        Next
        Console.WriteLine("Tiene {0} multiplos de 5", multiplo)

        Console.ReadKey()

    End Sub
End Module
