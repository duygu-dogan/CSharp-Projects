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

    }
}
