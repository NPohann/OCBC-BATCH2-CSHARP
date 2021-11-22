using System;

namespace hitungnilai4
{
    class HitungNilai4
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Password: ");
            string password = Console.ReadLine();

            bool isAdult = age > 18;
            bool isPasswordValid = password == "OCBC";

            // menggunakan logika AND
            if(isAdult && isPasswordValid)
            {
                Console.WriteLine("WELCOME TO THE CLUB!");
            }
            else
            {
                Console.WriteLine("Sorry, try again!");
            }
        }
    }
}
