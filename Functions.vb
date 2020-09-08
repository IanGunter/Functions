Option Strict On
Option Explicit On



Module Functions

    Sub Main()

        'Console.WriteLine(letter)
        'Console.WriteLine(doesNotReturnStuff )
        'Console.ReadLine()

        'Console.WriteLine(addNumbers(3I, 7I))
        'Console.ReadLine()

        'For i = 1 To 3
        'Console.WriteLine(RunningTotal(5))
        'Console.ReadLine()
        '
        'Next

        accumulateMessage("Hello Johnny")
        accumulateMessage("Thats not a number")
        accumulateMessage("User Name is required")

        Console.WriteLine()

    End Sub

    Function letter() As String
        Dim someOtherLetter As String
        someOtherLetter = "Y"
        Return someOtherLetter


    End Function

    Sub doesNotReturnStuff()
        Dim someOtherLetter As String
        someOtherLetter = "X"
        'Return someOtherLetter
    End Sub

    Function addNumbers(ByVal firstNumber As Integer, ByVal secondNumber As Integer) As Integer
        Return firstNumber + secondNumber
    End Function

    Function RunningTotal(ByVal currentAmount As Decimal) As Decimal
        Static total As Decimal
        total += currentAmount
        Return total
    End Function

    Function accumulateMessage(ByVal newMessage As String) As String
        Static userMessage As String
        userMessage &= newMessage & vbNewLine
        Return userMessage

    End Function

End Module
