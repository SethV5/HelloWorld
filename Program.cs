﻿using System;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Tell me whats going onin the console as it boots up:
            // Console.WriteLine("Hello There World!");
            // Waiting for user input:
            // Console.ReadLine();
            // Declaring variable "Input":
            // string input = Console.ReadLine();
            // Print to console what i type:
            // Console.WriteLine(input);
            // Output this to user:
            Console.WriteLine("Write Two Numbers");
			// Made and declared two variables:
			// string number1 = Console.ReadLine();
			// string number2 = Console.ReadLine();
			// Printing out variable number1:
			// Console.WriteLine(number1);
			// Printing out variables: number1 and number2:
			// Console.WriteLine(number1 + " " + number2);
			// let my variable number1 be equal to an integer number:
			// int number1 = Console.ReadLine();
			// int number2 = Console.ReadLine();
			// If i want to take decimals into consideration i can use this:
			// float number1 = Console.ReadLine();
			// This command: Console.ReadLine(); expects to get a "string" as an input 
			// Changed variables into a float value:
			// float number1 = Console.ReadLine();
			// float number2 = Console.ReadLine();
			// Made our variable into a float:
			// float number1 = float.Console.ReadLine();
			// float number2 = float.Console.ReadLine();
			// Now to parse something is to analys a string of symbols, either in natural language or in computer languages, and converts it into an outputed number.
			float number1 = float.Parse(Console.ReadLine());
			float number2 = float.Parse(Console.ReadLine());
            // Print it to user:
            // Console.WriteLine(number1 + " " + number2);
            // to add out two numbers we can do this:
            // Console.WriteLine(number1 + number2);
            // We can also subtract:
            //Console.WriteLine(number1 - number2);
            // Clicking ona  variable will highlight where that variable comes up, can help if it is misspeltor something of the sort for debugging. Like how you can click on the closing brackets and it will highlight the respectivve opening bracket for you.
            // Methods or functions() like in javascript:
            // Made a line to CALL and DISPLAY my public method named AddTwoNumbers
            // Console.WriteLine(AddTwoNumbers());
            // what are the values? or the argument?
            Console.WriteLine(AddTwoNumbers(number1, number2));
            
        } // This is the closing bracket for the first method called "Main"
                          // This is the name of the method    
        public static float AddTwoNumbers(float n1, float n2)
//          ^ |      |    ^                 ^    ^
// means      |      | Not void             Declares the type of variable: float
// it's       |      | becasue it           the name of the variable "n1"
// accessible |      | is returning
// Anywhere   |      | a value
        // The issue is saying that i dont have code that can give the method a value
        {
            // Made a variable that is a float and adds our n1 and n2 variables.
            float result = n1 + n2;
            // returns the resul of variable "result"
            return result;
        }   
    
    }
}
