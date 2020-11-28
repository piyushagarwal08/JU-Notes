Module MyModule
    Sub Main()
        Dim a(,) As Integer = {
            {0,0},{1,2},{2,4},{3,6}
        }
        Dim i,j as Integer

        For i=0 To 3
            For j=0 To 1
                'Though in jagged array we would use a(i)(j)
                Console.WriteLine(a(i,j))
            Next
        Next
    End Sub
End Module