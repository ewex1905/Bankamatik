using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba Bankamatik Uygulamasına Hoşgeldiniz");
            Console.WriteLine("Bevcut Bakiye 250 tl");
            Console.WriteLine("Kartlı İşlem İçin 1");
            Console.WriteLine("Kartsız İşlem İçin 2");
            double islem = Convert.ToInt32(Console.ReadLine());
            int sifre = 1528;
            if (islem == 1)
            {
                

                if (sifre == 1528) ;
                {
                    Console.WriteLine("Şifreniz Doğru");
                }
                else 
                {
                    Console.WriteLine("Şifreniz Yanlış");
                }
                Console.WriteLine("Para Çekmek İçin 1");
                Console.WriteLine("Para Yatırmak İçin 2");
                Console.WriteLine("Para Transferleri İçin 3");
                Console.WriteLine("Eğitim Ödemeleri İçin 4");
                Console.WriteLine("Ödemeler İçin 5");
                Console.WriteLine("Bilgi Günceleme için 6");
                if (islem == 1)
                {
                    Console.WriteLine("Paranız Çekiliyor");
                }
                else if (islem == 2)
                {
                    Console.WriteLine("Kredi Kartına 1");
                    Console.WriteLine("Kendi Hesabınıza Yatırmak İçin 2");
                    Console.WriteLine("Ana Menü 9");
                    Console.WriteLine("Çıkmak İçin 0");
                }
                if (islem ==1)
                {
                    Console.WriteLine("12 Haneli Kredi Kartı Numarasını Giriniz");
                    double num = 123456789101;
                    if (num == 123456789101)
                        Console.WriteLine("Paranız Çekiliyor");
                    else
                        Console.WriteLine("Numara Yanlış");
                }
                else if (islem == 2)
                        {
                    Console.WriteLine("Hesaba Girilecek Tutarı yazınız");
                    double para = 10;
                    if (para < 10)
                        Console.WriteLine("Paranız Yatırılıyor");
                        }
                else if(islem == 3)
                        {
                    Console.WriteLine("12 Haneli Kredi Kartı Numarasını Giriniz");
                    double num = 123456789101;
                    if (num == 123456789101)
                    {
                        Console.WriteLine("Yatırılacak Parayı Girin");
                        double para = 10;
                        if (para < 10)
                            Console.WriteLine("Paranız Yatırılıyor");
                    }
                    else
                        Console.WriteLine("Numara Yanlış");
                        }
                else if (islem == 4)
                { 
                Console.WriteLine("Eğitim Ödemeleleri Arızalı");                
                }
                else if (islem == 5)
                {
                    Console.WriteLine("Elektrik Faturası İçin 1");
                    Console.WriteLine("Telefon Faturası İçin 2");
                    Console.WriteLine("İnternet Faturası İçin 3");
                    Console.WriteLine("Su Faturası İçin 4");
                    Console.WriteLine("OGS Ödemeleri İçin 5");
                    if (islem == 1)
                    {
                        Console.WriteLine("Borcunuz 150 TL");
                        double para = 150;
                        if (para < 150)
                        {
                            Console.WriteLine("Borcunuz Ödenmiştir");
                        }
                        else (para > 150 )
                                {
                            Console.WriteLine("Yetersiz Bakiye");
                                }                                           
                    }
                            if (islem == 2)
                            {
                                Console.WriteLine("Borcunuz 150 TL");
                                double para = 150;
                                if (para < 150)
                                {
                                    Console.WriteLine("Borcunuz Ödenmiştir");
                                }
                                else (para > 150)
                                {
                                    Console.WriteLine("Yetersiz Bakiye");

                                }
                            }
                    }
                        if (islem == 3)
                        {
                            Console.WriteLine("Borcunuz 50 TL");
                            double para = 50;
                            if (para < 50)
                            {
                                Console.WriteLine("Borcunuz Ödenmiştir");
                            }
                            else (para > 50)
                                {
                                Console.WriteLine("Yetersiz Bakiye");
                                }
                        }
                    if (islem == 4)
                    {
                        Console.WriteLine("Borcunuz 350 TL");
                        double para = 350;
                        if (para < 350)
                        {
                            Console.WriteLine("Borcunuz Ödenmiştir");
                        }
                        else (para > 350)
                                {
                            Console.WriteLine("Yetersiz Bakiye");
                                }
                    }
                    if (islem == 5)
                    {
                        Console.WriteLine("Borcunuz 250 TL");
                        double para = 250;
                        if (para < 250)
                        {
                            Console.WriteLine("Borcunuz Ödenmiştir");
                        }
                        else (para > 250)
                                {
                            Console.WriteLine("Yetersiz Bakiye");
                                }
                    }
                    if (islem == 6)
                    {
                    Console.WriteLine("şifre değiştirmek için 1");
                    bool parola = 1;
                    if (parola = 1)
                    {
                        Console.WriteLine("Şifreniz Değiştiriliyor");
                    }
               
                    } 



            }
            else (islem == 2)
            {
                Console.WriteLine("CepBank Para Çekmek İçin 1");
                Console.WriteLine("Para Yatırmak İçin 2");
                Console.WriteLine("Kredi Kartı Ödeme İçin 3");
                Console.WriteLine("Eğitim Ödemeleri İçin 4");
                Console.WriteLine("Ödemeler İçin 6");
                if (islem == 1)
                {
                    Console.WriteLine("TC Kimlik Numaranızı Girin");
                    double tc = 12345678901;
                    if (tc == 12345678901)
                    {
                        Console.WriteLine("Tc Numaranız Doğru 1000 TL Ödemenizi Alınız");
                    }
                    else (tc == 12345678901)
                            {
                        Console.WriteLine("TC Numaranızn Yanlış");
                    }
                }
                if (islem == 2)
                {
                    Console.WriteLine("Nakit Ödeme İçin 1");
                    Console.WriteLine("Hesaptan Ödeme için 2");
                    if (islem == 1)
                    {
                        Console.WriteLine("12 Haneli Kredi Kartı Numarasını Giriniz");
                        double num = 123456789101;
                        if (num == 123456789101)
                        {
                            Console.WriteLine("Numaralar Doğru Şimdi TC Kimlik Numaranızı Girin");
                        }                                               
                        else
                        {
                            Console.WriteLine("Numara Yanlış");
                        } 
                        if (num == 12345678901)
                         Console.WriteLine("TC Kimlik Numaranızı Girin");
                          double tc = 12345678901;
                           if (tc == 12345678901)
                        {
                            Console.WriteLine("Numaeranız Doğru");
                        }
                           else
                        {
                            Console.WriteLine("Numaranız Yanılş");
                        }
                        
                    }                    
                    else if (islem == 2)
                    {
                        Console.WriteLine("12 Haneli Kredi Kartı Numarasını Giriniz");
                        double num = 123456789101;
                        if (num == 123456789101)
                        {
                            Console.WriteLine("Şifreniz Doğru Paranızı Alttaki Bölmeden Alın");
                        }
                        else
                        {
                            Console.WriteLine("Numaranız Yanlış");
                        }
                    }

                }
                if (islem == 3)
                {
                    Console.WriteLine("Başka Hesaba EFT İçin 1");
                    Console.WriteLine("Başka Hesaba Havale İçin 2");
                    if (islem == 1)
                    {
                        Console.WriteLine("12 Haneli Kredi Kartı Numarasını Giriniz");
                        double num = 123456789101;
                        if (num == 123456789101)
                        {
                            Console.WriteLine("Numaranız Doğru");
                        }
                        else
                        {
                            Console.WriteLine("Numaranız Yanlış");
                        }
                        if (islem == 2)
                        {
                            Console.WriteLine("11 Haneli Kredi Kartı Numarasını Giriniz");
                            double num = 12345678910;
                            if (num == 12345678910)
                            {
                                Console.WriteLine("Gönderilecek Tutar Ne Kadar")
                                    double para = 10;
                                if (para < 10)
                                {
                                    Console.WriteLine("Paranız paranız Göndeeriliyor");
                                }
                                else
                                {
                                    Console.WriteLine("Lütfen 10 TL den Yüksek Bir Rakam GİRİN");
                                }
                            }
                        }
                    }
                }
                else if (islem == 4)
                {
                    Console.WriteLine("Eğitim Ödemeleri ARIZALI");
                }
                else if (islem == 5)
                {
                    Console.WriteLine("Elektrik Faturası İçin 1");
                    Console.WriteLine("Telefon Faturası İçin 2");
                    Console.WriteLine("İnternet Faturası İçin 3");
                    Console.WriteLine("Su Faturası İçin 4");
                    Console.WriteLine("OGS Ödemeleri İçin 5");
                    if (islem == 1)
                    {
                        Console.WriteLine("Borcunuz 150 TL");
                        double para = 150;
                        if (para < 150)
                        {
                            Console.WriteLine("Borcunuz Ödenmiştir");
                        }
                        else (para > 150)
                                {
                            Console.WriteLine("Yetersiz Bakiye");
                        }
                    }
                    if (islem == 2)
                    {
                        Console.WriteLine("Borcunuz 150 TL");
                        double para = 150;
                        if (para < 150)
                        {
                            Console.WriteLine("Borcunuz Ödenmiştir");
                        }
                        else (para > 150)
                                {
                            Console.WriteLine("Yetersiz Bakiye");

                        }
                    }
                }
                if (islem == 3)
                {
                    Console.WriteLine("Borcunuz 50 TL");
                    double para = 50;
                    if (para < 50)
                    {
                        Console.WriteLine("Borcunuz Ödenmiştir");
                    }
                    else (para > 50)
                                {
                        Console.WriteLine("Yetersiz Bakiye");
                    }
                }
                if (islem == 4)
                {
                    Console.WriteLine("Borcunuz 350 TL");
                    double para = 350;
                    if (para < 350)
                    {
                        Console.WriteLine("Borcunuz Ödenmiştir");
                    }
                    else (para > 350)
                                {
                        Console.WriteLine("Yetersiz Bakiye");
                    }
                }
                if (islem == 5)
                {
                    Console.WriteLine("Borcunuz 250 TL");
                    double para = 250;
                    if (para < 250)
                    {
                        Console.WriteLine("Borcunuz Ödenmiştir");
                    }
                    else (para > 250)
                                {
                        Console.WriteLine("Yetersiz Bakiye");
                    }
                }
            }
            

             






        
