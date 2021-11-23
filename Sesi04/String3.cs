using System;

public class String3{
    public static void Main(){
        string[] str = { "Ini", "adalah", "sebuah", "test" };
        Console.WriteLine("Array asli: ");

        for(int i = 0; i < str.Length; i++){
            Console.Write(str[i] + " ");
        }
        Console.WriteLine("\n");

        str[1] = "merupakan";
        str[3] = "test, juga!";
        Console.WriteLine("Array termodifikasi: ");

        for(int i = 0; i < str.Length; i++)
            Console.Write(str[i] + " ");
    }
}