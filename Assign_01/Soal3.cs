using System;

public class Soal3{
    public static void Main(){
        int angka;
        int faktorial = 1;

        Console.Write("Enter any number: ");
        angka = int.Parse(Console.ReadLine());

        for(int i = angka; i >= 1; i--){
            faktorial = faktorial * i;
        }

        Console.Write($"Factorial of {angka} is {faktorial}");
    }
}