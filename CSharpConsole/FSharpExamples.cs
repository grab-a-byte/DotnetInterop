using FSharpClassLib;
using System;

namespace CSharpConsole
{
    public static class FSharpExamples
    {
        public static void RunMain()
        {
            var theTwo = new FunctionalParadigms.TypeTwo(true, 1);
            var theThree = FunctionalParadigms.TypeThree.NewTheTwo(theTwo);

            var isTheOne = theThree.IsTheOne;
            var isTheTwo = theThree.IsTheTwo;


            var test = FunctionalParadigms.getTypeTwoIfTrue(theThree);

            Console.WriteLine(test.Value.SomeNumber);

            Console.WriteLine(theTwo.SomeNumber);
        }
    }
}
