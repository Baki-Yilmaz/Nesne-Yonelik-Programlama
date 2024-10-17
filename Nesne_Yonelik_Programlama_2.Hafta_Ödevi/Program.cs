/* İki sayının farkı */
int a = 13;
int b = 6;
int sonuc = a - b;
Console.WriteLine("İki Sayının Farkı:" + sonuc);

/* 5 sayısının karesi */
int c = 5;
int kare = c * c;
Console.WriteLine("5 Sayısının Karesi:" + kare);

/* 10 sayısının 3'e bölümünden kalanı */
double d = 10.0;
double e = 3.0;
double sonuc2 = d / e;
Console.WriteLine("10'un 3'e Bölümünden Kalan:" + sonuc2);

/* Klavyeden girilen 4 sayının toplamı ve çarpımı */
Console.WriteLine("\n~ ~ ~ 4 Sayının Toplamı ve Çarpımı ~ ~ ~\n");
Console.WriteLine("Birinci Sayıyı Giriniz;");
int s1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("İkinci Sayıyı Giriniz;");
int s2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Üçüncü Sayıyı Giriniz;");
int s3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Dördüncü Sayıyı Giriniz;");
int s4 = Convert.ToInt32(Console.ReadLine());
int sonuc3 = s1 + s2 + s3 + s4;
int sonuc4 = s1 * s2 * s3 * s4;
Console.WriteLine("Girdiğiniz Sayıların Toplamı:" + sonuc3);
Console.WriteLine("Girdiğiniz Sayıların Çarpımı:" + sonuc4);

/* Kalvyeden girilen 2 sayının bölümü */
Console.WriteLine("\n~ ~ ~ 2 Sayının Bölümü ~ ~ ~\n! ! ! Sayılar Ondalıklı (0.00) Şeklinde Giriniz ! ! !\n");
Console.WriteLine("Bölünen Sayıyı Giriniz;");
double bolunen = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Bölen Sayıyı Giriniz;");
double bolen = Convert.ToDouble(Console.ReadLine());
double sonuc5 = bolunen / bolen;
Console.WriteLine("İki Sayınının Bölümü:" + sonuc5);

/* Klavyeden verileri girilen dikdörtgenler prizması hacimini hesaplama */
Console.WriteLine("Birinci Kenarı Giriniz;");
int kenar1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("İkinci Kenarı Giriniz;");
int kenar2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Üçüncü Kenarı Giriniz;");
int kenar3 = Convert.ToInt32(Console.ReadLine());
int sonuc6 = kenar1 * kenar2 * kenar3;
Console.WriteLine("Dikdörtgenler Prizmasının Hacimi:" + sonuc6);