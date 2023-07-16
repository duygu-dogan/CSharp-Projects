namespace diziler;

class Program
{
    static void Main(string[] args)
    {
        //Dizi tanımlama
        string[] renkler = new string[5];

        string[] hayvanlar = {"kedi","köpek","kuş","maymun"};

        int[] dizi; 
        dizi = new int[5];

        //Dizilere değer atama ve erişim

        renkler[0] = "mavi";
        
        dizi[3] = 10;

        Console.WriteLine(hayvanlar[1]);
        Console.WriteLine(dizi[3]);
        Console.WriteLine(renkler[0]);

        //Döngülerle dizi kullanımı
        //Console'dan girilen sayı ile oluşturulan dizideki sayıların ortalamasını hesaplayan program

        Console.Write("Lütfen dizinin eleman sayisini giriniz: ");
        int diziUzunlugu = int.Parse(Console.ReadLine());
        int[] sayiDizisi = new int[diziUzunlugu];

        for (int i = 0; i < diziUzunlugu; i++)
        {
            Console.Write("Lütfen {0}. sayiyi giriniz: ", i+1);
            sayiDizisi[i] = int.Parse(Console.ReadLine());
        }

        int Toplam = 0;
        foreach (var sayi in sayiDizisi)
            Toplam += sayi;

        Console.WriteLine("Ortalama :" + Toplam/diziUzunlugu);

    }
}
