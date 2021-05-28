using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _02_Conditionals
{
    [TestClass]
    public class ConditionalExamples
    {
        [TestMethod]
        public void Booleans()
        {
            bool isTrue = 17 > 5;
            bool isFalse = 17 == 4;

        }

        [TestMethod]
        public void IfElseStatements()
        {
            bool isTrue = true;
            if (isTrue)
            {
                //do something
            }

            int age = 24;

            if (age > 17)
            {
                Console.WriteLine("You're an adult.");
            }
            else if (age > 6)
            {
                Console.WriteLine("You're a kid.");
            }
            else if (age > 0)
            {
                Console.WriteLine("You're too young to be on a computer.");
            }
            else
            {
                Console.WriteLine("Bro, have you been born yet??");
            }

            if( age > 65 && age < 18)
            {
                // and comparison &&
            }

            if (age <= 65 || age >= 18)
            {
                //or comparison ||
            }

            if(age != 19)
            {
                //Not equal to 
                //! bang operator
            }


        }

        [TestMethod]
        public void SwtichCases()

        {
            int age = 42;
            switch (age)
            {
                case 18:
                    //code for if age is 18
                    break;
                case 19:
                    //code for if age is 19
                    break;
                case 19:
                case 20:
                case 21:
                case 22:
                    //code goes here...we can stack these if the code is the same
                    break;
                default:
                    //catch all code
                    break;
            }
        }

        [TestMethod]
        public void Ternaries()
        {
            int age = 37;

            //bool someVariable = (boolean statement) ? trueValue : falseValue

            bool isAge = (age == 24) ? true : false;

        }


    }
}
