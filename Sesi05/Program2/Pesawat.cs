using System;

public class Pesawat{

    public string nama;
    private string ketinggian_pesawat;

    public string ketinggian{
        get { return ketinggian_pesawat; }
        set { ketinggian_pesawat = value; }
    }

    public void terbang(){
        Console.WriteLine("Pesawat dengan {0}, sedang take off", this.nama);
    }

    public void sudahterbang(){
        Console.WriteLine("Pesawat sekarang berada pada ketinggian {0}", this.ketinggian_pesawat);
    }
}