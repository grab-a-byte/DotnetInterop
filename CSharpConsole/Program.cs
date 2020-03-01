using System;
using VBClassLib;

namespace CSharpConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            MyVBClass myVBClass = new MyVBClass();
            var vbResult = myVBClass.AddTwo(1, 2);
            Console.WriteLine(vbResult);

            myVBClass.SetMultiplier(4);
            var myVBResult2 = myVBClass.MultiplyByMultiplier(4);
            Console.WriteLine(myVBResult2);
        }
    }
}
