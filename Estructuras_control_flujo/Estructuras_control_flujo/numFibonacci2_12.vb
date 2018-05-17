Module numFibonacci2_12
    Sub main()
        Dim a As Integer = 0
        Dim b As Integer = 1
        Dim c As Integer
        Dim x As Byte

        Do While x <= 20
            c = a + b
            a = b
            b = c
            Console.WriteLine(c)
            x += 1
        Loop

        Console.ReadKey()

    End Sub
End Module
