namespace FSharpClassLib

type ILogin =
   abstract member IsValid: bool

type Login(id:int, username:string, password:string) =
    member _.Id = id
    member _.Username = username
    member _.Password = password
    interface ILogin with
        member this.IsValid = this.Username = "connel" && this.Password = "password"

type MyFSharpClass() =
   let mutable multiplier = 0

   member _.AddTwo a b =
        a + b

    member _.SetMultiplier newMultiplier =
        multiplier <- newMultiplier

    member _.MultiplyByMultiplier valueToMultiply =
        valueToMultiply * multiplier


type LogLevels =
    | Error = 1
    | Warning = 2
    | Info = 3

    module Printing =
        let printHelloWorld () =
            printf "Hello World"
