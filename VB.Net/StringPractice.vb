Module strings
    Sub Main()
        Dim fname,lname,fullname As String
        fname = "Piyush"
        lname = "Agarwal"
        fullname = fname + " " + lname
        Console.WriteLine(fullname)

    ' By using String Constructor
    Dim characters As Char() = {"H","E","Y"}
    Console.WriteLine(characters)
    Dim greetings As String = New String(characters)
    Console.WriteLine(greetings)

    ' Methods returning String
    Dim sarray() As String = {"Hey","Piyush","Agarwal"}
    Console.WriteLine(sarray)
    Dim message As String = String.Join(" ",sarray)
    Console.WriteLine(message)

    ' formatting method to convert a value
    Dim waiting As DateTime = New DateTime(2020,11,22,19,21,08)
    Dim chat As String = String.Format("Message Sent At {0:t} on {0:D}",waiting)
    Console.WriteLine(chat)

    Dim num As Integer = String.Compare("hello","Piyushhello",True)
    Dim concat As String = String.Concat("hello","Piyushhello")
    Console.WriteLine(num.ToString)
    Console.WriteLine(concat)
    End Sub 
End Module