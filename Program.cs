namespace methods;

/*class Program
{
    static void Main(string[] args)
    {
       /erisim_belirteci geri_donustipi  metot_adi(parametreListesi/arguman)
       //{

            //komutlar;
            //return;

       //}

       int a =2;
       int b =3;

       Console.WriteLine(a+b);

        int sonuc = Topla(a,b);
        Console.WriteLine(sonuc);

        Metotlar ornek = new Metotlar();
        ornek.EkranaYazdir(Convert.ToString(sonuc));

        int sonuc2 = ornek.ArttirVeTopla(ref a, ref b);
        ornek.EkranaYazdir(Convert.ToString(sonuc2));
        ornek.EkranaYazdir(Convert.ToString(a+b));

    }
    static int Topla(int deger1, int deger2)
        {
            return(deger1+deger2);
        }
    
}

class Metotlar
{
    public void EkranaYazdir(string veri)
    {
        Console.WriteLine(veri);
    }

    public int ArttirVeTopla(ref int deger1,ref int deger2)
    {
        deger1+=1;
        deger2+=1;
        return deger1+deger2;
    }
}

class Methods
{
    static void Main(string[] arg)
    {
        //out parametreler
        string sayi = "999";

        bool sonuc = int.TryParse(sayi, out int outSayi); //int dışarıda tanımlanıp sadece "out outSayi" şeklinde de yazılabilir.
        if (sonuc)
        {
            Console.WriteLine("Başarılı!");
            Console.WriteLine(outSayi);
        }
        else
        {
            Console.WriteLine("Başarısız!");
        }
        OutPar instance = new OutPar();
        instance.Topla(4, 5, out int toplamSonucu);
        Console.WriteLine(toplamSonucu);

        //Method Overloading

        int exp = 999;
        instance.EkranaYazdir(Convert.ToString(exp));
        instance.EkranaYazdir(exp);
        instance.EkranaYazdir("Duygu","Doğan");

        // Metot imzası: metotAdı + parametre sayısı + parametre
    }
}

class OutPar
{
    public void Topla(int a, int b, out int toplam)
    {
        toplam= a+b;
    }

    public void EkranaYazdir(string veri)
    {
        Console.WriteLine(veri);
    }

        public void EkranaYazdir(int veri)
    {
        Console.WriteLine(veri);
    }
     public void EkranaYazdir(string veri1, string veri2)
    {
        Console.WriteLine(veri1 + veri2);
    }
    
}*/

public class Program
	{
		static void Main(string[] args)
		{
			//Rekürsif - Öz Yinelemeli 

			int result = 1;
			for (int i = 0; i < 5; i++)
			{
				result = result * 3;
				Console.WriteLine(result);

				Islemler islemler = new Islemler();
				Console.WriteLine(islemler.Expo(3, 4));

				//Extension Metotlar
				string ifade = "Duygu Dogan";
				bool sonuc = ifade.CheckSpaces();
				Console.WriteLine(sonuc);

				if (sonuc)				
					Console.WriteLine(ifade.RemoveWhiteSpaces());
					Console.WriteLine(ifade.MakeUpperCase());
					Console.WriteLine(ifade.MakeLowerCase());

				int[] dizi = { 1, 4, 8, 9, 6 };
				dizi.SortArray();
				dizi.EkranaYazdir();

				int sayi = 10;
				Console.WriteLine(sayi.IsEvenNumber());
				Console.WriteLine(ifade.GetFirstCharecter());
			}
		}
	}
	public class Islemler
	{
		public int Expo(int sayi, int us)
		{
			if (us < 2)
			{
				return sayi;
			}
			return Expo(sayi, us - 1) * sayi;
		}
		//Expo(3,4)
		//Expo(3,3) * 3
		//Expo(3,2) * 3 * 3
		//Expo(3,1) * 3 * 3 * 3
		//3*3*3*3 = 3^4 
	}
	public static class Extension
	{
		public static bool CheckSpaces(this string param)
		{
			return param.Contains(" ");
		}

		public static string RemoveWhiteSpaces(this string param)
		{
			string[] dizi = param.Split(" ");
			return string.Join("*", dizi);
		}
		public static string MakeUpperCase(this string param)
		{
			return param.ToUpper();
		}
		public static string MakeLowerCase(this string param)
		{
			return param.ToUpper();
		}
		public static int[] SortArray(this int[] param)
		{
			Array.Sort(param);
			return param;
		}
		public static void EkranaYazdir(this int[] param)
		{
			foreach (var item in param)
			{
				Console.WriteLine(item);
			}
		}
		public static bool IsEvenNumber(this int param)
		{
			return param % 2 == 0;
		}
		public static string GetFirstCharecter(this string param)
		{
			return param.Substring(0,1);
		}
}
