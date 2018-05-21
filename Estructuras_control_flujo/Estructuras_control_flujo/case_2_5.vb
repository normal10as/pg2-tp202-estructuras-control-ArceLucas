Module case_2_5
    Enum meses
        Enero = 1
        Febrero = 2
        Marzo = 3
        Abril = 4
        Mayo = 5
        Junio = 6
        Julio = 7
        Agosto = 8
        Septiembre = 9
        Octubre = 10
        Noviembre = 11
        Diciembre = 12
    End Enum
    Sub main()
        Dim mes As meses
        Dim n As Byte

        Console.Write("Ingrese un numero del 1 al 12: ")
        n = Console.ReadLine()

        mes = n

        Select Case n
            Case 1
                Console.WriteLine("El numero corresponde al mes: " & mes.ToString)
            Case 2
                Console.WriteLine("El numero corresponde al mes: " & mes.ToString)
            Case 3
                Console.WriteLine("El numero corresponde al mes: " & mes.ToString)
            Case 4
                Console.WriteLine("El numero corresponde al mes: " & mes.ToString)
            Case 5
                Console.WriteLine("El numero corresponde al mes: " & mes.ToString)
            Case 6
                Console.WriteLine("El numero corresponde al mes: " & mes.ToString)
            Case 7
                Console.WriteLine("El numero corresponde al mes: " & mes.ToString)
            Case 8
                Console.WriteLine("El numero corresponde al mes: " & mes.ToString)
            Case 9
                Console.WriteLine("El numero corresponde al mes: " & mes.ToString)
            Case 10
                Console.WriteLine("El numero corresponde al mes: " & mes.ToString)
            Case 11
                Console.WriteLine("El numero corresponde al mes: " & mes.ToString)
            Case 12
                Console.WriteLine("El numero corresponde al mes: " & mes.ToString)
            Case Else
                Console.WriteLine("El numero no corresponde")
        End Select

        Console.ReadKey()

    End Sub
End Module
