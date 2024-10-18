
//HAFTA-2

//Girilen sayının çift - tek kontrolü (if)

//Console.WriteLine("bir sayı giriniz");
//int sayi=int.Parse(Console.ReadLine());

//if (sayi%2 == 0)
//    Console.WriteLine("Sayı çifttir");
//else
//    Console.WriteLine("Sayı tektir");



//1 den 10 a kadar sayıları ekrana yazı değeri olarak yazma işlemi (örn 1 girildiğinde ekrana BİR yazılsın - switch yapısı)


//Console.WriteLine("1 ile 10 arası sayı giriniz");
//int a =int.Parse(Console.ReadLine());

//switch (a)
//{
//    case 1:
//        Console.WriteLine("BİR");
//        break;
//    case 2:
//        Console.WriteLine("İKİ");
//        break;
//    case 3:
//        Console.WriteLine("ÜÇ");
//        break;
//    case 4:
//        Console.WriteLine("DÖRT");
//        break;
//    case 5:
//        Console.WriteLine("BEŞ");
//        break;
//    case 6:
//        Console.WriteLine("ALTI");
//        break;
//    case 7:
//        Console.WriteLine("YEDİ");
//        break;
//    case 8:
//        Console.WriteLine("SEKİZ");
//        break;
//    case 9:
//        Console.WriteLine("DOKUZ");
//        break;
//    case 10:
//        Console.WriteLine("ON");
//        break;
//    default:
//        Console.WriteLine("1 ile 10 arası sayı girmediniz!");
//        break;
//}



//Kullanıcı adı admin ve şifre Admin_32453@ olduğunda giriş başarılı değilse başarısız uyarısı veren c# kodu


//Console.WriteLine("Kullanıcı adınızı giriniz");
//string KA=Console.ReadLine();
//Console.WriteLine("Şifrenizi giriniz");
//string sifre = Console.ReadLine();


//if (KA == "admin" && sifre == "Admin_32453@")
//    Console.WriteLine("Giriş başarılı");
//else
//    Console.WriteLine("Giriş başarısız");

//10 - 20 20 - 30 30 - 40 arası sıcaklık durumlarına göre ekrana (normal - sıcak - çok sıcak) uyarısı veren veren c# kodu (if else if else if else yapısı)


Console.WriteLine("Sıcaklık değerini giriniz");
int sıcaklık=int.Parse(Console.ReadLine());

if (sıcaklık >= 10 && sıcaklık <= 20)
    Console.WriteLine("Normal");
else if (sıcaklık >= 20 && sıcaklık <= 30)
    Console.WriteLine("Sıcak");
else if (sıcaklık >= 30 && sıcaklık <= 40)
    Console.WriteLine("Çok sıcak");
else
    Console.WriteLine("Yanlış değer");


Console.ReadKey();