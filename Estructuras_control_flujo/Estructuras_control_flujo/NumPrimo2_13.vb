Module NumPrimo2_13
    Sub main()
        Dim cont As UShort

        For n = 2 To 999

            For x = 1 To 999

                If n Mod x = 0 Then
                    cont += 1
                End If
            Next

            If cont = 2 Then
                Console.Write(n & " - ")
            End If
            cont = 0
        Next

        Console.ReadKey()
    End Sub

End Module
