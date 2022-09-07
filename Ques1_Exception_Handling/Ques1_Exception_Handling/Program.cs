using System;

namespace Ques_Age
{
    class AgeException : Exception
    {
        public AgeException(String message) : base(message) { }
        
    }
    class AgeCheck
    {
        int age;
        public AgeCheck(int age)
        {
            this.age = age;

        }
        public void ShowAge()
        {
            if (age < 20)
                throw new AgeException($"Invalid age: ({age}) -> less than 20");
            else
                Console.WriteLine("Your age is a Valid age {0} ", age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            AgeCheck abc = new AgeCheck(age);

            try
            {
                abc.ShowAge();
            }
            catch (AgeException a)
            {
                Console.WriteLine(a);
            }           
        }
    }
}

