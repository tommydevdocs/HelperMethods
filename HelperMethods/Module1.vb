Module Module1

    Sub Main()
        'displayTheMessage()
        'Dim myVal As String = superSecretFormula()
        'Dim myVal As String = superSecretFormula("Bob")
        'Console.WriteLine(myVal)

        Console.WriteLine(superSecretFormula())
        Console.WriteLine(superSecretFormula("Bob"))
        Console.ReadLine()
    End Sub

    'Sub displayTheMessage()
    '    Console.WriteLine("From displayTheMessage")
    'End Sub

    Function superSecretFormula() As String
        Return "Hello World!"
    End Function

    Function superSecretFormula(ByVal name As String)
        Return String.Format("Hello World, {0}", name)
    End Function

End Module
