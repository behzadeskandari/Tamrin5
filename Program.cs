using System;

namespace Tamrin5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Arz");
            int Arz = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Tooal");
            int Tooal = Convert.ToInt32(Console.ReadLine());


            Rectangle rectangle = new Rectangle(Tooal,Arz,true);

            rectangle.GetResults();

            Console.WriteLine(rectangle.Masahat);

        }
    }
}
