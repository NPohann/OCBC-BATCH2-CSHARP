using System;

public class Palindrome{
    public static void Main(){

        string kata;
        string reversed = "";

        Console.Write("Enter a Word: ");
        kata = Console.ReadLine();

        for(int i = kata.Length-1; i >=0 ; i--){
            reversed = reversed + kata[i];
        }

        if(kata.Equals(reversed))
            Console.WriteLine("Palindrome");
        else
            Console.WriteLine("Not Palindrome");
    }
}