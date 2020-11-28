Module MyModule
    Sub Main()
        Dim n(10) As Integer ' array of 11 integers
        Dim i, j As Integer
        Console.WriteLine(n.length())
        'Initialize the elements of array n
        For i = 0 to 10 step 1
            n(i) = i + 100 
        Next 

        ' Output the elements of the array
        For j=0 To 10
            Console.WriteLine(n(j))
        Next j
    End Sub 
End Module