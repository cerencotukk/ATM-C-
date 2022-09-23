using System;

namespace mini_atm
{
    class Program
    {
        static void Main(string[] args)
        {

            int bakiye = 1000;

            Console.WriteLine("ATM ye Hoşgeldiniz");
            Console.WriteLine("Yapmak İstediğiniz İşlemi Seciniz");
            String secim = Console.ReadLine();

            if (secim == "1")
            {
                Console.WriteLine("Suanki bakiyeniz :" + bakiye);
            }
            else if (secim == "2")
            {
                Console.WriteLine("Cekmek İstediğiniz Tutarı Giriniz");
                int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Kalan Tutar :" + (bakiye-cekilecek_tutar));
            }
            else if (secim == "3")
            {
                Console.WriteLine("Yatırmak İstediğiniz Tutarı Giriniz");
                int yatirilacak_tutar = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("yeni bakiyeniz :"+ (bakiye+yatirilacak_tutar));

            }
            else if (secim=="q")
            {
                Console.WriteLine("Atmden cıkıs yapılıyor");
                Console.WriteLine("Cıkıs yapıldı iyi günler...");
                
            }
            else
            {
                Console.WriteLine("lütfen gecerli bir deger giriniz!");

            }
        }
    }
}
