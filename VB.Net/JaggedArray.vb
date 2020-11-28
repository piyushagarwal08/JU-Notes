' Example of Jagged Array
' Array of Array is known as Jagged array

Module MyModule
    Sub Main()
        ' Total 5 elements
        Dim a As Integer()() = new Integer(1)() {}
        a(0) = New Integer() {0,0}
        a(1) = New Integer() {1,2}

        Dim i,j As Integer
        For i=0 to 1
            For j=0 to 1
             Console.WriteLine("a[{0},{1}] = {2}",i,j,a(i)(j))
            Next
        Next
    End Sub
End Module