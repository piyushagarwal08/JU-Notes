Module Joining
    Sub Main()
        dim story As String() = {
            "Hey",
            "My Name is {0}",
            "And ofcourse i am  smart"
        }

        Dim name As String = Console.ReadLine()
        Console.WriteLine(String.Format(String.Join(Environment.Newline,story),name))
    End Sub 
End Module