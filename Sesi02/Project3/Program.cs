using System;

namespace project3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Membuat variabel kosong
            string nama;
            int umur;

            Console.WriteLine("=== PROGRAM PENDAFTARAN PENDUDUK ===");
            Console.Write("Masukan nama: ");
            nama = Console.ReadLine();
            Console.Write("Masukkan alamat: ");
            var alamat = Console.ReadLine();
            Console.Write("Masukkan umur: ");
            umur = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Terimakasih");
            Console.WriteLine("Data Berikut");
            Console.WriteLine($"Nama: {nama}");
            Console.WriteLine($"Alamat: {alamat}");
            Console.WriteLine($"Umur: {umur} tahun");
            Console.WriteLine("SUDAH DISIMPAN!");
        }
    }
}
