namespace hazir_metodlar;

class Program
{
    static void Main(string[] args)
    {
        //***String library***

       /* string degisken = "Dersimiz CSharp, Hosgeldiniz!";
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

        //Replace: İlk değeri, ikinci değerle değiştirir.
        Console.WriteLine(degisken.Replace("Charp", "C#"));
        Console.WriteLine(degisken.Replace(" ", "*"));

        //Split: İlkine göre parçalar ve bir diziye atar. Verilen index'teki veriyi getirir.
        Console.WriteLine(degisken.Split(' ')[1]);

        //Substring: Verilen indexten başlayıp (ikinci değer verilmediyse)sonuna kadar, ikinci değer girildiyse o sayıda karakteri getirir.
        Console.WriteLine(degisken.Substring(4));
        Console.WriteLine(degisken.Substring(4,6));*/
        
    // ***DateTime Library***

        //DateTime Now
        Console.WriteLine(DateTime.Now); //Günün tarihi
        Console.WriteLine(DateTime.Now.Date);
        Console.WriteLine(DateTime.Now.Day);
        Console.WriteLine(DateTime.Now.Month);
        Console.WriteLine(DateTime.Now.Year);
        Console.WriteLine(DateTime.Now.Hour);
        Console.WriteLine(DateTime.Now.Minute);
        Console.WriteLine(DateTime.Now.Second);

        Console.WriteLine(DateTime.Now.DayOfWeek);
        Console.WriteLine(DateTime.Now.DayOfYear);

        Console.WriteLine(DateTime.Now.ToLongDateString());
        Console.WriteLine(DateTime.Now.ToShortDateString());
        Console.WriteLine(DateTime.Now.ToLongTimeString());
        Console.WriteLine(DateTime.Now.ToShortTimeString());

        Console.WriteLine(DateTime.Now.AddDays(2));
        Console.WriteLine(DateTime.Now.AddHours(3));
        Console.WriteLine(DateTime.Now.AddSeconds(30));
        Console.WriteLine(DateTime.Now.AddMonths(5));
        Console.WriteLine(DateTime.Now.AddYears(10));
        Console.WriteLine(DateTime.Now.AddMilliseconds(50));

        //DateTime Format
        Console.WriteLine(DateTime.Now.ToString("dd")); //Günün integer karşılığı; 21
        Console.WriteLine(DateTime.Now.ToString("ddd")); //Mon
        Console.WriteLine(DateTime.Now.ToString("dddd")); //Monday

        Console.WriteLine(DateTime.Now.ToString("MM")); //08
        Console.WriteLine(DateTime.Now.ToString("MMM")); //Aug
        Console.WriteLine(DateTime.Now.ToString("MMMM")); //August

        Console.WriteLine(DateTime.Now.ToString("yy")); //23
        Console.WriteLine(DateTime.Now.ToString("yyyy")); // 2023

        //Math Library
        Console.WriteLine(Math.Abs(-25)); //Mutlak alır; 25
        Console.WriteLine(Math.Sin(10)); //sinüsünü alır
        Console.WriteLine(Math.Cos(10)); //cosinüsünü alır
        Console.WriteLine(Math.Tan(10)); //tanjantını alır

        Console.WriteLine(Math.Ceiling(22.3)); //Yukarı yuvarlar, sayıdan büyük en küçük tam sayı;23
        Console.WriteLine(Math.Round(22.3)); //Hangi tam sayıya yakınsa onu verir;22
        Console.WriteLine(Math.Round(22.7)); //23
        Console.WriteLine(Math.Floor(22.7)); //Aşağı yuvarlar, sayıdan küçük en büyük tam sayı;22

        Console.WriteLine(Math.Max(2,6));
        Console.WriteLine(Math.Min(2,6));

        Console.WriteLine(Math.Pow(3,4)); //3^4'ü verir; 81
        Console.WriteLine(Math.Sqrt(9)); //karekök alır; 3
        Console.WriteLine(Math.Log(9)); //9'un e tabanındaki logaritmik karşılığı
        Console.WriteLine(Math.Exp(3)); //e üzeri 3
        Console.WriteLine(Math.Log10(10)); //sayının log 10 tabanındaki karşılığı

        

    }
}
