using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHi("Mike", 33);
            SayHi("John", 22);
            SayHi("Tom", 18);

            Console.ReadLine();
        }

        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age);

        }

    }
}
