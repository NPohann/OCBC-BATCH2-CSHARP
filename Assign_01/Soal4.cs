using System;

public class Soal4{
    public static void Main(){
        string reversed = "";
        string angka;

        Console.Write("Enter a number: ");
        angka = Console.ReadLine();


        for(int i = angka.Length-1; i >= 0; i--){
            reversed = reversed + angka[i];
        }
        Console.WriteLine("Reversed Number: " + reversed);
    }
}