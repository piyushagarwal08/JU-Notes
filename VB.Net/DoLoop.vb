Module DoLoop
    Sub Main()
        dim a As Integer
        a = 23
        Do
            Console.WriteLine(str(a))
            a += 1
        Loop While (a<=26)
        Check()
    End Sub
    Sub Check()
        dim a As Integer
        a = 0
        Do
            Console.WriteLine(str(a))
            a += 1
        Loop Until (a>5)
    End Sub
End Module