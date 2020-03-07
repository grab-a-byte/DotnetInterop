using System;
using VBClassLib;
using FSharpClassLib;

namespace CSharpConsole
{
    public static class SimpleExamples
    {
        public static void RunMain()
        {
            MyVBClass myVBClass = new MyVBClass();
            var vbResult = myVBClass.AddTwo(1, 2);
            Console.WriteLine(vbResult);

            myVBClass.SetMultiplier(4);
            var myVBResult2 = myVBClass.MultiplyByMultiplier(4);
            Console.WriteLine(myVBResult2);

            MyFSharpClass fSharpClass = new MyFSharpClass();
            var fSharpResult = fSharpClass.AddTwo(1, 2);
            Console.WriteLine(fSharpResult);

            fSharpClass.SetMultiplier(4);
            var fSharpResult2 = fSharpClass.MultiplyByMultiplier(4);
            Console.WriteLine(fSharpResult2);
        }
    }
}
