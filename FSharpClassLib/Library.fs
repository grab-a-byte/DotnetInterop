namespace FSharpClassLib


type MyFSharpClass() = 
   let mutable multiplier = 0

   member this.AddTwo a b =
        a + b

    member this.SetMultiplier newMultiplier =
        multiplier <- newMultiplier

    member this.MultiplyByMultiplier valueToMultiply =
        valueToMultiply * multiplier