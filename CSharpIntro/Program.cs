using System;

namespace CSharpIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // make bool, string, and int variable with values
            bool b = true;
            string s = "hello";
            int a = 10;

            //change their values to something else
            b = false;
            s = "goodbye";
            a = 20;

            //print their values with console
            Console.WriteLine(b);
            Console.WriteLine(s);
            Console.WriteLine(a);
            //do something in a for loop
            for (int u = 0; u < 10; u++)
            {
                Console.WriteLine(u);
            }
            //do something in a while loop
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }
            //do something with switch statement
            int n = 9;
            switch (n)
            {
                case 0:
                    Console.WriteLine("0");
                    break;
                case 9:
                    Console.WriteLine("9");
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }
            //do something with if, else if, else
            int x = 4;
            int y = 5;
            if (x < y)
                Console.WriteLine("x is less than y");
            else if (x > y)
                Console.WriteLine("x is greater than y");
            else
                Console.WriteLine("x = y");

            //figure out how to make multi line comments in C#
            /*testing multi line comments
            
            still testing
            
            test complete
             */
            //figure out how to format your document in VS Code
            // formatting is shift + alt + F

            //extra: make new static method to do something and call it
            static int add(int x, int y)
            {
                return x + y;
            }
            int z = add(10, 20);
            Console.WriteLine(z);
            //extra: learn what "var" means in C# and try it out
            //var is implicitly typed variables

            var l = 5;
            Console.WriteLine(l);
            var m = "hello";
            Console.WriteLine(m);
            var j = 5.0;
            Console.WriteLine(j);
        }
    }
}
