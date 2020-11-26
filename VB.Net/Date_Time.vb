Module Module1
    Sub Main()
        ' Date Time Constructor year,month,day,hour,min,sec
        Dim date1 As New Date(2020,11,25,14,23,12)
        ' 25-11-2020
        Console.WriteLine(date1.toShortDateString)

        ' Initialize a new DateTime value
        Dim date2 As Date = #11/25/2020 01:08:52 PM#
        ' 25-11-2020 13:08:52
        Console.WriteLine(date2)

        ' Few properties
        Console.WriteLine(Date.Now) ' 25-11-2020 15:09:24
        Console.WriteLine(Date.UtcNow) '25-11-2020 09:39:24
        Console.WriteLine(Date.Today) '25-11-2020 00:00:00
        
    End Sub
End Module