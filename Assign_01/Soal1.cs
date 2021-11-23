using System;

public class Soal1
{
    public static void Main(){
        int i, j, k, l;
        char alf = 'A';
        int range;
        Console.Write("Enter the Range = ");
        range = int.Parse(Console.ReadLine());

        for(i=1;i<=range;i++){
            for(j=range;j>=i;j--)
                Console.Write(" ");
            for(k=1;k<=i;k++)
                Console.Write(alf++);
            alf--;
            for(l=1;l<i;l++)
                Console.Write(--alf);
            Console.Write("\n");
            alf='A';
        }
    }
}