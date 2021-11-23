using System;

class String4{
    static void Main(){
        string stringawal = "C# membuat string mudah.";

        // Menciptakan sebuah subtring.
        string substr = stringawal.Substring(5, 12);

        Console.WriteLine("stringawal: " + stringawal);
        Console.WriteLine("substring: " + substr);
    }
}