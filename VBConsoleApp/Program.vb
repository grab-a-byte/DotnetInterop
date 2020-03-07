Imports CSharpClassLib
Imports FSharpClassLib
Imports Newtonsoft.Json

Module Program
    Sub Main(args As String())

        Dim myCSharpClass = New MyCSharpClass()
        Dim csResult = myCSharpClass.AddTwo(1, 2)
        Console.WriteLine(csResult)

        myCSharpClass.SetMultiplier(4)
        Dim myCSharpResult2 = myCSharpClass.MultiplyByMutiplier(4)
        Console.WriteLine(myCSharpResult2)

        Dim numbers = New Integer() {1, 2, 4, 8}
        Dim serializeResult = JsonConvert.SerializeObject(numbers)
        Console.WriteLine(serializeResult)

        Dim myFsharpClass = New MyFSharpClass()
        Dim fsResult = myFsharpClass.AddTwo(1,2)
        Console.WriteLine(fsResult)

        myFsharpClass.SetMultiplier(4)
        Dim fsResult2 = myFsharpClass.MultiplyByMultiplier(4)
        Console.WriteLine(fsResult2)

        Console.ReadKey()

    End Sub
End Module
