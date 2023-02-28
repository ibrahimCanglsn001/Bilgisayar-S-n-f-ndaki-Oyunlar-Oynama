using System;
using System.Numerics;
using System.Threading;

namespace Televizon
{
    class Bilgisayar
    {
        public void oyunlar()
        {
        b:
            Thread.Sleep(1000);
            Console.Clear();
            Thread.Sleep(1000);
            Console.WriteLine("                      ------------------------------------------------------------");
            Console.WriteLine("                      |                                                           |");
            Console.WriteLine("                      |                                                           |");
            Console.WriteLine("                      |  Tahmin Oyununu Oynamak İçin '1' Tuşuna Basınız           |");
            Console.WriteLine("                      |                                                           |");
            Console.WriteLine("                      |  Taş Kağıt Makas Oynamak İçin '2' Tuşuna Basınız          |");
            Console.WriteLine("                      |                                                           |");
            Console.WriteLine("                      |  Bilgisayarı Kapatmak İçin 'K' Tuşuna Basınız             |");
            Console.WriteLine("                      |                                                           |");
            Console.WriteLine("                      ------------------------------------------------------------");
            Console.WriteLine("                      |                          EXCALİBUR                        |");
            Console.WriteLine("                      ------------------------------------------------------------");
            string kanal = (Console.ReadLine());
            Console.Clear();
            if (kanal == "1")
            {

                Random random = new Random();
                int[] rastgeleSayilar = new int[5];
                for (int i = 0; i < rastgeleSayilar.Length; i++)
                {
                    rastgeleSayilar[i] = random.Next(1, 5);
                }
                int puan1 = 0;
                int puan2 = 0;
                for (int i = 0; i < rastgeleSayilar.Length; i++)
                {
                    Console.Write("1. Oyuncunun Tahmini: ");
                    int tahmin1 = Convert.ToInt32(Console.ReadLine());
                    if (tahmin1 == rastgeleSayilar[1])
                    {
                        puan1 += 10;
                    }
                    else
                    {
                        if (rastgeleSayilar[i] > tahmin1)
                        {
                            puan1 += 10 - (rastgeleSayilar[i] - tahmin1);
                        }
                        else
                        {
                            puan1 += 10 - (tahmin1 - rastgeleSayilar[i]);
                        }
                        {
                            Console.Clear();
                            //*********************** 2. oyuncu başlangıcı
                            Console.Write("2. Oyuncu Tahmini: ");
                            int tahmin2 = Convert.ToInt32(Console.ReadLine());
                            if (tahmin2 == rastgeleSayilar[i])
                            {
                                puan2 += 10;
                            }
                            else
                            {
                                if (rastgeleSayilar[i] > tahmin2)
                                {
                                    puan2 += 10 - (rastgeleSayilar[i] - tahmin2);
                                }
                                else
                                {
                                    puan2 += 10 - (tahmin2 - rastgeleSayilar[i]);

                                }
                            }
                            Console.Clear();
                            Console.WriteLine("1.Oyuncunun Puanı: " + puan1);
                            Console.WriteLine("2.Oyuncunun Puanı: " + puan2);


                            


                        }
                    }

                }
                Console.ReadKey();

                Console.WriteLine("Oyun Menüsünü Açmak İçin '3' Tuşuna Basınız");
                int deger = Convert.ToInt32(Console.ReadLine());

                if (deger == 3)
                {
                    goto b;
                }

            }


            if (kanal == "2")
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
                        Console.WriteLine("Oyun Menüsünü Açmak İçin '3' Tuşuna Basınız");
                        int deger = Convert.ToInt32(Console.ReadLine());

                        if (deger == 3)
                        {
                            goto b;
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
                        Console.WriteLine("Oyun Menüsünü Açmak İçin '3' Tuşuna Basınız");
                        int deger1 = Convert.ToInt32(Console.ReadLine());

                        if (deger1 == 3)
                        {
                            goto b;
                        }
                        break;
                }
            }

            if (kanal == "k")
            {
                Console.WriteLine("Bilgisayar Kapanıyor...");
            q:
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("                      ------------------------------------------------------------");
                Console.WriteLine("                      |  Kapandı                                                  |");
                Console.WriteLine("                      |                                                           |");
                Console.WriteLine("                      |                                                           |");
                Console.WriteLine("                      |                                                           |");
                Console.WriteLine("                      |                                                           |");
                Console.WriteLine("                      |                                                           |");
                Console.WriteLine("                      |                                                           |");
                Console.WriteLine("                      |                                                           |");
                Console.WriteLine("                      ------------------------------------------------------------");
                Console.WriteLine("                      |                          EXCALİBUR                        |");
                Console.WriteLine("                      ------------------------------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("Bilgisayarı Tekrar Açmak İçin  '1' Tuşuna Basınız");

                int secim = Convert.ToInt32(Console.ReadLine());
                if (secim == 1)
                {
                    Console.WriteLine("Açılıyor...");
                    goto b;
                }
                else
                {
                    if (secim != 1)
                        Console.WriteLine("Bilgisayarı Açmak İçin Lütfen Doğru Tuşa Basınız");
                    
                }
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
            a:
                Console.Clear();
                Bilgisayar pc1 = new Bilgisayar();
                Console.WriteLine("Bilgisayarı Açmak İçin '1' Tuşuna Basınız");
                int secim = Convert.ToInt32(Console.ReadLine());
                if (secim == 1)
                {
                    Console.WriteLine("Açılıyor...");
                }
                else if (secim != 1)
                {
                    Console.WriteLine("Lütfen Doğru Tuşa Basınız");
                    Thread.Sleep(1000);
                    goto a;
                }
                {
                    Thread.Sleep(1000);
                    Console.Clear();
                    Thread.Sleep(1000);
                    Console.WriteLine("                      ------------------------------------------------------------");
                    Console.WriteLine("                      |  Açıldı                                                   |");
                    Console.WriteLine("                      |                                                           |");
                    Console.WriteLine("                      |                                                           |");
                    Console.WriteLine("                      |                                                           |");
                    Console.WriteLine("                      |                                                           |");
                    Console.WriteLine("                      |                                                           |");
                    Console.WriteLine("                      |                                                           |");
                    Console.WriteLine("                      |                                                           |");
                    Console.WriteLine("                      ------------------------------------------------------------");
                    Console.WriteLine("                      |                          EXCALİBUR                        |");
                    Console.WriteLine("                      ------------------------------------------------------------");

                    pc1.oyunlar();
                    Console.ReadKey();

                }
            }
        }
    }
}

