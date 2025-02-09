'Angel Nava
'Spring 2025
'RCET2265
'SayMyName
Module TimesTable

    Sub Main()
        Dim number As String
        Dim timesNumber As Integer
        Dim answer As String
        Console.Write("Give me a number to make a times table with: ")
        number = Console.ReadLine()
        Console.WriteLine($"Enjoy your {number} x {number} times table" & vbNewLine)
        timesNumber = CInt(number)
        For i = 1 To timesNumber
            For j = 1 To timesNumber
                answer = (i * j).ToString()
                answer = answer.PadLeft(5)
                Console.Write(answer)
            Next
            Console.WriteLine()
        Next


    End Sub

End Module
