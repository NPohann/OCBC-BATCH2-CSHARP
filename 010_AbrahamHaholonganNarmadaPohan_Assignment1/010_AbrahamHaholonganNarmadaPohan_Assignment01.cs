using System;

public class Assignment01{
    public static void Main(){

        string exit = "";

        Console.WriteLine("=== ASSIGNMENT 1 ===");
        Console.WriteLine();
        Console.WriteLine("Nama : Abraham Haholongan Narmada Pohan");
        Console.WriteLine("Kode Peserta : FSDO002ONL010");
        Console.WriteLine("Alamat : Sidoarjo");
        Console.WriteLine();
        Console.WriteLine("====================");
        Console.WriteLine();


        do {
            Console.WriteLine();
            Console.WriteLine("=== MENU ===");
            Console.WriteLine();
            Console.WriteLine("1. Segitiga Alfabet");
            Console.WriteLine("2. Segitiga Angka");
            Console.WriteLine("3. Faktorial");
            Console.WriteLine("4. Pembalikkan Angka");
            Console.WriteLine("5. Konversi Angka menjadi Kata");
            Console.WriteLine("6. Palindrome");
            Console.WriteLine("7. Keluar Menu");
            Console.WriteLine();
            Console.WriteLine("==================");
            Console.WriteLine();
            Console.Write("Menu yang Dipilih: ");
            int menu = int.Parse(Console.ReadLine());

            switch(menu) {
                case 1: {
                    Console.WriteLine("1. Segitiga Alfabet");
                    Soal1();
                    break;
                }
                case 2: {
                    Console.WriteLine("2. Segitiga Angka");
                    Soal2();
                    break;
                }
                case 3: {
                    Console.WriteLine("3. Faktorial");
                    Soal3();
                    break;
                }
                case 4: {
                    Console.WriteLine("4. Pembalikkan Angka");
                    Soal4();
                    break;
                }
                case 5: {
                    Console.WriteLine("5. Konversi Angka menjadi Kata");
                    Soal5();
                    break;
                }
                case 6: {
                    Console.WriteLine("6. Palindrome");
                    Palindrome();
                    break;
                }
                case 7: {
                    Console.WriteLine("=== TERIMAKASIH ===");
                    Environment.Exit(0);
                    break;
                }
                default : {
                    Console.WriteLine("Menu yang Anda pilih tidak ada!");
                    break;
                }
            }

            Console.WriteLine();
            Console.Write("Ingin memilih menu lain? (Y/N) : ");
            exit = Console.ReadLine();

        } while(exit == "Y" || exit == "y");

        Console.WriteLine("=== TERIMAKASIH ===");  
    }

    // Fungsi untuk setiap menu yang dipilih

    public static void Soal1(){
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

    public static void Soal2(){
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

    public static void Soal3(){
        int angka;
        int faktorial = 1;

        Console.Write("Enter any number: ");
        angka = int.Parse(Console.ReadLine());

        for(int i = angka; i >= 1; i--){
            faktorial = faktorial * i;
        }

        Console.Write($"Factorial of {angka} is {faktorial}");
    }

    public static void Soal4(){
        string reversed = "";
        string angka;

        Console.Write("Enter a number: ");
        angka = Console.ReadLine();


        for(int i = angka.Length-1; i >= 0; i--){
            reversed = reversed + angka[i];
        }
        Console.WriteLine("Reversed Number: " + reversed);
    }

    public static void Soal5(){
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

    public static void Palindrome(){
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

