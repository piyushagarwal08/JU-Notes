Module arrayApl
   Sub Main()
      ' 1d array named list
      Dim list As Integer() = {34, 72, 13, 44, 25, 30, 10}
      ' Copy temp array from list
      Dim temp As Integer() = list
      Dim i As Integer
      Console.Write("Original Array: ")
      
      ' For each loop over copied array values
      For Each i In list
         Console.Write("{0} ", i)
      Next i
      Console.WriteLine()

      ' reverse the array
      Array.Reverse(temp)
      Console.Write("Reversed Array: ")
      
      For Each i In temp
         Console.Write("{0} ", i)
      Next i
      Console.WriteLine()

      'sort the array
      Array.Sort(list)
      Console.Write("Sorted Array: ")
      
      For Each i In list
         Console.Write("{0} ", i)
      Next i
      Console.WriteLine()
   End Sub
End Module