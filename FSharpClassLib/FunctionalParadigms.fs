namespace FSharpClassLib

module FunctionalParadigms =

    type Postcode = | Postcode of string

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
