using FSharpClassLib;
using Microsoft.FSharp.Core;
using System;
using System.Collections.Generic;
using static FSharpClassLib.Animals;
using static FSharpClassLib.FuncParTwo;
//using static FSharpClassLib.FunctionalParadigms;

namespace CSharpConsole
{
    public static class FSharpExamples
    {
        public static void RunMain()
        {
            var strLength = FunctionalParadigms.aFunction("Thing");

            var sequence = FunctionalParadigms.getSeq;

            IReadOnlyCollection<int> list = FunctionalParadigms.getAList();

            var num = FunctionalParadigms.aNumber;

            var error = FunctionalParadigms.OtherLogLevels.NewError(42);
            Console.WriteLine($"F# LogLevel Error type {error}");

            var warning = FunctionalParadigms.OtherLogLevels.NewWarning((42, "warning"));
            Console.WriteLine($"F# LogLevel Warning type {warning}");

            var theOne = new FunctionalParadigms.TypeOne("blah", 1);

            var theTwo = new FunctionalParadigms.TypeTwo(true, 2);
            var theThree = FunctionalParadigms.TypeThree.NewTheTwo(theTwo);
            Console.WriteLine($"F# Discriminated Union Type {theThree}");

            var isTheOne = theThree.IsTheOne;
            Console.WriteLine($"type Three is TypeOne: {isTheOne}");
            var isTheTwo = theThree.IsTheTwo;
            Console.WriteLine($"type Three is TypeTwo: {isTheTwo}");

            var test = FunctionalParadigms.getTypeTwoIfTrue(theThree);

            Console.WriteLine();
            Console.WriteLine("Value from directly instantiated two and from matched the three");
            Console.WriteLine(theTwo.SomeNumber);
            Console.WriteLine(test.Value.SomeNumber);


            var result = add(1, 2);
            Console.WriteLine(result);

            var mystring = message;

            var integerOption = FunctionalParadigms.parseInt("42");
            var val = integerOption.Value;
            Console.WriteLine($"Result of parsing '42' from F#: {val}");


            var integerOption2 = FunctionalParadigms.parseInt("blah blah");
            // The below will throw a NullReferenceExcpetion due to parseInt returning Option of None which equates to null in C#
            // var val2 = integerOption2.Value;
            // Console.WriteLine($"Result of parsing 'blah blah' from F#: {val2}");

            Console.WriteLine("");

            //Microsoft.FSharp.Core.Unit();

            //FunctionalParadigms.doAStringFunction<int>((x) => x.Length());
            var i = FunctionalParadigms.doAStringFunction(FSharpFunc<string, int>.FromConverter((x) => x.Length));
            SwitchingOnNoTypeDUs();
        }

        private static void SwitchingOnNoTypeDUs()
        {
           Animal animal = Animal.Cat;
           switch (animal.Tag)
           {
               case Animal.Tags.Dog:
                   Console.WriteLine("dog");
                   break;
               case Animal.Tags.Cat:
                   Console.WriteLine("cat"); // prints cat
                   break;
               case Animal.Tags.Parrot:
                   Console.WriteLine("polly want a cracker");
                   break;
               default:
                   throw new ArgumentOutOfRangeException();
           }
        }
    }
}
