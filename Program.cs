﻿using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

// why does the font here suck
namespace Quickstart_C_
{
     // what does internal mean?
    internal class Program
    {

        // temp is just a container for my old code
        void temp()
        {
            Console.WriteLine("hello world"); // the `Console` function is from system

            //if you did not `import` system, you still do this
            // importing system is bascially the same as include <bits.cpp/h> in c++

            System.Console.WriteLine("hello world");


            int age = 40;
            long big_number = -90_000_000L; // L at the back tells the complier that i want a long
            double floating_point = 1.00;
            float precision = 3.14F; // F is for float
            decimal money = 10.00M; // M for decimal. Decimals are like floats and double, but avoid the floating point addition error at the cost of speed

            string hello = "hello"; // str must have double quotation
            char a = 'a'; // char have single quotes
                          // chars cannot be empty

            bool value = true;

            // const for constants as usual...
            const double pi = 3.142;




            // you can declare multiple vars at the same time

            // int x, y, z;

            int x = 10,
                y = 10,
                z = 10;

            // same as auto keyword in c++
            // prefer `proper` static typing
            var variable = 10;

            // conversion of types

            string myage = "15";
            age = System.Convert.ToInt32(myage);

            myage = "15000";
            big_number = Convert.ToInt64(myage);

            // float is a single LOL
            precision = Convert.ToSingle(myage);


            // opertators
            // context: age is an int, hello is a str


            // both methods have the same time complexity

            // age++ will return age,                ++age will return age + 1
            // so, int a = age++;                    so, int a = age ;
            // will make the value a = age;          will make the value of a = age + 1;


            age++; // same as c++
            age--; // same as c++

            age += 1;
            age -= 1;

            // reminder that ints truncates
            age /= 10; // this may give you a trunction
            age *= 10;

            // there's also a mod operator (%)




            // strings can contataate
            hello += " world";

            // char will add the unicode values 




            // conditionals

            if (value)
            {
                Console.Write("The value of var value is:");
                Console.WriteLine(value);
            }


            Console.WriteLine(hello);

            Console.ReadLine();

        }

        static void Main(string[] args)
        {
            /*
            int number;
            bool isodd;

            Console.WriteLine("Enter a number");
            number = Convert.ToInt32(Console.ReadLine());


            isodd = Convert.ToBoolean(number % 2);

            
            //Conditionals: 
            //Comparisons: == >= <= !=
            //And/ or values: && || 
            
            if (isodd)
            {
                // here is a method of string formatting
                Console.WriteLine("value is odd. Value:" + number);
            }
            else if (true)
            {

                Console.WriteLine("value is even");
            }
            */



            //Console.ReadLine();


            /*
            int num1, num2;

            int answer_provided;

            Console.Write("Enter a number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter a number:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is the answer? ");
            answer_provided = Convert.ToInt32( Console.ReadLine());
            
            */

            //int repeat_times;



            /*
            while (true)
            {
                Console.Write("enter range");
                repeat_times = Convert.ToInt32(Console.ReadLine());

                // this write 0 - 9 (Similar to range(10)
                for (int i = 0; i < repeat_times; i++)
                {

                    Console.WriteLine(i);

                }
              
            }
            */

            // shorthand if statements

            // x if true else false: python
            // true ? x : false

            /*
            int check;
            Console.WriteLine("gimme a number (1/0)");
            check = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine(check != 0 ? "true": "false");
            */

            // now, let's move on to string formatting


            /*
            double cash = 12.345;

            string msg = $"I have {cash:0.00} amount of cash";

            string raw = @"C:\Users\thacu";

            string hello = @"Hello john, say ""hi"" to the camera"  ;
            hello = "Hello john, say \"hi\" to the camera";

            msg.Equals(raw); // This checks only the content, not the type
            
            // to put ref to python, == acts the same way as in python
            // msg = "he"
            // msg.Equals(["h","e"]) // this returns true


            Console.WriteLine(msg);

            */
            /*
             Tryparse func


            int num;
            string temp;

            Console.WriteLine("Enter a number");
            temp = Console.ReadLine();
            while  (!int.TryParse(temp, out num)) {
                Console.WriteLine("Try again");
                temp = Console.ReadLine();
            }

            for (int i = num; i <= num * 10 ; i+= num)
            {
                Console.WriteLine(i);                
            }
            */


            // ARRAYS
            // ARRAYS are static data. They are NOT lists
            // {} is used a bit like how [] is used in python
            // a string is an array of chars

            char[] abc = { 'a', 'b', 'c' };

            int[] numbers = new int[3]; // empty array
            numbers = new int [] { 3, 2, 1 }; // defined array
                
            // Sort array
            Array.Sort(numbers);

            Array.Reverse(numbers);

            int length = numbers.Length; // this returns the int length of the array
            
            Array.IndexOf(numbers, numbers[0]);

            // LISTS
            List<int> list = new List<int>() {1,2,3,4,5 };

            int list_length = list.Count();

            list.Remove(list.IndexOf(3)); // this will remove number 3 from the list    

            list.Add(0); // append in python


            foreach (int i in list)
            {
                
            }




            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("enter a number");
                numbers[i] = Convert.ToInt32(Console.ReadLine());

            }

            if (numbers.Sum() == 180)
            {
                Console.WriteLine("Triangle valid");
            }

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }




            Console.ReadLine();

            // continue video at current time. https://youtu.be/YrtFtdTTfv0?t=14578

        }
    }
}