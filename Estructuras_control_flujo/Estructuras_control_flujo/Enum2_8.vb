Module Enum2_8
    Enum meses
        Enero = 1
        Febrero = 2
        Marzo = 3
        Abril = 4
        Mayo = 5
        Junio = 6
        Julio = 7
        Agosto = 8
        septiembre = 9
        Octubre = 10
        Noviembre = 11
        Diciembre = 12
    End Enum
    Sub main()
        Dim mes As meses
        Dim m As Byte

        Console.Write("Ingrese el numero del mes: ")
        m = Console.ReadLine()

        mes = m

        Select Case mes
            Case 1
                Console.WriteLine("El mes de {0} tiene 31 dias", mes.ToString)
            Case 2
                Dim anho As Int16
                Console.Write("Ingrese el a?o: ")
                anho = Console.ReadLine()
                If ((anho Mod 4 = 0) And (anho Mod 100 <> 0)) Or (anho Mod 400 = 0) Then
                    Console.WriteLine("El mes de {0} tiene 29 dias", mes.ToString)
                Else
                    Console.WriteLine("El mes de {0} tiene 28 dias", mes.ToString)
                End If
            Case 3
                Console.WriteLine("El mes de {0} tiene 31 dias", mes.ToString)
            Case 4
                Console.WriteLine("El mes de {0} tiene 30 dias", mes.ToString)
            Case 5
                Console.WriteLine("El mes de {0} tiene 31 dias", mes.ToString)
            Case 6
                Console.WriteLine("El mes de {0} tiene 30 dias", mes.ToString)
            Case 7
                Console.WriteLine("El mes de {0} tiene 31 dias", mes.ToString)
            Case 8
                Console.WriteLine("El mes de {0} tiene 31 dias", mes.ToString)
            Case 9
                Console.WriteLine("El mes de {0} tiene 30 dias", mes.ToString)
            Case 10
                Console.WriteLine("El mes de {0} tiene 31 dias", mes.ToString)
            Case 11
                Console.WriteLine("El mes de {0} tiene 30 dias", mes.ToString)
            Case 12
                Console.WriteLine("El mes de {0} tiene 31 dias", mes.ToString)
            Case Else
                Console.WriteLine("numero de mes no existe")
        End Select

        Console.ReadKey()
    End Sub
End Module
