Module Eje2_3
    'If: Crear un programa que se ingresen 5 valores enteros e informar cual es el mayor por su
    'posición de ingreso, por ejemplo, dado los siguientes valores: 3,7,12,5,9 informar: “El tercer
    'número es el mayor valor”
    Sub main()
        Dim num1 As Byte
        Dim num2 As Byte
        Dim num3 As Byte
        Dim num4 As Byte
        Dim num5 As Byte

        Console.Write("Ingrese 1er numero: ")
        num1 = Console.ReadLine()
        Console.Write("Ingrese 2do numero: ")
        num2 = Console.ReadLine()
        Console.Write("Ingrese 3er numero: ")
        num3 = Console.ReadLine()
        Console.Write("Ingrese 4to numero: ")
        num4 = Console.ReadLine()
        Console.Write("Ingrese 5to numero: ")
        num5 = Console.ReadLine()

        If num1 > num2 And num1 > num3 And num1 > num4 And num1 > num5 Then
            Console.WriteLine("El primer numero es el mayor valor")
        ElseIf num2 > num3 And num2 > num4 And num2 > num5 Then
            Console.WriteLine("El segundo numero es el mayor valor")
        ElseIf num3 > num4 And num3 > num5 Then
            Console.WriteLine("El tercer numero es el mayor valor")
        ElseIf num4 > num5 Then
            Console.WriteLine("El cuarto numero es el mayor valor")
        Else
            Console.WriteLine("El quinto numero es el mayor valor")

        End If

        Console.ReadKey()

    End Sub

End Module
