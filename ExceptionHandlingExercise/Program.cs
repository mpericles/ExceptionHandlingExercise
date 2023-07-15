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
            // First create an char[], it must contain 6 numbers and 3 letters - name it arr
            // Create a list called numbers that will hold integers
            // Create an string variable with an empty string initializer - name it str
                      
            char[] arr = { 'A', 'B', 'C', '1', '2', '3', '4', '5', '6' };
            List<int> numbers = new List<int>();
            string str = string.Empty; // best pratice to initialize a string this way same as string str = " "
            Console.WriteLine("The Array before the Parsing");
            foreach (var item2 in arr)
            {
                Console.WriteLine(item2);
            }



            //TODO START HERE:

            // using a foreach loop, attempt to parse the elements in your char[] with int.Parse()
            // and Exceptions will be thrown 
            // Below we will set this up 
            // ------------------------------------------------------------------------------

            // Make a foreach loop to iterate through your character array
            // Now create a try catch


            // Inside your try block
            // set your string variable to each array element in your char[] to .ToString()
            // Now, using int.Parse, parse your string variable and store in an int variable
            // Then add each int to your list

            // catch your Exception:
            // in the scope of your catch you can use the following, 

            //Console.WriteLine($"Unable to Parse '{character}'"); //character will be the name of each item in your collection



            //foreach (var num in numbers)
            //{
            //    Console.WriteLine(num);
            //}

            // Make a foreach loop to iterate through your character array
            Console.WriteLine();
            Console.WriteLine("Output of the Exception Handling");
            foreach (var item in arr)
            {
                // Now create a try catch
                try // Try block
                {
                    // Inside your try block
                    // set your string variable to each array element in your char[] to .ToString()
                    // Now, using int.Parse, parse your string variable and store in an int variable
                    // Then add each int to your list

                    //str += item;  provided by intellisense
                    //str = arr.ToString(); This is an incorrect statement to use as all the items would be viewed as strings
                    //and I was looking at the wrong variable to step thru the arr of items
                    str = item.ToString(); // Taking the items in the arr and putting them into a string
                    int num = int.Parse(str); // This works as the arr was an arr of characters including the numnbers
                    numbers.Add(num); // This works as we are taking the "interger" and adding them to the interger list 
                    //The 2 statements above could be combined as follows numbers.Add(int.Parse(str));
                }
                catch (Exception) //catch block 
                {
                    // catch your Exception:
                    // in the scope of your catch you can use the following, 
                    //Console.WriteLine($"Unable to Parse '{character}'"); //character will be the name of each item in your collection
                    Console.WriteLine($"Unable to Parse '{item}'"); //character will be the name of each item in your collection

                   // throw;
                }
                
                }
            Console.WriteLine();
            Console.WriteLine("List of items that was able to be parsed");
            foreach (var num in numbers)
            {
                Console.WriteLine(num);

            }

    }
}

}