using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YURT_UYGULAMASI
{

    public class Yurt
    {
        string isim, soyisim;
        int sifre;
        int secim;

        public void girisEkrani()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|             Kayıt İçin (1)             |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("------------------------------------------");

            int kayit = Convert.ToInt32(Console.ReadLine());

            if (kayit == 1)
            {
                Console.Clear();                             
            }
        }
        public void yurtKayit()
        {
            Console.Write("İsminiz: ");
            isim = Console.ReadLine();
            Console.Write("Soyisminiz: ");
            soyisim = Console.ReadLine();
            while (true)
            {
                try
                {
                    Console.Write("Şifrenizi oluşturunuz: ");
                    sifre = Int32.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Hata, Sadece sayı giriniz! Hata mesajı: " + e.Message);
                }
            }
            Console.Clear();
            Console.WriteLine("Kayıt oluşturuluyor...");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Kaydınız " + isim+" "+ soyisim +  " Şifreniz "+ sifre+ " Olarak alındı.");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
        }
        public void anaEkran()
        {
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("| Yuna'nın yurduna Hoşgeldin " + isim + " "+ soyisim +"                 |");
            Console.WriteLine("-----------------------------------------------------");


            Console.WriteLine("------------------------------------------");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|     Bir odaya yerleşmek için(1)        |");
            Console.WriteLine("|     Yemekhaneye gitmek için (2)        |");
            Console.WriteLine("|     Bilgisayar odası için   (3)        |");
            Console.WriteLine("|     Kayıt iptali için       (4)        |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("------------------------------------------");
            while (true)
            {
                try
                {
                    Console.Write("Lütfen geçerli seçimi yapınız: ");
                    secim = Int32.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Hata, Yanlış seçim lütfen geçerli bir seçim yapınız. Hata mesajı: " + e.Message);
                }
            }
            if (secim == 1)
            {
                Console.Clear();
                Oda();
            }
            else if (secim == 2)
            {
                yemekhane();
            }
            else if (secim == 3)
            {
                BGodasi();
            }
            else if (secim == 4)
            {
                kayitİptal();
            }
        }
        public void Oda()
        {
            int oda;
            
            Console.WriteLine("Yurdumuzda odalar 3.Tip (4 kişilik) odadır.");

            Random rnd = new Random();
            oda = rnd.Next(0, 20);
            Console.WriteLine("Odanız "+ oda+" Numaralı odadır girmek için lütfen şifrenizi giriniz.");
            tkr:
            int odaSifre = Convert.ToInt16(Console.ReadLine());

            while (true)
            {
                
                if (odaSifre == sifre)
                {
                    Console.WriteLine("Odanıza hoşgeldiniz lütfen 4 yataktan birini seçiniz");
                    break;
                }
                else
                {
                    Console.WriteLine("Şifre yanlış lütfen tekrar deneyiniz.");
                    goto tkr;
                }
            }
            Console.WriteLine("Ana menüye dönmek için 'G'");
            string geri= Console.ReadLine();
            if ( geri == "G"||geri=="g" )
            {
                Console.Clear();
                anaEkran();
            }

            
            

        }
        public void yemekhane()
        {
            Console.Clear();
            Random rnd = new Random();
            Console.WriteLine("Yemekhaneye hoşgeldin\nYemekhanemizde 3 öğün yemek verilmektedir.");
            Console.WriteLine("|   |");
            Console.WriteLine("|   |");
            Console.WriteLine("|   |");
            Console.WriteLine("|   |");

            Console.WriteLine("Bugünki menüyü görmek için 'M'");
            string menuGstr=Console.ReadLine();

            if(menuGstr=="M"||menuGstr=="m") 
            {
                string[] menuler = { "Karnıyarık ve Pilav", "Tavuk sote ve Kremalı mantarlı makarna", "Dolma", "Balık ve Tarhana çorbası", "Sarma ve Börek" };
                int a;
                a = rnd.Next(0, menuler.Length);
                Console.WriteLine(menuler[a]);
            }

            Console.WriteLine("Ana menüye dönmek için 'G'");
            string geri = Console.ReadLine();
            if (geri == "G" || geri == "g")
            {
                Console.Clear();
                anaEkran();
            }


        }
        public void BGodasi()
        {
            Console.WriteLine("Bilgisayar odasına hoşgeldin");

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|         Oyun oynamak için (o)          |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("------------------------------------------");

            string game = Console.ReadLine();

            if(game == "o"|| game == "O")
            {
                Console.Clear();
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("|                                        |");
                Console.WriteLine("|                                        |");
                Console.WriteLine("|      Taş Kağıt Makas oyna    (1)       |");
                Console.WriteLine("|                                        |");
                Console.WriteLine("|      Sayı Tahmin Etmece oyna (2)       |");
                Console.WriteLine("|                                        |");
                Console.WriteLine("|                                        |");
                Console.WriteLine("------------------------------------------");
                
                int gamechs= Convert.ToInt32(Console.ReadLine());
                if (gamechs == 1)
                {
                    Random rnd = new Random();
                    Console.Clear();
                    Console.Write("------Taş Kağıt Makas------\n" +
                                  "1 - Bilgisayara Karşı\n" +
                                  "2 - İki Kişilik\n" +
                                  "Seçiniz : ");
                    int menuSecim = Convert.ToInt32(Console.ReadLine());
                    switch (menuSecim)
                    {
                        case 1:
                            Console.Clear();
                            Console.Write("------Taş Kağıt Makas------\n" +
                                            "1 - Taş\n" +
                                            "2 - Kağıt\n" +
                                            "3 - Makas\n" +
                                            "Seçiniz : ");
                            int oyuncuSecimPC = Convert.ToInt32(Console.ReadLine());
                            int pcSecim = rnd.Next(1, 3);

                            if (pcSecim == oyuncuSecimPC)
                            {
                                Console.Clear(); Console.WriteLine("------Taş Kağıt Makas------\n" +
                                                                                             "Berabere !");
                            }

                            else if (pcSecim == 1 && oyuncuSecimPC == 2)
                            {
                                Console.Clear(); Console.WriteLine("------Taş Kağıt Makas------\n" +
                                                                                                           "Oyuncu Kazandı !");
                            }

                            else if (pcSecim == 1 && oyuncuSecimPC == 3)
                            {
                                Console.Clear(); Console.WriteLine("------Taş Kağıt Makas------\n" +
                                                                                                           "Bilgisayar Kazandı !");
                            }

                            else if (pcSecim == 2 && oyuncuSecimPC == 1)
                            {
                                Console.Clear(); Console.WriteLine("------Taş Kağıt Makas------\n" +
                                                                                                           "Bilgisayar Kazandı !");
                            }

                            else if (pcSecim == 2 && oyuncuSecimPC == 3)
                            {
                                Console.Clear(); Console.WriteLine("------Taş Kağıt Makas------\n" +
                                                                                                           "Oyuncu Kazandı !");
                            }

                            else if (pcSecim == 3 && oyuncuSecimPC == 1)
                            {
                                Console.Clear(); Console.WriteLine("------Taş Kağıt Makas------\n" +
                                                                                                           "Bilgisayar Kazandı !");
                            }

                            else if (pcSecim == 3 && oyuncuSecimPC == 2)
                            {
                                Console.Clear(); Console.WriteLine("------Taş Kağıt Makas------\n" +
                                                                                                           "Oyuncu Kazandı !");
                            }
                            break;

                        case 2:
                            Console.Clear();
                            Console.Write("------Taş Kağıt Makas------\n" +
                                            "---------1. Oyuncu---------\n" +
                                            "1 - Taş\n" +
                                            "2 - Kağıt\n" +
                                            "3 - Makas\n" +
                                            "Seçiniz : ");
                            int oyuncuSecim = Convert.ToInt32(Console.ReadLine());

                            Console.Clear();
                            Console.Write("------Taş Kağıt Makas------\n" +
                                            "---------2. Oyuncu---------\n" +
                                            "1 - Taş\n" +
                                            "2 - Kağıt\n" +
                                            "3 - Makas\n" +
                                            "Seçiniz : ");
                            int oyuncu2Secim = Convert.ToInt32(Console.ReadLine());

                            if (oyuncu2Secim == oyuncuSecim)
                            {
                                Console.Clear(); Console.WriteLine("------Taş Kağıt Makas------\n" +
                                                                                             "Berabere !");
                            }

                            else if (oyuncu2Secim == 1 && oyuncuSecim == 2)
                            {
                                Console.Clear(); Console.WriteLine("------Taş Kağıt Makas------\n" +
                                                                                                                "1. Oyuncu Kazandı !");
                            }

                            else if (oyuncu2Secim == 1 && oyuncuSecim == 3)
                            {
                                Console.Clear(); Console.WriteLine("------Taş Kağıt Makas------\n" +
                                                                                                               "2. Oyuncu Kazandı !");
                            }

                            else if (oyuncu2Secim == 2 && oyuncuSecim == 1)
                            {
                                Console.Clear(); Console.WriteLine("------Taş Kağıt Makas------\n" +
                                                                                                                "2. Oyuncu Kazandı !");
                            }

                            else if (oyuncu2Secim == 2 && oyuncuSecim == 3)
                            {
                                Console.Clear(); Console.WriteLine("------Taş Kağıt Makas------\n" +
                                                                                                                "1. Oyuncu Kazandı !");
                            }

                            else if (oyuncu2Secim == 3 && oyuncuSecim == 1)
                            {
                                Console.Clear(); Console.WriteLine("------Taş Kağıt Makas------\n" +
                                                                                                                "1. Oyuncu Kazandı !");
                            }

                            else if (oyuncu2Secim == 3 && oyuncuSecim == 2)
                            {
                                Console.Clear(); Console.WriteLine("------Taş Kağıt Makas------\n" +
                                                                                                                "2. Oyuncu Kazandı !");

                            }
                            break;
                    }

                }
                if (gamechs == 2)
                {
                    Random rnd2= new Random();
                    int[] rastgeleSayilar = new int[10];
                    int enBuyukPuan = 0;
                    int enBuyukPuan_index = 0;
                    for (int i = 0; i < rastgeleSayilar.Length; i++)
                    {
                        rastgeleSayilar[i] = rnd2.Next(1, 10);
                    }

                    int tahminSayi;
                    Console.Write("Oyuncu Sayısını Giriniz : ");
                    int oyuncuSayisi = Convert.ToInt32(Console.ReadLine());
                    int[] puan = new int[oyuncuSayisi];
                    byte oyuncu = 0;

                    Console.Clear();

                    for (int i = 0; i < rastgeleSayilar.Length; i++)
                    {
                        while (true)
                        {
                            Console.WriteLine($"{i + 1}. Soru\n**************************");
                            Console.Write($"{oyuncu + 1}.Oyuncu Tahminizi Giriniz : ");

                            tahminSayi = Convert.ToInt32(Console.ReadLine());

                            if (rastgeleSayilar[i] == tahminSayi)
                            {
                                Console.WriteLine("Doğru Tahmin Ettiniz");
                                puan[oyuncu] += 10;
                            }
                            else
                            {
                                if (rastgeleSayilar[i] > tahminSayi)
                                {
                                    puan[oyuncu] += 10 - (rastgeleSayilar[i] - tahminSayi);
                                }

                                else
                                {
                                    puan[oyuncu] += 10 - (tahminSayi - rastgeleSayilar[i]);
                                }

                                Console.WriteLine("Yanlış Tahmin Ettiniz");
                            }

                            Console.Clear();

                            if (oyuncu == (oyuncuSayisi - 1))
                            {
                                for (int s = 0; s < oyuncuSayisi; s++)
                                {
                                    Console.WriteLine($"{s + 1}. Oyuncunun Puanı : {puan[s]}");

                                }
                                Console.Write("Devam Etmek İçin Herhangi Bir Tuşa Basınız ...");
                                Console.ReadKey();
                                Console.Clear();
                                oyuncu = 0;
                                break;
                            }
                            else
                            {
                                oyuncu++;
                            }
                        }

                    }
                    for (int i = 0; i < oyuncuSayisi; i++)
                    {

                        if (puan[i] > enBuyukPuan)
                        {
                            enBuyukPuan = puan[i];
                            enBuyukPuan_index = i;
                        }
                    }
                    for (int s = 0; s < oyuncuSayisi; s++)
                    {
                        Console.WriteLine($"{s + 1}. Oyuncunun Puanı : {puan[s]}");

                    }
                    Console.Write($"Kazanan Oyuncu {enBuyukPuan_index + 1}. Oyuncu Tebrikler !!");
                    Console.ReadKey();
                }

            }
        }
        public void kayitİptal()
        {
            Console.Clear();
            Console.WriteLine("Kaydınızı silme işlemine devam edebilmek için şifrenizi giriniz.");
            int kayitSifre = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (kayitSifre==sifre)
            {
                Console.WriteLine("Kaydınızı iptal ettirmek için 'İPTAL' yazınız.");
                string kayitSil = Console.ReadLine();
                if (kayitSil == "İPTAL" || kayitSil == "iptal")
                {
                    Console.WriteLine("Kaydınız siliniyor...");
                    Console.Clear();
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("Kaydınız silinmiştir. Görüşmek üzere!");
                    Console.WriteLine("Çıkmak için herhangi bir tuşa basın.");

                }
            }
            

        }
    }
    
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Yurt yurt = new Yurt();
            yurt.girisEkrani();
            yurt.yurtKayit();
            yurt.anaEkran();
           
            
            
           
        }
    }
}
