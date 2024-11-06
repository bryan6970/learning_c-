using System;
using System.Collections.Generic; // for lists, dict
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;


// why does the font here suck
namespace Quickstart_C_
{
    // what does internal mean?
    internal class Program
    {

        // temp is just a container for my old code
        static void temp()
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

        static void test()
        {
            arrays_lists_dicts();
        }

        static void arrays_lists_dicts()
        {

            // ARRAYS
            // ARRAYS are static data. They are NOT lists
            // {} is used a bit like how [] is used in python
            // a string is an array of chars

            char[] abc = { 'a', 'b', 'c' };

            int[] numbers = new int[3]; // empty array
            numbers = new int[] { 3, 2, 1 }; // defined array

            // Sort array
            Array.Sort(numbers);

            Array.Reverse(numbers);

            int length = numbers.Length; // this returns the int length of the array

            Array.IndexOf(numbers, numbers[0]);

            // LISTS
            List<int> list = new List<int>() { 1, 2, 3, 4, 5 };  // the value inside the () reserves memory

            int list_length = list.Count();

            list.Remove(list.IndexOf(3)); // this will remove number 3 from the list    

            list.Add(0); // append in python


            foreach (int i in list)
            {
                // Console.WriteLine(i);
            }

            // DICTS (this is not a json, it's a dict. Keys cannot be duplicated)
            int key = 0;
            int index = 0;
            string value = "Hello";

            Dictionary<int, string> dict = new Dictionary<int, string>();

            dict.Add(key, value);



            // dict.ElementAt() get's the index
            KeyValuePair<int, string> key_value_pair = dict.ElementAt(index); // you can also use var instead of being so explicit

            value = dict[key];

            dict.TryGetValue(key_value_pair.Key, out value);
        }

        static void welcomeMessage(string message)
        {
            Console.WriteLine(message);
        }

        static string getMessage()
        {
            return "Welcome";
        }


        static int add(int x, int y)
        {
            return x + y;
        }

        static bool multiplyByTwo(int num, out int output)
        {
            output = 0;
            try
            {
                output = Convert.ToInt32(num);
                return true;
            }
            catch (Exception)
            {

                return false;
            }


        }

        static void assignHello(ref string name) {

            // you should use ref when you need to read the initial value. Else, use `out`.
            Console.WriteLine(name);

            name = "Hello";
        }

        static bool findIndex(string item_to_search, List<string> list, out int index)
        {
            index = -1;

            for (int i = 0; i < list.Count(); i++)
            {
                if (item_to_search.ToLower().Equals(list[i].ToLower()))
                {
                    index = i;
                    return true;
                }
            }
            return false;
        }

        static double findTriangleArea(double width, double height)
        {
            return width * height / 2;
        }

        static int findArraySum(int[] arr)
        {
            int sum = 0;
            foreach (var num in arr)
            {
                sum += num;
            }

            return sum;
        }

        static bool intTryParse(string input, out int result)
        {
            result = 0;
            try
            {
                result = int.Parse(input);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
           
        }

        struct PersonStruct // not really a class. 
        {

            // define vars first
            public string name { get; private set;} // getting the var is public (defined by the public keyword), setting the var is private
            public int age;


            

            public PersonStruct(string name, int age=0) // this is a constructor, params are not mandatory. Temporary vars are allowed
            {
                this.name = name; 
                this.age = age;
            }
            public PersonStruct(string name, int age , int other) // overloading is allowed
            {
                this.name = name;
                this.age = age;

                if (other != 0)
                {
                    Console.WriteLine("Used overloading func");
                }
            }

            
        }

        class PersonClass
        {
            public string name;
            public int age;

            PersonClass(string name , int age=0)
            {
                this.name = name;
                this.age = age;
                
            }
            PersonClass(string name, int age, bool overload = true)
            {
                this.name = name;
                this.age = age;

                if (overload)
                {
                    Console.WriteLine($"Overload used in {this.GetType().Name}");
                }
            }
        
            public string GetName()
            {
                return name; // name is local to the class
            }

            public int GetAge()
            {
                GetName();
                return age;
            }
        }

        static void Main(string[] args)
        {
            // Static means that the function can be used without creating an instance of the parent class. 
            // Public means that a function can be used outside of the parent clsas

            welcomeMessage(getMessage());
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

            add(y:1, x:2);  // named params, like send(message="Hi"), becoming send(message:"Hi");

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

            PersonStruct me = new PersonStruct();

            Console.WriteLine($"I am {me.name} and my age is {me.age}");







            Console.ReadLine();

            // continue video at current time. https://youtu.be/YrtFtdTTfv0?t=23160

        }
    }
}
