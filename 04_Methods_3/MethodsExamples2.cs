using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Methods_3
{
    [TestClass]
    public class MethodsExamples2
    {
        //input
        //what we do
        //OUtput

        //access modifier, return type, parameters

        [TestMethod]
        //1 the access modifiers--modifies how accessible the method is
        //return type VOID means that our method is going to do something, bit not return anything
        //method signature  a) name of the merhtod and b) the parameters

        public int AddTwoNumbers(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }
        public void MethodTests()
        {
            AddTwoNumbers(7, 12);
        }
    }
}
