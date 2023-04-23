namespace Project_1_Calculator;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("HESAP MAKİNASI");

        int toplam = 0, cıkarma = 0, carpma = 0, bolme = 0;

        Console.WriteLine("Bir sayı girin");
        int sayi1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Bir sayı girin");
        int sayi2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Lütfen yapmak istediğiniz işlemi girin! ('Toplama: + ,Çıkarma: - ,Çarpma: x ,Bölme: / ')");

        char islem = char.Parse(Console.ReadLine());

        if (sayi2 == 0)
        {
            Console.WriteLine("Sayı 0 olamaz");
            return;
        }
        else
        {

        }
        switch (islem)
        {

            case ('+'):
                toplam = sayi1 + sayi2;
                Console.WriteLine(toplam);
                break;
            case ('-'):
                cıkarma = sayi1 - sayi2;
                Console.WriteLine(cıkarma);
                break;
            case ('x'):
                carpma = sayi1 * sayi2;
                Console.WriteLine(carpma);
                break;
            case ('/'):
                bolme = sayi1 / sayi2;
                Console.WriteLine(bolme);
                break;


        }

    }
}

