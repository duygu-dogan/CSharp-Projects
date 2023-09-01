using System.Collections;

namespace arrayList;

class Program
{
    static void Main(string[] args)
    {
        //System.Collections namespace
        //Dinamik (büyüyüp küçülebilen) yapılardır ve farklı veri tiplerinde eleman alabilir

        ArrayList liste = new ArrayList();
        /*liste.Add(2);
        liste.Add("Ayse");
        liste.Add(true);
        liste.Add('A');

        //İçerisinde verilere erişim
        Console.WriteLine(liste[1]);

        foreach (var item in liste)
        {
            Console.WriteLine(item);
        }*/

        //AddRange: Birden fazla elemanı toplu şekilde ekleme
        //string[] renkler = {"kırmızı", "sarı", "yeşil"};
        //liste.AddRange(renkler);
        List<int> sayilar = new List<int>(){1,8,3,7,9,92,5};
        liste.AddRange(sayilar);

        foreach (var item in liste)
            Console.WriteLine(item);

        //Sort
        Console.WriteLine("***Sort***");
        liste.Sort();

        foreach (var item in liste)
            Console.WriteLine(item);

        // Binary Search
        Console.WriteLine("**Binary Search***");
        Console.WriteLine(liste.BinarySearch(9));

        //Reverse
        Console.WriteLine("**Reverse**");
        liste.Reverse();
        foreach (var item in liste)
            Console.WriteLine(item);

        //Clear
        Console.WriteLine("**Clean**");
        liste.Clear();
        foreach (var item in liste)
        {
            Console.WriteLine(item);
        }
    }
}
