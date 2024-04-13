namespace FSharpClassLib

module FunctionalParadigms =

    let aFunction (string:string) =
        string.Length

    let getSeq = seq {
        for i in 1 .. 10 -> i * i
    }

    let aNumber = 5

    let getAList() = [1;2;3]

    type Postcode = | Postcode of string

    type OtherLogLevels =
        | Error of int
        | Warning of struct(int * string)
        | Info of string

    type TypeOne = {
        Name: string
        agent: int
    }

    type TypeTwo = {
        isTrue : bool
        SomeNumber: double
    }

    type TypeThree =
        | TheOne of TypeOne
        | TheTwo of TypeTwo


    let stringConcat x y =
        sprintf "%s %s" x y


    let getTypeTwoIfTrue (typeThree: TypeThree) =
        match typeThree with
        | TheTwo x ->
            Some x
        | _ -> None

    let parseInt (x : string) =
        match System.Int32.TryParse(x) with
        | success, result when success -> Some(result)
        | _ -> None

    let doAStringFunction stringFunc =
        stringFunc "Something"

    let getASomeOption () = Some 1

    let getANoneOption () = None

module FuncParTwo =
    let add x y = x + y

    let message = "hello world";

module Animals =
    type Animal =
        | Dog
        | Cat
        | Parrot