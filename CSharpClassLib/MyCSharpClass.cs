using System;

namespace CSharpClassLib
{
    public class MyCSharpClass
    {
        private int multiplier;

        public int AddTwo(int A, int B) => A + B;

        public void SetMultiplier(int newMultiplier) 
            => multiplier = newMultiplier;

        public int MultiplyByMutiplier(int numToMultiply) 
            => numToMultiply * multiplier;
    }
}