using System;

public class Pesawat{
    public string Ketinggian;
    public string Nama;
    public int JumlahRoda;
    public string JumlahPenumpang;

    public void terbang(){
        Console.WriteLine("Pesawat Tempur dengan nama {0}, yang mempunyai jumlah roda {1}, sedang berada pada ketinggian {2} dengan membawa jumlah penumpang sebanyak {3} akan meledakkan senjata", this.Nama, this.JumlahRoda, this.Ketinggian, this.JumlahPenumpang);
    }
    
}

class pesawat_tempur:Pesawat{
        public void terbangtinggi(){
            Console.WriteLine("Pesawat Tempur dengan nama {0}, yang mempunyai jumlah roda {1}, sedang berada pada ketinggian {2} dengan membawa jumlah penumpang sebanyak {3} akan meledakkan senjata", this.Nama, this.JumlahRoda, this.Ketinggian, this.JumlahPenumpang);
        }
    }