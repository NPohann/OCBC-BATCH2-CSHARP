using System;

public class Soal2{
    public static void Main(){
        int i, j, k, l;
        int angka = 1;
        int range;
        Console.Write("Enter the Range = ");
        range = int.Parse(Console.ReadLine());

        for(i=1;i<=range;i++){
            for(j=range;j>=i;j--)
                Console.Write(" ");
            for(k=1;k<=i;k++)
                Console.Write(angka++);
            angka--;
            for(l=1;l<i;l++)
                Console.Write(--angka);
            Console.Write("\n");
            angka = 1;
        }
    }
}