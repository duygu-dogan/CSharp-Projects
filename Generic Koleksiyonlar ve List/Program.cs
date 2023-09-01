using System;
using System.Collections.Generic;

namespace Generic_Koleksiyonlar_ve_List;

class Program
{
    static void Main(string[] args)
    {
        //List<T> class
        //System.Collections.Generic
        // T-> object türündedir. Hangi tipten nesne ekleyeceğimizi T ile belirtiyoruz.

        List<int> sayiListesi = new List<int>();

        sayiListesi.Add(23);
        sayiListesi.Add(10);
        sayiListesi.Add(4);
        sayiListesi.Add(5);
        sayiListesi.Add(92);
        sayiListesi.Add(34);

        List<string> renkListesi = new List<string>();
        renkListesi.Add("Kırmızı");
        renkListesi.Add("Mavi");
        renkListesi.Add("Turuncu");
        renkListesi.Add("Sarı");
        renkListesi.Add("Yeşil");

        //Count
        Console.WriteLine(renkListesi.Count);
        Console.WriteLine(sayiListesi.Count);

        //Ekrana yazdırma: Foreach ve List.ForEach

        foreach (var sayi in sayiListesi)
            Console.WriteLine(sayi);
        foreach (var renk in renkListesi)
            Console.WriteLine(renk);

        sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
        renkListesi.ForEach(renk=> Console.WriteLine(renk));

        //Listeden Eleman Çıkarma: Remove ve RemoveAt (index'e göre)

        sayiListesi.Remove(4);
        renkListesi.Remove("Yeşil");

        sayiListesi.RemoveAt(0);
        renkListesi.RemoveAt(1);

        //Liste İçinde Arama Yapma

        if(sayiListesi.Contains(10))
            Console.WriteLine("10 liste içerisinde bulundu!");
        
        //Eleman ile indexe erişme
        Console.WriteLine(renkListesi.BinarySearch("Sarı"));

        //Diziyi listeye çevirme

        string[] hayvanlar = {"Kedi", "Köpek", "Kuş"};

        List<string> hayvanListesi = new List<string>(hayvanlar);

        //Listeyi temizleme
        hayvanListesi.Clear();

        //Liste içerisinde nesne tutma
        List<KullanıcıVeriTipi> kullanıcıListesi = new List<KullanıcıVeriTipi>();

        KullanıcıVeriTipi kullanıcı1 = new KullanıcıVeriTipi();
        kullanıcı1.Isim = "Ayşe";
        kullanıcı1.Soyisim = "Yılmaz";
        kullanıcı1.Yaş = 26;

        KullanıcıVeriTipi kullanıcı2 = new KullanıcıVeriTipi();
        kullanıcı2.Isim = "Özcan";
        kullanıcı2.Soyisim = "Çalışkan";
        kullanıcı2.Yaş = 26;

        kullanıcıListesi.Add(kullanıcı1);
        kullanıcıListesi.Add(kullanıcı2);
        
        List<KullanıcıVeriTipi> yeniListe = new List<KullanıcıVeriTipi>();
        yeniListe.Add(new KullanıcıVeriTipi(){
            Isim="Deniz",
            Soyisim = "Arda",
            Yaş = 24
        });
        foreach (var kullanıcı in kullanıcıListesi)
        {
            Console.WriteLine("Kullanıcı Adı: " + kullanıcı.Isim);
            Console.WriteLine("Kullanıcı Soyadı: " + kullanıcı.Soyisim);
            Console.WriteLine("Kullanıcı Yaşı: " + kullanıcı.Yaş);

        }
                
    }
}
public class KullanıcıVeriTipi
{
    string isim;
    string soyisim;
    int yaş;

    public string Isim { get => isim; set => isim = value; }
    public int Yaş { get => yaş; set => yaş = value; }
    public string Soyisim { get => soyisim; set => soyisim = value; }
}
