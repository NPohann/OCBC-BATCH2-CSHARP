using System;

public class Soal5{
    public static void Main(){
        string angka;
        int index;
        string conversion = "";

        string[] nama = new string[10] {
            "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"
        };

        Console.Write("Enter the number: ");
        angka = Console.ReadLine();

        for(int i = 0; i < angka.Length; i++){
            index = int.Parse(angka[i].ToString());
            conversion = conversion + " " + nama[index] + " ";
        }

        Console.Write(conversion);
    }
}