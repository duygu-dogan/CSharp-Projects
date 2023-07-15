namespace while_foreach;

class Program
{
    static void Main(string[] args)
    {
        // While
        //1'den başlayarak console'dan girilen sayıya kadar (dahil) ortalama hesaplayıp console'a yazdıran program
        /*Console.Write("Lütfen bir sayi giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());
        int sayac = 1; 
        int toplam = 0;

        while (sayac <= sayi)
        {
            toplam += sayac;
            sayac ++;
        }
        Console.WriteLine(toplam/sayi);

        //a'dan z'ye kadar tüm harfleri console'a yazdırma
        char character = 'a';
        
        while (character < 'z')
        {
            Console.Write(character);
            character ++;
        }*/
        
        Console.WriteLine("*** Foreach ***");
        string[] arabalar = {"BMW", "Ford","Toyota","Nissan"};

        foreach (var araba in arabalar)
        {
            Console.WriteLine(araba);
        }

    }
}
