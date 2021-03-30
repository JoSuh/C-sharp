/*
HelloWorld.cs
Created by: Jo Suh
Created on: July 2019
Created for: educational purposes
	
	
	A "Hello World!" program in C#.
	This program displays the string "Hello World!" on the screen
	through usages of Console.WriteLine() and Console.Write().
	
	Includes introductory notes to C# and
	examples of various output methods
*/

// C# ends lines with a semicolon(;), just like Java
// using: keyword for import statement


using System; 
/* import System so we can shorten the code
	for instance,
		System.Console.WriteLine("Hello World!");
	can be reduced to
		Console.WriteLine("Hello World!");
	as Console class is part of the System
*/

/* Can include a namespace in a program through the syntax:
	using NamespaceName;
*/

/* Namespaces:
	help organize code and prevent name clashes
	similar to folders, and can be nested
*/

namespace Functions
{
	// class definitions in C# is just like in Java
	public class SampleClass
	{
		public static void printOut()
		{
			// Prints out various lines on the console
			Console.WriteLine("Hello World"); // = System.out.println();
			Console.Write("The 'nextline' is"); // != System.out.print();
			Console.Write("non-existant");
			
			/*
				Console.WriteLine("x");
				-> "x" + newline
				
				Console.Write("x");
				-> "x"
			*/
			
		}
		
		public static String getInput()
		{
			// Asks, reads, and returns input from the user
			
			
			// '\n' = newline character
			// add a new line since the last line was Console.Write();
			Console.Write("\nEnter a text: ");
			
			
			// Reads input
			String userInput = Console.ReadLine();
			
			return userInput;
		}
	}
}


//This will be the main 'program' to call the function to print the lines
namespace HelloWorld
{
    public class MyClass
    {
    	
		public static void Main(string[] args)
        {
            //The main method
			// The args argument stores command line arguments
			Functions.SampleClass.printOut();
			
			// 'var' only works for local variables
			var userInputReceived = Functions.SampleClass.getInput();
			int x = 1;
			Console.WriteLine("{0}. You entered in: {1}", x, userInputReceived);
			/*
				Use '{n}' for indicating the 'n-th' thing to be printed out
				count from 0 like the proper programmer you are
			*/
			
			Console.WriteLine("The variable is of type: " + userInputReceived.GetType());
        }
    }
}


/*
	Sample output:
	
	Hello World
	The 'nextline' isnon-existant
	Enter a text: 5
	1. You entered in: 5
	The variable is of type: System.String
	
*/