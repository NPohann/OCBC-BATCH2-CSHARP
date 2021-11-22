using System;

namespace hitungnilai2
{
    class HitungNilai2
    {
        static void Main(string[] args)
        {
            //  menggunakan operator = untuk mengisi nilai
            int nilai1 = 10;
            int nilai2 = 8;

            // mengisi ulang nilai variabel mangga
            nilai1 = 15;

            Console.WriteLine($"nilai1 = {nilai1}");

            // menggunakan += untuk mengisi dan menjumlahkan
            nilai2 += 6;

            Console.WriteLine($"nilai2 = {nilai2}");  
        }
    }
}
