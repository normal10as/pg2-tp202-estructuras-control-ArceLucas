Module case2_7
    Sub main()
        Dim grado_angulo As UShort

        Console.Write("Ingrese el tama?o del angulo en grados: ")
        grado_angulo = Console.ReadLine()

        Select Case grado_angulo
            Case Is < 90
                Console.WriteLine("Angulo Agudo")
            Case Is = 90
                Console.WriteLine("Angulo Recto")
            Case 91 To 179
                Console.WriteLine("Angulo Obtuso")
            Case Is = 180
                Console.WriteLine("Angulo Llano")
            Case 181 To 359
                Console.WriteLine("Angulo Concavo")
            Case Is < 0, Is > 360
                Console.WriteLine("Angulo Error")
        End Select

        Console.ReadKey()
    End Sub
End Module
