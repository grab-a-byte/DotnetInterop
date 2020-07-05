using FSharpClassLib;
using Microsoft.FSharp.Core;
using System;
using System.Collections.Generic;
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
            var wrning = FunctionalParadigms.OtherLogLevels.NewWarning((42, "warning"));

            var theOne = new FunctionalParadigms.TypeOne("blah", 1);

            var theTwo = new FunctionalParadigms.TypeTwo(true, 1);
            var theThree = FunctionalParadigms.TypeThree.NewTheTwo(theTwo);

            var isTheOne = theThree.IsTheOne;
            var isTheTwo = theThree.IsTheTwo;

            var test = FunctionalParadigms.getTypeTwoIfTrue(theThree);

            Console.WriteLine(test.Value.SomeNumber);

            Console.WriteLine(theTwo.SomeNumber);

            var result = add(1, 2);
            Console.WriteLine(result);

            var mystring = message;

            var integerOption = FunctionalParadigms.parseInt("42");
            var val = integerOption.Value;


            var integerOption2 = FunctionalParadigms.parseInt("blah blah");
            var val2 = integerOption.Value;

            Console.WriteLine("");

            //null if none

            //Microsoft.FSharp.Core.Unit();

            //FunctionalParadigms.doAStringFunction<int>((x) => x.Length());

            var i = FunctionalParadigms.doAStringFunction(FSharpFunc<string, int>.FromConverter((x) => x.Length));
        }

        //private static void SwitchingOnNoTypeDUs()
        //{
        //    MoreLogLevels level = MoreLogLevels.Info;
        //    switch (level.Tag)
        //    {
        //        case MoreLogLevels.Tags.Error:
        //            Console.WriteLine("error");
        //            break;
        //        case MoreLogLevels.Tags.Warning:
        //            Console.WriteLine("warning");
        //            break;
        //        case MoreLogLevels.Tags.Info:
        //            Console.WriteLine("info"); //prints info
        //            break;
        //        default:
        //            throw new ArgumentOutOfRangeException();
        //    }
        //}
    }
}
