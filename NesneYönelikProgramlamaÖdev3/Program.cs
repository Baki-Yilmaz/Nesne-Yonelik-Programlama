using System.Collections;

/* SORU 1 */

ArrayList Sayılar = new ArrayList();

for (int i = 1; i < 6; i++)
{
    Sayılar.Add(i);
}

Console.WriteLine("Soru 1;\n");

foreach (int yazdır in Sayılar)
{
    Console.WriteLine(yazdır);
}

/* SORU 2 */
Console.WriteLine("\n- - - - - - - - - - - - - - -");
Console.WriteLine("Soru 2;\n");

Console.Write("Lütfen cümle giriniz:");
string cümle = Console.ReadLine();
string[] kelime = cümle.Split(' ');
Console.WriteLine("Kelime Sayısı: " + kelime.Length);

/* SORU 3 */
Console.WriteLine("\n- - - - - - - - - - - - - - -");
Console.WriteLine("Soru 3;\n");

ArrayList isim = new ArrayList();

for(int i= 1; i<6;i++)
{
    Console.WriteLine(i + ". İsim:");
    isim.Add(Console.ReadLine());
}

isim.Sort();
Console.WriteLine("\nAlfabetik Sıralama:");
foreach (string f in isim)
{
    Console.WriteLine(f);
}


/* SORU 4 */
Console.WriteLine("\n- - - - - - - - - - - - - - -");
Console.WriteLine("Soru 4;\n");

Console.WriteLine("Bir Sayı Giriniz:");
int sayı = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nFibonachi Dizisi;");
int a = 0, b = 1, c;
for(int i = 0; i<sayı;i++)
{
    Console.WriteLine(a + " ");
    c = a + b;
    a = b;
    b = c;
}

/* SORU 5 */
Console.WriteLine("\n- - - - - - - - - - - - - - -");
Console.WriteLine("Soru 5;\n");

int doğru_sayı = 5;
int d = 0;
while (d<1)
{
    Console.WriteLine("1-10 Arasında Bir Sayı Seçiniz:");
    int tahmin = Convert.ToInt32(Console.ReadLine());
    
    if (tahmin != doğru_sayı)
    {
        Console.WriteLine("Yanlış Cevap!!!");
        Console.WriteLine("Tekrar Deneyiniz\n");
    }
    
    else
    {
        Console.WriteLine("Doğru Cevap, TEBRİKLER");
        d = 2;
    }
    
}

/* SORU 6 */
Console.WriteLine("\n- - - - - - - - - - - - - - -");
Console.WriteLine("Soru 6;\n");

string durum_kontrol;
do
{
    Console.WriteLine("Yapmak İstediğiniz İşlemi Seçiniz ( +  - / *) veya çıkış için 'çıkış' yazınız");
    durum_kontrol = Console.ReadLine();

    if (durum_kontrol == "çıkış")
    {
        break;
    }
    
    else
    {
        Console.WriteLine("Birinci Sayıyı Giriniz:");
        int sayı1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("İkinci Sayıyı Giriniz:");
        int sayı2 = Convert.ToInt32(Console.ReadLine());

        switch (durum_kontrol)
        {
            case "+":
                Console.WriteLine("Sonuç:" + (sayı1 + sayı2));
                break;

            case "-":
                Console.WriteLine("Sonuç:" + (sayı1 - sayı2));
                break;

            case "*":
                Console.WriteLine("Sonuç:" + (sayı1 * sayı2));
                break;

            case "/":
                if (sayı2 != 0)
                {
                    Console.WriteLine("Sonuç:" + (sayı1 / sayı2));
                }

                else
                {
                    Console.WriteLine("!!!Bir Sayı Sıfıra Bölünemez!!!");
                }
                break;

            default:
                Console.WriteLine("!!!Geçersiz İşlem!!!");
                break;
        }
    }
}
while (true);

/* SORU 7 */
Console.WriteLine("\n- - - - - - - - - - - - - - -");
Console.WriteLine("Soru 7;\n");

int e = 2;
int toplam = 0;
List<int> girilen_sayılar = new List<int>();
while (e>1)
{
    Console.WriteLine("Lütfen pozitif bir tam sayı giriniz.\nÇıkmak için 0 giriniz.");
    int girilen_değer = Convert.ToInt32(Console.ReadLine());
    
    if (girilen_değer == 0)
    {
        Console.WriteLine("Çıkış yapılıyor...");
        Console.WriteLine("Girdiğiniz Sayıların Toplamı:" + toplam);
        e = 0;
    }
    else
    {
        girilen_sayılar.Add(girilen_değer);
        toplam = toplam + girilen_değer;
    }
}

Console.WriteLine("\nGirilen Sayılar;");
for (int i=0; i < girilen_sayılar.Count; i++)
{
    Console.WriteLine("Sayı " + (i + 1) + " = " + girilen_sayılar[i]);
}