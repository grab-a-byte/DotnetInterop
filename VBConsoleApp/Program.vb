Imports System
Imports CSharpClassLib

Module Program
    Sub Main(args As String())

        Dim myCSharpClass = New MyCSharpClass()
        Dim csResult = myCSharpClass.AddTwo(1, 2)
        Console.WriteLine(csResult)

        myCSharpClass.SetMultiplier(4)
        Dim myCSharpResult2 = myCSharpClass.MultiplyByMutiplier(4)
        Console.WriteLine(myCSharpResult2)
    End Sub
End Module
