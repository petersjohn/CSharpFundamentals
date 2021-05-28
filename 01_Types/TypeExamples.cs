using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _01_Types
{
    [TestClass]
    public class TypeExamples
    {
        [TestMethod]
        public void ValueTypes()
        {
            //--Whole Numbers
            byte oneBytesWorth;
            oneBytesWorth = 255; //--byte can only 0 to 255
            short smallWholeNumber = 16; //int 16
            Int16 anotherSmallNumber = 16; 
            int wholeNumber = 32; //Int32
            long largeWholeNumber = 64; //Int64

            //decimals
            float floatExample = 1.234567f; // the f is needed unless you are less than 15-16 decimal places
            double doubleExample = 1.98732; // in C#, decimals are implicitly double
            decimal decimalExample = 1.4573289758358735837m; //these are large decimals or where you need to be precise

            //string variables
            char letter = 'j'; //can only hold a single character (compile down to a single charaver ie /n 

            //--Operators

            int numOne = 17;
            int numTwo = 5;

            int sum = numOne + numTwo;
            Console.WriteLine(sum);
            int diff = numOne - numTwo;
            Console.WriteLine(diff);
            int prod = numOne * numTwo;
            Console.WriteLine(prod);
            int quot = numOne / numTwo; //this shows at 3 since it is integer value it is dropping the decimal values
            Console.WriteLine(quot);
            int remainder = numOne % numTwo;
            Console.WriteLine(remainder);

            Console.WriteLine("Hello");
            
           
                      
        }
        [TestMethod] //this is an annotation so that VSC can see the test method

        public void ReferenceTypes()
        {
            //--strings are any characters inside characters

            string stringExample = "This is a string.";
            string name = "Joshua";
            string declared;
            declared = "Now it's initialized.";
            //formatting string

            string concatenate = stringExample + " " + name;
            string interpolate = $"{name}. Here is the string: {stringExample}";
            Console.WriteLine(concatenate);
            Console.WriteLine(interpolate);

            //-- Other Object Examples
            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            DateTime randomDate = new DateTime(2019, 6, 29);
            TimeSpan waitTime = randomDate - now; //TimeSpan is a type
            Console.WriteLine(waitTime.TotalSeconds);

            //Collections -- this is category of reference types //

            //arrays  this is a record strucure these can be limiting so they are not used often in C#

            string anotherExampleString = "Hello World";
            string[] stringArray = { anotherExampleString, "Henlo", "World", "!" };
            string[] students = new string[15];

            Console.WriteLine(students);

            //Lists
            List<string> listOfStrings = new List<StringSplitOptions>();
            listOfStrings.Add("Lawrence");

            // Queues
            Queue<string> firstInfirstOut = new Queue<string>();
            firstInfirstOut.Enqueue("Luke");

            // Dictionaries
            Dictionary<char, string> keyValuePair = new Dictionary<char, string>();
            keyValuePair.Add('j', "Josh");

            //Other Collections
            SortedList<int, string> sortedKeyValuePair = new SortedList<int, string>();
            Stack<string> firstInLastOut = new Stack<string>();


        }
    }
}
