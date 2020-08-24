Option Explicit On
Option Strict On

Module ConsoleFun

    Sub Main()
        Dim userInput As String
        'Console.WriteLine("Please type some text the press enter...")
        'userInput = Console.ReadLine()
        'Console.ReadLine()
        'Console.WriteLine("Thanks!!! You entered: " & userInput & ", Good Work!!")
        'Console.ReadLine()

        Dim firstNumber As Integer
        Dim result As Integer
        Console.WriteLine("Please Enter a Number")
        userInput = Console.ReadLine()
        'firstNumber = Console.ReadLine()
        firstNumber = CInt(userInput)
        result = 5 + firstNumber
        Console.WriteLine(result)
        Console.ReadLine()

    End Sub

End Module
