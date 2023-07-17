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

        //Array sınıfı ve metodları

        //Sort: Sıralama

        int[] sayiDizisi = {23,12,4,86,72,3,11,17};

        Console.WriteLine("*** sırasız dizi***");
        foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);

        Console.WriteLine("***sıralı dizi***");
        Array.Sort(sayiDizisi);
        foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);

        //Clear: Dizideki verilen indexten itibaren verilen sayıdaki elemanın değerini sıfırlıyor
        Console.WriteLine("***Array Clear***");
        Array.Clear(sayiDizisi,2,2);

        foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);

        //Reverse: Diziyi ortadan itibaren aynalama şeklinde tersine çevirme 
        Console.WriteLine("***Array Reverse***");
        Array.Reverse(sayiDizisi);
        
        foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);

        //IndexOf: Dizideki elemanın (varsa) indexini döner
        Console.WriteLine("***IndexOf***");
        
        Console.WriteLine(Array.IndexOf(sayiDizisi, 23));

        //Resize
        Console.WriteLine("***Resize***");

        Array.Resize<int>(ref sayiDizisi, 9);
        sayiDizisi[8] = 99;

        foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);
    }
}
