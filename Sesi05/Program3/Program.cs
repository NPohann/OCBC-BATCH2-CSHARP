using System;

namespace program3
{
    class Program
    {
        static void Main(string[] args)
        {
            Pesawat pesawat = new Pesawat(); // Instantiasi objek
            pesawat_tempur pswttempur = new pesawat_tempur();

            // setting atribut/variabel
            pesawat.Nama = "Helly";
            pesawat.JumlahRoda = 3;
            pesawat.Ketinggian = "1000 kaki";
            pesawat.JumlahPenumpang = "3 penumpang";
            pswttempur.Nama = "AZ500TPU";
            pswttempur.JumlahRoda = 5;
            pswttempur.Ketinggian = "200 kaki";
            pswttempur.JumlahPenumpang = "2 Penumpang plus kopilot dan asistance";

            // memanggil method dari suati kelas
            pesawat.terbang();
            pswttempur.terbangtinggi();
            Console.Read();
        }
    }
}
