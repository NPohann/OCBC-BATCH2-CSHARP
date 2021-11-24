using System;

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {
            //instant objek
            Laptop laptop1 = new Laptop();

            laptop1.Input();

            //akses atribut
            // laptop1.merk = "lenovo";
            // laptop1.ram=4;
            // laptop1.memory=128;

            //Tampilkan
            Console.WriteLine("Merk Laptop adalah {0}", laptop1.merk);
            Console.WriteLine("Kapasitas RAM ada {0}", laptop1.ram);
            Console.WriteLine("Kapasitas Memory ada {0}", laptop1.memory);

            //Akses Method
            laptop1.Chatting();
            laptop1.Sosmed();
            laptop1.OnlineShop();

            Console.Read();
        }
    }
}
