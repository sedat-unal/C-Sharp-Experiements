using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using System means that we can use classes from the System namespace.

namespace Tutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            //print something
            Console.WriteLine("Hello World!");

            //This is a comment
            //Console.WriteLine("Hello World!");

            Console.WriteLine("Hello World!"); //this is a comment

            /* 
             This
                is
                  multiline
                           Comment
             */


            /* 
             **** VARIABLES ****
                int - stores integers (whole numbers), without decimals, such as 123 or -123
                double - stores floating point numbers, with decimals, such as 19.99 or -19.99
                char - stores single characters, such as 'a' or 'B'. Char values are surrounded by single quotes
                string - stores text, such as "Hello World". String values are surrounded by double quotes
                bool - stores values with two states: true or false
             
             **** DECLARING VARIABLES ****
             *type variableName = value;
             
             */

            //example
            /*
            string name = "Sedat";
            Console.WriteLine(name);

            int myAge = 23;
            Console.WriteLine(myAge);

            int myNum;
            myNum = 7;
            Console.WriteLine(myNum);

            int a = 15;
            a = 20; // a is now 20
            Console.WriteLine(a); */


            //const int b = 15; //if the variableName define with 'const' that means value never change.

            /*  DISPLAY VARIABLES  */
            /*
            string name = "Sedat";
            Console.WriteLine("Hello " + name);

            string firstName = "Sedat";
            string lastName = "Unal";
            string fullName = firstName + lastName;
            Console.WriteLine(fullName);

            int x = 5;
            int y = 6;
            Console.WriteLine(x + y); //Print the value of x + y which is 11

            int a = 4, b = 5, c = 6;
            Console.WriteLine(a + b + c);
            */

            /* IMPLICIT - EXPLICIT CASTING */
            /*
            //IMPLICIT
            int myInt = 9;
            double myDouble = myInt;
            Console.WriteLine(myInt); //Outputs 9
            Console.WriteLine(myDouble); //Outpust 9
            
            //EXPILICIT
            double myDouble1 = 9.78;
            int myInt1 = (int)myDouble1;
            Console.WriteLine(myDouble1); //Outputs 9.78
            Console.WriteLine(myInt); //Outputs 9
            */

            /* TYPE CONVERSION METHODS */
            /*
            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;
            Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
            */

            /* GET USER INPUT */
            // Console.ReadLine();
            /*
            Console.WriteLine("Enter username : ");
            string userName = Console.ReadLine();
            Console.WriteLine("Username is : " + userName);

            // for getting int or number something
            Console.WriteLine("Enter your age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is : " + age);
            */

       }
    }
}
