Module MyModule
    Sub Main()
        Dim marks() As Integer
        ReDim marks(2)
        
        marks(0) = 85
        marks(1) = 75
        marks(2) = 90

        ReDim Preserve marks(5)
        marks(3) = 78
        marks(4) = 12
        marks(5) = 122

        For i=0 to 5
            Console.WriteLine(marks(i))
        Next i

        Console.WriteLine("New Array after Reducing")
        ReDim Preserve marks(3)
        For i=0 to 3
            Console.WriteLine(marks(i))
        Next i
    End Sub 
End Module