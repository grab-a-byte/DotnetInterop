// Learn more about F# at http://fsharp.org

open System
open CSharpClassLib
open VBClassLib
open Newtonsoft.Json

[<EntryPoint>]
let main argv =

    [|1,2,3,4|] 
    |> JsonConvert.SerializeObject 
    |> printfn "%s"

    let csharpClass = new MyCSharpClass()
    csharpClass.AddTwo(1,2) |> printfn "C# result :- %i"

    csharpClass.SetMultiplier(4)
    csharpClass.MultiplyByMutiplier(4) |> printfn "C# multiply result :- %i"

    let vbClass: MyVBClass = new MyVBClass()
    vbClass.AddTwo(3,4) |> printfn "VB result :- %i"

    4   |> vbClass.SetMultiplier
    4   |> vbClass.MultiplyByMultiplier 
        |> printfn "VB Multiply Result:- %i"

    Console.ReadKey |> ignore
    0
