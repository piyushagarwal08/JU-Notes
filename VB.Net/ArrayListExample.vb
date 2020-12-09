Imports System.collections

Module collection
    Sub Main()
        Dim listVariable As ArrayList = New ArrayList()
        Dim i As Integer
        Console.WriteLine("Adding Some Integers")
        listVariable.Add(34)
        listVariable.Add(30)
        listVariable.Add(32)
        listVariable.Add(32)
        listVariable.Add(32)
        listVariable.Add(32)
        listVariable.Add(32)

        Console.WriteLine("Capacity"+listVariable.Capacity.toString)
        for i=0 to 2
            Console.WriteLine(listVariable(i))
        Next i
    End Sub
End Module