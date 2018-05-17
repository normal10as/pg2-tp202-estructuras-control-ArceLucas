Module deposito2_15
    Sub main()
        Const interes As Single = 0.03
        Dim capital As Single
        Dim meses As Byte
        Dim saldo As Single
        Dim interes_ganado As Single
        Dim acu_intereses As Single

        Console.Write("Ingrese el capital: ")
        capital = Console.ReadLine()

        Console.Write("Ingrese los meses: ")
        meses = Console.ReadLine()

        Console.WriteLine("MES      CAPITAL     INTERES     SALDO")

        For i As Byte = 1 To meses Step +1
            interes_ganado = capital * interes
            acu_intereses += interes_ganado
            saldo = capital * interes + capital

            Console.WriteLine("{0}      {1}       {2}        {3}", i, capital, interes_ganado, saldo)

            capital = saldo
        Next

        Console.WriteLine("Total de intereses ganados: " & acu_intereses)

        Console.ReadKey()
    End Sub
End Module
