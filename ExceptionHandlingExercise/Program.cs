using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------------
            // Objective: Iterate through a character array. Try to parse each character into an integer.
            // If you attempt to parse a letter into an integer, an exception will occur. 
            // Use a try-catch statement to avoid a run-time exception.
            // Below we will set this up.
            // ------------------------------------------------------------------------------



            //TODO START HERE:

                    // 1) Create an char[], it must contain 6 numbers and 3 letters - name it arr

            char[] arr = { '1', '2', '3', '4', '5','6', 'x', 'y', 'z' };


                     // 2) Create a list called numbers that will hold integers

            List<int> numbers = new List<int>();

                    // 3) Create a string variable with an empty string initializer - name it str

            string str = "";

                    // 4) Make a foreach loop to iterate through your character array
                

            foreach (var item in arr)
            {

                try   // Note***: Try-Catch loop allows the app to continue to run without stopping when it finds an exception

                            // 5) Create a try-catch inide of your foreach loop
                            // 6) Inside the try block: 
                            // 7) Set your string variable to each array element in your char[] to .ToString()
                            // 8) Now, using int.Parse, parse your string variable and store in an int variable
                            // 9) Then add each int to your list
                {
                    str = item.ToString();  // Note*** Important that the prefix of the ToString() statment is the name used in the "foreach" loop
                    int vary = int.Parse(str);
                    numbers.Add(vary);
                }

                            // 10) Inside the catch block:
                            // 11) In the scope of your catch you can use the following code:                  
                            // Console.WriteLine($"Unable to Parse '{character}'"); //character will be the name of each item in your collection


                catch (Exception something)   // Note*** here you should use the type "exception" and name it.  in this case, "something."  This allow you to potentially do something else with your exceptions.
                {
                    Console.WriteLine($"Unable to Parse '{i}'");
                }
                
            }

            foreach (var num in numbers)   // Note *** this prints each "num" added to the numbers list.
            {
                Console.WriteLine(num);
            }

           

            


            // Uncomment the code below to see the numbers you successfully added to the numbers list: 


        }
        }

    }
