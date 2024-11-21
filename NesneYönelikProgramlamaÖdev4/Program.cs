using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
class Program
{
    /* SORU 1: 1. Matematiksel Hesaplama Yapan Parametresiz ve Geriye Değer Döndüren Metot */
     public static double üçgenalan()
    {
        Console.WriteLine("Taban Değerini Giriniz");
        double taban = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Yükseklik Değerini Giriniz");
        double yükseklik = Convert.ToInt32(Console.ReadLine());
        return (taban + yükseklik) / 2;
    }

    /* SORU 2: Dizideki En Büyük Değeri Bulan Parametreli ve Geriye Değer Döndüren Metot */
    
    public static int maxdeğer(int[] dizi)
    {
        int max = dizi[0];
        foreach(int sayı in dizi)
        {
            if(sayı > max)
            {
                max = sayı;
            }
        }
        
        return max;
    }

    /* SORU 3: Aşırı Yüklenmiş (Overloaded) Metot ile Farklı Türdeki Verilerin Toplamını Bulma */

    public static int CalculateSum(int pw, int px)
    {
        return pw + px;
    }

    public static double CalculateSum(double py, double pz)
    {
        return py + pz;
    }

    public static int CalculateSum(int pi, int pj, int pk)
    {
        return pi + pj + pk;
    }

    /* SORU 4: Recursive Metot ile Fibonacci Dizisi Hesaplama */

    public static int fibonacci(int n)
    {
        if (n <= 1)
        {
            return n;
        }

        return fibonacci(n - 1) + fibonacci(n-2);
    }

    /* SORU 5:  Params ile Sınırsız Sayıda Parametre Alarak Ortalama Hesaplama */

    public static double orthesaplama(params double[] sayılar)
    {
        double toplam = 0;
        foreach(double sayı in sayılar)
        {
            toplam = toplam + sayı;
        }

        return toplam/sayılar.Length;
    }

    /* SORU 6: Dizi Elemanlarını Toplayan ve Filtreleme Şartı Ekleyen Metot */

    public static int toplamavefiltreleme(int[] dizi, int filtre)
    {

        int toplam = 0;
        foreach(int sayı in dizi)
        {
            if(sayı> filtre)
            {
                toplam = toplam + sayı;
            }
        }

        return toplam;
    }

    /* SORU 7: Seçmeli (Optional) Parametre ile Belirli Yaştan Sonraki Yılları Sayma */

    public static int yaşhesalama(int yaş, int varsayılan = 18)
    {
        return yaş - varsayılan;
    }

    /* SORU 8: Geriye Koleksiyon Döndüren ve Veriyi Filtreleyen Metot */

    public static List<string> beştenbüyüklerifiltreleme(string[] dizi)
    {
        List<string> sonuç = new List<string>();
        foreach (string ls in dizi)
        {
            if (ls.Length > 5)
            {
                sonuç.Add(ls);
            }
        }

        return sonuç;
    }

    static void Main(String[] args)
    {
        /* SORU 1 */
        Console.WriteLine("SORU 1\n");
        
        double alan = üçgenalan();
        Console.WriteLine("Alan: " + alan);

        /* SORU 2 */
        Console.WriteLine("\nSORU 2\n");

        int[] dizi = {12, 23, 45, 56, 78, 89, 25 };
        int i;
        int max = maxdeğer(dizi);
        Console.WriteLine("Dizi: ");
        for(i=0; i < 7;  i++)
        {
            Console.Write(dizi[i] + ", ");
        }
        Console.WriteLine("\nDizideki En Büyük Değer: " + max);

        /* SORU 3 */
        Console.WriteLine("\nSORU 3\n");

        Console.WriteLine("\n*** 3. Soru ***");
        int pw = 3, px = 5, pi = 3, pj = 5, pk = 8;
        double py = 3.5, pz = 5.2;
        int toplam1 = CalculateSum(3, 5);
        double toplam2 = CalculateSum(3.5, 5.2);
        int toplam3 = CalculateSum(3, 5, 8);
        Console.WriteLine("2 int sayı: " + pw + " ve " + px);
        Console.WriteLine("2 int sayı: " + py + " ve " + pz);
        Console.WriteLine("3 int sayı: " + pi + " ve " + pj + " ve" + pk);
        Console.WriteLine("2 int sayının toplamı: " + toplam1);
        Console.WriteLine("2 double sayının toplamı: " + toplam2);
        Console.WriteLine("3 int sayının toplamı: " + toplam3);
        Console.WriteLine();

        /* SORU 4 */
        Console.WriteLine("\nSORU 4\n");

        Console.WriteLine("Fibonacci Sırasını Giriniz:");
        int sıra = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"{sıra}. Fibonacci sayısı: {fibonacci(sıra)}");

        /* SORU 5 */
        Console.WriteLine("\nSORU 5\n");

        double ort = orthesaplama(1.2, 2.3, 4.5, 5.6, 7.8, 8.9);
        Console.WriteLine("Sayılar: 1.2, 2.3, 4.5, 5.6, 7.8, 8.9");
        Console.WriteLine("Ortalama:" + ort);

        /* SORU 6 */
        Console.WriteLine("\nSORU 6\n");

        int toplam = toplamavefiltreleme(dizi, 5);
        Console.WriteLine("Filtreye Uyan Eleman Toplamı:" + toplam);

        /* SORU 7 */
        Console.WriteLine("\nSORU 7\n");

        Console.WriteLine("Yaşınızı Giriniz:");
        int yaş = Convert.ToInt32(Console.ReadLine());
        int yaşfarkı = yaşhesalama(yaş);
        Console.WriteLine("18 Yaşla Arandaki Fark:" + yaşfarkı );

        if (yaşfarkı > 0)
        {
            Console.WriteLine(" Kadar Büyük");
        }
        else if (yaşfarkı < 0)
        {
            Console.WriteLine(" Kadar Küçük");
        }
        else
        {
            Console.WriteLine(" Eşit");
        }

        /* SORU 8 */
        Console.WriteLine("\nSORU 8\n");

        string[] kelimeler = { "Ahmet", "Baki", "Yılmaz", "Basketbol", "Eminem", "Fenerbahçe", "Galatasaray" };
        List<string> beştenuzunkelimeler = beştenbüyüklerifiltreleme(kelimeler);
        Console.WriteLine("Beşten Büyük Olanlar: ");
        foreach(string sl in beştenuzunkelimeler)
        {
            Console.WriteLine(sl);
        }
        Console.ReadLine();  
    }
}
