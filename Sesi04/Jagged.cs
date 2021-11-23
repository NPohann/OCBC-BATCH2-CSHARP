using System;

public class Jagged
{
    public static void Main()
    {
        int[][] jagged = new int[3][];
        jagged[0] = new int[4];
        jagged[1] = new int[3];
        jagged[2] = new int[5];
        int i;

        // Menyimpan nilai-nilai dalam array pertama, kedua, dst.
        for(i=0; i<4; i++)
            jagged[0][i] = i;
        
        for(i=0;i<3;i++)
            jagged[1][i] = i;

        for(i=0;i<5;i++)
            jagged[2][i] = i;

        // Menampilkan nilai-nilai pada array pertama, kedua, dst.
        for(i=0;i<4;i++)
            Console.Write(jagged[0][i] + " ");
        Console.WriteLine();

        for(i=0;i<3;i++)
            Console.Write(jagged[1][i] + " ");
        Console.WriteLine();

        for(i=0;i<5;i++)
            Console.Write(jagged[2][i] + " ");
        Console.WriteLine();
    }
}