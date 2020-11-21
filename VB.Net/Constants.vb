'Use of Constant Keyword
Module constantsNenum
    Sub Main()
        Const pi = 3.14149
        Dim radius,area As Single
        radius = 7
        area = radius * pi * radius
        Console.WriteLine("sajsa {0}",radius)
        Console.WriteLine("Area  {0}" & Str(area),area)
    End Sub
End Module