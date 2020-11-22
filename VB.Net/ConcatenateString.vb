Module ConcatenateString
    Sub Main()
        'Console.Read() reads the values in ASCII value
        Dim word,sentence As String
        word = ""
        sentence = ""
        While(True)
            word = Console.ReadLine()
            If word.length = 0 Then
                Exit While
            End If
            IF sentence.length = 0 Then
                sentence = String.Concat(sentence,word)
            Else
                sentence = String.Concat(sentence," ",word)
            End If
        End While 
        Console.WriteLine(sentence)
    End Sub
End Module