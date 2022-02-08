'Carson Bogart
'RCET 0265
'Spring 22
'Cookie of Fortune
'https://github.com/bogacars/Fortune_Cookie_CB.githttps://github.com/bogacars/Fortune_Cookie_CB.git

Option Explicit On
Option Strict On
Module Cookie

    Sub Main()
        Randomize()
        Dim userRandom As Integer = CInt(Int((10 * Rnd()) + 1))

        Select Case userRandom
            Case 1
                Console.WriteLine("It's better to ask for forgiveness than permission ")
                Console.ReadLine()
            Case 2
                Console.WriteLine("Sleep is just a time machine to breakfast ")
                Console.ReadLine()
            Case 3
                Console.WriteLine("If it's broke just fix it ")
                Console.ReadLine()
            Case 4
                Console.WriteLine("Kirchoff is always right")
                Console.ReadLine()
            Case 5
                Console.WriteLine("You will pass your next test you take")
                Console.ReadLine()
            Case 6
                Console.WriteLine("Russia, please don't invade Ukraine")
                Console.ReadLine()
            Case 7
                Console.WriteLine("You are very fortune-ate")
                Console.ReadLine()
            Case 8
                Console.WriteLine("Don't ever try to out pizza the hut")
                Console.ReadLine()
            Case 9
                Console.WriteLine("Dividing by zero will destroy the universe")
                Console.ReadLine()
            Case 10
                Console.WriteLine("The answers to your next test are NOT syntax error")
                Console.ReadLine()
        End Select

    End Sub

End Module
