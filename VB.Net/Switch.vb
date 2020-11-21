Module decisions
   Sub Main()
      'local variable definition
      Dim grade As Char
      grade = "A"
      Select grade
          Case "A"
              Console.WriteLine("Excellent!")
          Case "B", "C"
              Console.WriteLine("Well done")
          Case "D"
              Console.WriteLine("You passed")
          Case "F"
              Console.WriteLine("Better try again")
          Case Else
              Console.WriteLine("Invalid grade")
      End Select
      Console.WriteLine("Your grade is  {0}", grade)
      Console.ReadLine()
   End Sub
End Module