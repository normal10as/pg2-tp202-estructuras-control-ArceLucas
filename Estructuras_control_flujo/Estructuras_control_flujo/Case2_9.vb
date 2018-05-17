Module Case2_9
    '1 pie = 12 pulgadas, 1 yarda = 3 pies, 1 pulgada = 2.54 cm, 1 metro = 100 cm
    Sub main()
        Dim unidad As Byte
        Dim medida As Integer

        Console.Write("Ingrese la unidad a convertir 1-Pulgada, 2-Yarda, 3-Pies, 4-cm, 5-Metro: ")
        unidad = Console.ReadLine()
        Console.Write("Ingrese la medida: ")
        medida = Console.ReadLine()

        Select Case unidad
            Case 1
                Console.WriteLine("Unidad: Pulgada - Medida: {0}", medida)
                Console.WriteLine("En pies: " & medida / 12)
                Console.WriteLine("En yardas: " & medida / 36)
                Console.WriteLine("En metros: " & (medida * 2.54) / 100)
                Console.WriteLine("En cm: " & medida * 2.54)
            Case 2
                Console.WriteLine("Unidad: Yarda - Medida: {0}", medida)
                Console.WriteLine("En pies: " & medida * 3)
                Console.WriteLine("En Pulgadas: " & medida * 36)
                Console.WriteLine("En metros: " & (medida * 36 * 2.54) / 100)
                Console.WriteLine("En cm: " & medida * 36 * 2.54)
            Case 3
                Console.WriteLine("Unidad: Pies - Medida: {0}", medida)
                Console.WriteLine("En pulgadas: " & medida * 12)
                Console.WriteLine("En yardas: " & medida / 3)
                Console.WriteLine("En metros: " & (medida * 12 * 2.54) / 100)
                Console.WriteLine("En cm: " & medida * 12 * 2.54)
            Case 4
                Console.WriteLine("Unidad: CM - Medida: {0}", medida)
                Console.WriteLine("En pies: " & medida / 2.54 / 12)
                Console.WriteLine("En yardas: " & medida / 2.54 / 12 / 3)
                Console.WriteLine("En metros: " & medida / 100)
                Console.WriteLine("En Pulgadas: " & medida / 2.54)
            Case 5
                Console.WriteLine("Unidad: Metro - Medida: {0}", medida)
                Console.WriteLine("En pies: " & (medida * 100) / 2.54 / 12)
                Console.WriteLine("En yardas: " & (medida * 100) / 2.54 / 12 / 3)
                Console.WriteLine("En cm: " & medida * 100)
                Console.WriteLine("En Pulgadas: " & (medida * 100) / 2.54)
            Case Else
                Console.WriteLine("Unidad no valida")
        End Select

        Console.ReadKey()

    End Sub
End Module
