namespace hazir_metodlar;

class Program
{
    static void Main(string[] args)
    {
        //String library
        string degisken = "Dersimiz CSharp, Hosgeldiniz!";
        string degisken2 = "CSharp";
        //Lenght: değişkenin kaç karakterden oluştuğu;
        Console.WriteLine(degisken.Length);

        //ToUpper, ToLower: Değişkenin tüm karakterlerini hepsini büyütme/küçültme
        Console.WriteLine(degisken.ToUpper());
        Console.WriteLine(degisken.ToLower());

        //Concat: Birleştirme
        Console.WriteLine(String.Concat(degisken,"Merhaba!"));

        //CompareTo (ikisi eşitse 0, ilki büyükse 1, ikinci büyükse -1 döndürür)
        Console.WriteLine(degisken.CompareTo(degisken2));
        
        //Compare (iki string ifadeyi karşılaştırıp int değer döner, aynıysa 0 döner, iki ifadeyi harf harf karşılaştırıp farklılık olan harfin sırasına göre -1 veya 1 döndürür. 
        //İlk ifadedeki harf önceyse -1, sonraysa 1 döndürür. 3. parametre olarak bool değer girilebilir. True girilirse ignore edilir, false girilirse case sensitive)
        Console.WriteLine(String.Compare(degisken, degisken2, true));
        Console.WriteLine(String.Compare(degisken, degisken2, false));

        //Contains: İfade içerisinde arama yapar, boolean sonuç döner
        Console.WriteLine(degisken.Contains(degisken2));
        Console.WriteLine(degisken.EndsWith("Hosgeldiniz!"));
        Console.WriteLine(degisken.StartsWith("Merhaba!"));

        //IndexOf: İfade içerisinde arama yapar, aranan karakterin ilkinin indexini verir. Bulamazsa -1 döner.
        Console.WriteLine(degisken.IndexOf("CSharp"));
        Console.WriteLine(degisken.LastIndexOf("i"));

        //Insert: Verilen indexten başlayarak girilen ifadeyi ekler.
        Console.WriteLine(degisken.Insert(0, "Merhaba"));
        
        //PadLeft, PadRight: Değişkenin karakter sayısını verilen değere tamamlayacak kadar sağına/soluna boşluk ekler. 
        Console.WriteLine(degisken + degisken2.PadLeft(30));
        Console.WriteLine(degisken + degisken2.PadLeft(30, '*'));
        Console.WriteLine(degisken.PadRight(50) + degisken2);
        Console.WriteLine(degisken.PadRight(50, '-') + degisken2);

        //Remove: Verilen indexten itibaren siler. İki değer girilirse ilk değerinci indexten başlar, verilen 2. değer kadar karakter siler.
        Console.WriteLine(degisken.Remove(10));
        Console.WriteLine(degisken.Remove(5,3));
        Console.WriteLine(degisken.Remove(0, 1));


        

    }
}
