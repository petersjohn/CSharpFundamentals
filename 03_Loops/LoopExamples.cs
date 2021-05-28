using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_Loops
{
    [TestClass]
    public class LoopExamples
    {
        [TestMethod]
        public void ForLoops()
        {
            int studentCount = 15;
            //1 starting point
            //2 condition that while true, keeps loop running
            //3 What happens after each loop
            //4 Body of the loop, what happens each iteration
                //1........//2............//3
            for(int i = 0; i < studentCount; i++) //the for loop construct all conditions are in the ()
            {
                //4
                Console.WriteLine(i);            
            }
        }
        [TestMethod]
        public void ForEachLoops()
        {
            string name = "Eleven Fifty Academy";
            //1 collection that is being worked on
            //2 Name of the current iteration being used
            //3 current type in the collection
            //4 in keyword, used to separate the individual and the collection
            //5 body of the loop
            //foreach //3 //2   //4 //1
            foreach (char letter in name)
            {
                Console.WriteLine(letter);//5
            }
        }

        [TestMethod]
        public void WhileLoops()
        {
            int total = 1;

            //1 loop runs while the condition is true
            //2 body of the loop

            while(total != 30)
            {
                Console.WriteLine(total);
                total++;

            }

        }
    }
}

    
