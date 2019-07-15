
/*
	LoopExamples.cs
	Created by: Jo Suh
	Created on: July 2019
 	Created for: educational purposes
	
	Includes introductory notes to C# and
	examples of various loops

*/


using System; 

namespace HelloWorld
{
    public class MyClass
    {
    	
		public static void Main(string[] args)
        {
            //The main method
			
			//Loops
			
			//while loop ----------------------------------------------------
           	Console.WriteLine();
			
			int a = 1;
         	while (a < 3) {
          	  Console.WriteLine(a);
          	  a++;
        	 }
			
			
			//for loop ----------------------------------------------------
           	Console.WriteLine();
			
			for (int b = 0; b < 3; b += 1)
            	Console.WriteLine(b);
			
			
			//Do...while loop ----------------------------------------------------
           	Console.WriteLine();
			
			int c = 4;
         	do {
         		Console.WriteLine(c);
           		c -= 1;
     	   	} 
         	while (a > 3);
			
			
			//nested loop ----------------------------------------------------
           	Console.WriteLine();
         
       		for (int d = 5; d < 5; d++) {
          	  for (int e  = 0; e <= d; e++)
          		  if ((d % e) == 0)
					  Console.WriteLine(d % e);
        	}
			
			
			//switch statements ----------------------------------------------------
           	Console.WriteLine();
			
			String f = "A String";
			switch (f){
				case "A" : 
					break;
				case "A String":
					Console.WriteLine(f);
					break; //need to break after each case
					// cannot fall through various cases
				default:
					Console.WriteLine("default");
					break; //need to break after even the default case
			}

			
			//inifinite loop exeample ----------------------------------------------------
           	Console.WriteLine();
			//When the conditional expression is absent, it is assumed to be true
			
			for (; ; ) {
				//an infinite loop
            	Console.WriteLine("forever ");
         	}
		}
    }
}


/*
	Sample output:
	
	1
	2

	0
	1
	2

	4


	A String

	forever 
	forever 
	forever 
	forever
	.
	.
	.
	.
	
*/
