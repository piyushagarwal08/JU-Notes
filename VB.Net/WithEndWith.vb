Module loops
   Public Class Book
      Public Property Name As String
      Public Property Author As String
      Public Property Subject As String
   End Class
   Sub Main()
      Dim aBook As New Book
      With aBook
         .Name = "VB.Net Programming"
         .Author = "Zara Ali"
         .Subject = "Information Technology"
      End With
      aBook.Author = "Pykid"
      With aBook
         Console.WriteLine(.Name)
         Console.WriteLine(.Author)
         Console.WriteLine(.Subject)
      End With
      Console.ReadLine()
   End Sub
End Module