namespace Homework;

class Program
{
    static void Main(string[] args)
    {   
        Sorular soru = new Sorular();
        //soru.Odev1();
        //soru.Odev2();
        //soru.Odev3();
        soru.Odev4();
    }
}
    
class Sorular
{
    public void Odev1()
    {
    /* Odev-1
      Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
      Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
      */
      
        Console.WriteLine("Lütfen bir pozitif sayi giriniz: ");

        SayiAdedi:
        int n = Convert.ToInt32(Console.ReadLine());
        
        if (n < 0)
        {
            Console.WriteLine("Hatalı giriş yaptınız, lütfen pozitif bir sayi giriniz:");
            goto SayiAdedi;
        }
        
        Console.WriteLine("Lütfen girdiğiniz sayi adedinde pozitif sayi giriniz: ");
        Etiket:
        List<int> Numbers = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(NumbersTemp => Convert.ToInt32(NumbersTemp)).ToList();
        
        if (n != Numbers.Count) 
        {   Console.WriteLine("Eksik ya da fazla giriş yaptınız, lütfen girdiğiniz sayi adedinde pozitif sayi giriniz: ");
            goto Etiket;
        }
        else
        {
            for (int i = 0; i < n; i++)
            {
                if (Numbers[i]<0)
                {   
                    Console.WriteLine("Hatalı giriş yaptınız, lütfen pozitif bir sayi giriniz:");
                    goto Etiket;
                }
            }   
        }

        List<int> EvenNumbers = new List<int>();

        foreach (var item in Numbers)
        {
            if (item%2 == 0)
            {
                EvenNumbers.Add(item);
            }
        }
        Console.Write("Girdiğiniz çift sayilar: " + string.Join(" ", EvenNumbers));
    }

    public void Odev2()
    {            
        //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
        //Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
        
        MainNumbers:
        Console.WriteLine("Lütfen iki adet pozitif sayı giriniz: ");
        List<int> Numbers = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(NumbersTemp => Convert.ToInt32(NumbersTemp)).ToList();
        int n = Numbers[0];
        int m = Numbers[1];    
        if (n < 0 | m < 0)
            goto MainNumbers;

        SubNumbers:
        Console.WriteLine("Lütfen ilk girdiğiniz sayı adedinde pozitif sayı giriniz: ");
        List<int> SubNumbers = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(SubNumbersTemp => Convert.ToInt32(SubNumbersTemp)).ToList();
        for (int i = 0; i < n; i++)
        {
            if(SubNumbers[i]<0)
                goto SubNumbers;
            else
            {
                continue;
            }
        }
        if (SubNumbers.Count<n)
            goto SubNumbers;

        List<int> SubList = new List<int>();
        foreach (var item in SubNumbers)
        {
            if(item == m | item % m == 0)
                SubList.Add(item);

        }
        Console.Write("İkinci sayıya bölünebilen veya eşit olanlar: " + string.Join(" ", SubList));
    }

    public void Odev3()
    {
        /*Odev-3:
        Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
        Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
        */
    KelimeAdedi:
    Console.WriteLine("Lütfen pozitif bir sayı giriniz: ");
    int n = Convert.ToInt32(Console.ReadLine());
        if(n < 0)
            goto KelimeAdedi;
    
    Kelimeler:
    Console.WriteLine("Lütfen girdiğiniz sayi adedinde kelime giriniz: ");
    List<string> KelimeList = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(KelimeListTemp => Convert.ToString(KelimeListTemp)).ToList();
        if(KelimeList.Count != n)
            goto Kelimeler;

    KelimeList.Reverse();
        for (int i = 0; i < n; i++)
        {
            Console.Write(KelimeList[i] + " ");
        }
        
    }

    public void Odev4()
    {
        /*Odev-4:
        Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
        */
        Cümle:
        Console.WriteLine("Lütfen bir cümle yazınız: ");
        List<string> CumleList = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(CumleListTemp => Convert.ToString(CumleListTemp)).ToList();
        Console.WriteLine("Cümledeki kelime sayısı: " + CumleList.Count);
        
        int ToplamHarfSayisi = 0;
          
        foreach (var gezici in CumleList)
      {
        ToplamHarfSayisi += gezici.Length;
      }

        Console.WriteLine("Kelimelerdeki harflerin toplam sayısı: " + ToplamHarfSayisi);
    }
}