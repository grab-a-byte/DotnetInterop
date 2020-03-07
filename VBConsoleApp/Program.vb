Imports CSharpClassLib
Imports FSharpClassLib
Imports Newtonsoft.Json

Module Program
    Sub Main(args As String())

        Dim myCSharpClass = New MyCSharpClass()
        Dim csResult = myCSharpClass.AddTwo(1, 2)
        Console.WriteLine("C# result :- " & csResult)

        myCSharpClass.SetMultiplier(4)
        Dim myCSharpResult2 = myCSharpClass.MultiplyByMutiplier(4)
        Console.WriteLine("C# multiply result :- " & myCSharpResult2)

        Dim numbers = New Integer() {1, 2, 4, 8}
        Dim serializeResult = JsonConvert.SerializeObject(numbers)
        Console.WriteLine(serializeResult)

        Dim myFsharpClass = New MyFSharpClass()
        Dim fsResult = myFsharpClass.AddTwo(1,2)
        Console.WriteLine("Fsharp Result :- " & fsResult)

        myFsharpClass.SetMultiplier(4)
        Dim fsResult2 = myFsharpClass.MultiplyByMultiplier(4)
        Console.WriteLine("Fsharp multiply result :- "  & fsResult2)

        Console.ReadKey()

    End Sub
End Module
