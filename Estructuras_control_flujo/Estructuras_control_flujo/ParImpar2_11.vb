Module ParImpar2_11
    Sub main()
        Dim x As Integer
        Dim par As Byte
        Dim impar As Byte

        Do
            Console.Write("Ingrese un numero o 0 para salir: ")
            x = Console.ReadLine()
            If x > 0 Then
                If x Mod 2 = 0 Then
                    par += 1
                Else
                    impar += 1
                End If
            End If
        Loop While x <> 0

        If par > 0 And impar > 0 Then
            Console.WriteLine("ingreso {0} numeros par", par)
            Console.WriteLine("ingreso {0} numeros impar", impar)
        ElseIf par = 0 And impar > 0 Then
            Console.WriteLine("Solo ingreso numeros impar")
        ElseIf par > 0 And impar = 0 Then
            Console.WriteLine("Solo ingreso numeros par")
        End If

        Console.ReadKey()

    End Sub
End Module
