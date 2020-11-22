Module strings
   Sub Main()
      Dim str1, str2 As String
      str1 = "This is test"
      str2 = "This is test"
      
      If (String.Compare(str1, str2) = 0) Then
         Console.WriteLine(str1 + " and " + str2 + " are equal.")
      Else
         Console.WriteLine(str1 + " and " + str2 + " are not equal.")
      End If
    
   End Sub
End Module