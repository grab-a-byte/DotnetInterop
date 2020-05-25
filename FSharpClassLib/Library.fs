namespace FSharpClassLib

type ILogin =
   abstract member IsValid: bool

type Login(id:int, username:string, password:string) =
    member this.Id = id
    member this.Username = username
    member this.Password = password
    interface ILogin with 
        member this.IsValid = this.Username = "connel" && this.Password = "password"

type MyFSharpClass() = 
   let mutable multiplier = 0

   member this.AddTwo a b =
        a + b

    member this.SetMultiplier newMultiplier =
        multiplier <- newMultiplier

    member this.MultiplyByMultiplier valueToMultiply =
        valueToMultiply * multiplier


type LogLevels =
    | Error = 1
    | Warning = 2
    | Info = 3

    module Printing = 
        let printHelloWorld () =
            printf "Hello World"
