using System;

namespace DogApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = null;
            try
            {
                //in the try block, you put the code that you think may throw an exception that you can handle here
                dog = new Dog(null, -1);

                //in c#, we have "block scope"
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("error, recovering");
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine("error, recovering");
                dog = new Dog("Spot", 5);
            }
            dog.SetName(null);
            dog.SetAge(-5);
        }
    }
}
