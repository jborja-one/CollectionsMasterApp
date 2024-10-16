﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

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
            Array.Reverse(numbers);
            Console.WriteLine("---------REVERSE CUSTOM------------");

            Console.WriteLine("-------------------");

            //DONE: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");


            Console.WriteLine("-------------------");

            //DONE: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(numbers);

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


            //DONE: Print the new capacity
            Console.WriteLine(numbersList.Capacity);

            Console.WriteLine("---------------------");

            //DONE: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            //! resolved in line 119, number checker
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numbersList);
            Console.WriteLine("-------------------");


            //DONE: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            //! resolved in line 115, number checker
            Console.WriteLine("------------------");

            //DONE: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            numbersList.Sort();
            Console.WriteLine("------------------");

            //DONE: Convert the list to an array and store that into a variable
            numbersList.ToArray();

            //TODO: Clear the list
            numbersList.Clear();

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for(int i = 0; i < numbers.Length; i++) {
                if (numbers[i] % 3 == 0) {
                    numbers[i] = 0;
                }
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            var result = numberList.Where(n => n % 2 == 0);
            Console.WriteLine($"{result}");
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if (numberList.Contains(searchNumber)) {
                Console.WriteLine($"The number {searchNumber} is already present in the list");
            } else {
                Console.WriteLine($"Your number {searchNumber} has been added to the list");
            }
        }

        private static void Populater(List<int> numberList)
        {
            Random random = new Random();

            for (int i = 0; i < 50; i++)
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

        private static void ReverseArray(int[] array)
        {
            int length = array.Length;

            for (int i = 0; i < length / 2; i++)
            {
                int mark = array[i];
                array[i] = array[length - 1 - i];
                array[length - 1 - i] = mark;
            }
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
