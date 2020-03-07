namespace FSharpClassLib

module FunctionalParadigms =

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

    let something x y = x + y

