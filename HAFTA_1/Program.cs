
//HAFTA-1


//İki sayının farkını bulan c# kodu

//Console.WriteLine("1.sayıyı giriniz:");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("2.sayıyı giriniz:");
//int b  = Convert.ToInt32(Console.ReadLine());
//int c = a - b;
//Console.WriteLine("iki sayını farkı: " + c);




//5 sayısının karesini bulan c# kodu 

//int a = 5;
//int kare = a*a;
//Console.WriteLine("5 sayısının karesi: "+kare);




//10 sayısının 3 ' e bölümünden kalanını bulan  c# kodu 

//int kalan = 10 % 3;
//Console.WriteLine($"10 sayısının 3'e bölümünden kalan sayı {kalan}'dir");




//Klavyeden girilen 4 sayının toplamını ve çarpımını bulan c# kodu 

//Console.WriteLine("1.sayıyı giriniz:");
//int sayi1=Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("2.sayıyı giriniz:");
//int sayi2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("3.sayıyı giriniz:");
//int sayi3 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("4.sayıyı giriniz:");
//int sayi4 = Convert.ToInt32(Console.ReadLine());

//int toplam =sayi1 + sayi2+ sayi3 + sayi4;
//int carpım=sayi1*sayi2*sayi3*sayi4;

//Console.WriteLine("Sayıların toplamı:"+toplam);
//Console.WriteLine("Sayıların çarpımı:"+carpım);




//Klavyeden girilen 2 sayının bölümünü bulan c# kodu

//Console.WriteLine("1.sayıyı giriniz:");
//int a=Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("2.sayıyı giriniz:");
//int b = Convert.ToInt32(Console.ReadLine());

//int bolme = a / b;
//Console.WriteLine("Sayıların bölümü:"+bolme);




//Klavyeden kenarları girilen dikdörtgenler prizmasının hacmini hesaplayan   c# kodu 

Console.WriteLine("1.kenarı giriniz:");
int kenar1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("2.kenarı giriniz:");
int kenar2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("3.kenarı giriniz:");
int kenar3 = Convert.ToInt32(Console.ReadLine());

int hacim = kenar1 * kenar2 * kenar3;
Console.WriteLine("Dikdörtgen prizmanın hacmi:"+hacim);


Console.ReadKey();
