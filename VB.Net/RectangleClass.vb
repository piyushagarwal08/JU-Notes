Imports System
Public Class Rectangle
    Private length As Double
    Private breadth As Double
    'Public Area As Double

    ' These are Public Methods
    Public Sub AcceptDetails()
        length = 4.5
        breadth = 3.5
    End Sub

    Public Function Area() As Double
        Area = length * breadth
    End Function

    Public Sub Display()
        Console.WriteLine("Length: {0}",length)
        Console.WriteLine("Breadth: {0}",breadth)
        Console.WriteLine("Area: {0}",Area())
    End Sub


    Shared Sub Main()
        Dim r As New Rectangle()
        r.AcceptDetails()
        r.Display()
        Console.ReadLine
    End Sub
End Class