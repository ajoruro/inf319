Module Module1

    Sub Main()

        Dim a, b, c, x As Integer
        Console.WriteLine("Introduzca tres numeros")
        a = Convert.ToInt32(Console.ReadLine())
        b = Convert.ToInt32(Console.ReadLine())
        c = Convert.ToInt32(Console.ReadLine())

        For i = 1 To 3
            If a > b Then GoTo Linea1 Else GoTo Linea2
Linea1:
            x = a
            a = b
            b = x
Linea2:
            If b > c Then
                x = b
                b = c
                c = x
            End If
        Next i


        Console.WriteLine("se ordena los numeros:  " + a.ToString() + " " + b.ToString() + " " + c.ToString())


        Console.ReadKey()

    End Sub

End Module
