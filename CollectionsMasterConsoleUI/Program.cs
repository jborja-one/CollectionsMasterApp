using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //DONE: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //DONE: Create an integer Array of size 50
            int[] numbers = new int[50];

            //DONE: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(numbers);
            //DONE: Print the first number of the array
            Console.WriteLine(numbers[0]);
            //DONE: Print the last number of the array
            Console.WriteLine(numbers[numbers.Length - 1]);

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numbers);
            Console.WriteLine("-------------------");

            //DONE: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____();
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Console.WriteLine("All Numbers Reversed:");
            Console.WriteLine("---------REVERSE CUSTOM------------");

            var reversedNumbers = ReverseArray(numbers);

            Console.WriteLine(string.Join(",", reversedNumbers));

            //DONE: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("All Threes to zero");
            Console.WriteLine("---------THREE KILLER------------");
            var noThrees = ThreeKiller(numbers);
            Console.WriteLine(string.Join(",", noThrees));


            Console.WriteLine("-------------------");

            //DONE: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");

            var sortedNumbers = SortArray(numbers);
            Console.WriteLine(string.Join(",", sortedNumbers));

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //DONE: Create an integer List
            List<int> numbersList = new List<int>();

            //DONE: Print the capacity of the list to the console
            Console.WriteLine(numbersList.Capacity);

            //DONE: Populate the List with 50 random numbers between 0 and 50 you will need a method for this

            Populater(numbersList);
            //DONE: Print the new capacity
            Console.WriteLine(numbersList.Capacity);

            Console.WriteLine("---------------------");

            //DONE: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            var checkNumber = NumberChecker(numbersList, 15);
            Console.WriteLine(checkNumber);

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numbersList);
            Console.WriteLine("-------------------");


            //DONE: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            var evensOnly = OddKiller(numbersList);
            NumberPrinter(evensOnly);
            Console.WriteLine("------------------");

            //DONE: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            var sortedList = SortList(evensOnly.ToList());
            NumberPrinter(sortedList);
            Console.WriteLine("------------------");

            //DONE: Convert the list to an array and store that into a variable
            numbersList.ToArray();

            //TODO: Clear the list
            numbersList.Clear();

            #endregion
        }

        public static List<int> SortList(List<int> numbers)
        {
            // Create a copy of the list to avoid modifying the original
            List<int> sortedNumbers = new List<int>(numbers);

            // Sort the list
            sortedNumbers.Sort();

            // Return the sorted list
            return sortedNumbers;
        }

        public static int[] SortArray(int[] numbers)
        {
            // Create a copy of the array to avoid modifying the original
            int[] sortedNumbers = (int[])numbers.Clone();

            // Sort the array
            Array.Sort(sortedNumbers);

            // Return the sorted array
            return sortedNumbers;
        }

        private static int[] ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }
            return numbers;
        }

        private static int[] OddKiller(List<int> numberList)
        {
            var result = numberList.Where(n => n % 2 == 0);
            return result.ToArray();
        }

        private static string NumberChecker(List<int> numberList, int searchNumber)
        {
            if (numberList.Contains(searchNumber))
            {
                return $"The number: {searchNumber} is already present in the list";
            }
            else
            {
                return $"Your number: {searchNumber} is not on the list";
            }

        }

        private static void Populater(List<int> numberList)
        {
            Random random = new Random();

            for (int i = 0; i < 51; i++)
            {
                int randomNumber = random.Next(0, 51);
                numberList.Add(randomNumber);
            }

        }

        private static void Populater(int[] numbers)
        {
            Random random = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(0, 51);
            }

        }

        private static int[] ReverseArray(int[] array)
        {
            int[] reversedArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                reversedArray[i] = array[array.Length - 1 - i];
            }
            return reversedArray;
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
