using System;

class Logika3
{
    public static void Main()
    {
        string Username;
        string Password;

        //digunakan untuk menginput, isikan username = ocbc dan password = bootcamp
        Console.Write("Username: ");
        Username = Console.ReadLine();
        Console.Write("Password: ");
        Password = Console.ReadLine();

        if(Username == "ocbc" && Password == "bootcamp")
            Console.WriteLine("Anda berhasil login");
        
        else
            Console.WriteLine("Username atau Password anda salah");
    }
}