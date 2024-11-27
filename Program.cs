

//            {
//                // Kullanıcıdan iki sayı al
//                Console.Write("Birinci sayıyı girin: ");
//                double sayi1 = Convert.ToDouble(Console.ReadLine());

//                Console.Write("İkinci sayıyı girin: ");
//                double sayi2 = Convert.ToDouble(Console.ReadLine());

//                // Çarpımı hesapla
//                double carpim = sayi1 * sayi2;

//                // Sonucu yazdır
//                Console.WriteLine("Çarpım: " + carpim);
//            }
//        }
//    }
//}

//        {
//            // Kullanıcıdan iki sayı al
//            Console.WriteLine("Birinci sayıyı girin:");
//            int sayi1 = Convert.ToInt32(Console.ReadLine());

//            Console.WriteLine("İkinci sayıyı girin:");
//            int sayi2 = Convert.ToInt32(Console.ReadLine());

//            // Sayıları topla
//            int toplam = sayi1 + sayi2;

//            // Sonucu ekrana yazdır
//            Console.WriteLine("Toplam: " + toplam);

//        }  Console.ReadKey(); 

//    }
//}
//            #region switch case ders progranı
//            Console.WriteLine("1 - Öğrenci");
//            Console.WriteLine("2 - öğretmen");
//            Console.WriteLine("3 - ders sınıf programı");

//            string secim = Console.ReadLine();
//            switch (secim)
//            {

//                case "1":

//                    Console.WriteLine("Pazartesi - Matematk");
//                    Console.WriteLine("Salı - Edebiyat");
//                    Console.WriteLine("Çarşamba - Matematik");
//                    Console.WriteLine("Perşembe - Matematik");
//                    Console.WriteLine("Cuma - Matematik");
//                    break;

//                case "2":

//                    Console.WriteLine("Pazartesi - Matematk");
//                    Console.WriteLine("Salı - Felsefe");
//                    Console.WriteLine("Çarşamba - Matematik");
//                    Console.WriteLine("Perşembe - Matematik");
//                    Console.WriteLine("Cuma - Matematik");
//                    break;

//                case "3":

//                    Console.WriteLine("Pazartesi - Matematk");
//                    Console.WriteLine("Salı - Beden");
//                    Console.WriteLine("Çarşamba - Matematik");
//                    Console.WriteLine("Perşembe - Matematik");
//                    Console.WriteLine("Cuma - Matematik");
//                    break;

//            }
//            Console.ReadKey();
//            #endregion
//        }
//    }
//}
//string ad, soyad;

//ad="Sudenur";
//soyad="Selek";

//Console.WriteLine(" Merhaba "+ad+" "+soyad+" Hoşgeldiniz");

//            //Console.ReadKey();
//        }
//    }
//        //}
//        int adet, fiyat;

//        Console.WriteLine("Almak istediğiniz ürünün adetini giriniz");
//        adet = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Almak istediğiniz ürünün adet fiyatını giriniz");
//        fiyat = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("Toplam ödemeniz: " + fiyat * adet + " Tl dir");

//        Console.ReadKey();
//    }
//}
//}
//        string adsoyad ;
//        int yas ;

//        Console.WriteLine("Adınzı ve soyadınızı giriniz");
//        adsoyad = Console.ReadLine();
//        Console.WriteLine("Yaşınızı giriniz");
//        yas = Convert.ToInt32(Console.ReadLine());

//        if (yas >= 18)
//        {
//            Console.WriteLine("Merhaba " + adsoyad + " yaşınız: " + yas + " Reşitsiniz");
//        }
//        else
//        {
//            Console.WriteLine("Merhaba " + adsoyad + " yaşınız: " + yas + " Reşit değilsiniz");
//        }
//        Console.ReadKey();
//    }
//}
//}
//            int sayi;

//            Console.WriteLine("Bir sayı giriniz");
//            sayi = Convert.ToInt32(Console.ReadLine());

//            if (sayi % 2 == 0)
//            {
//                Console.WriteLine("Sayı çift");
//            }
//            else
//            {
//                Console.WriteLine("Sayı tek");
//            }
//            Console.ReadKey();
//        }
//    }
//}
//            string ad;
//            Console.WriteLine("Adınızı Giriniz");
//            ad = Console.ReadLine();
//            if (ad.Length > 7)
//            {
//                Console.WriteLine("Adınız uzun");
//            }
//            else
//            {
//                Console.WriteLine("Adınz Kısa");
//            }

//            Console.ReadKey();
//        }
//    }
//}
//            int cevre, alan, r;

//            Console.WriteLine("Çemberin Yarı Çapını Giriniz");
//            r = Convert.ToInt32(Console.ReadLine());
//            cevre = r * 2 * 3;
//            alan = r * r * 3;

//            Console.WriteLine("Çemberin çevresi :  " + cevre);
//            Console.WriteLine("Çemberin Aalanı : " + alan);


//            Console.ReadKey();
//        }
//    }
//}
//            int sayi;
//            Console.WriteLine("Bir Sayı Giriniz");
//            sayi = Convert.ToInt32(Console.ReadLine());

//            if (sayi >= 0)
//            {
//                Console.WriteLine("Sayı Pozitiftir");
//            }
//            else
//            {
//                Console.WriteLine("Sayı Pozitif değildir");
//            }

//            Console.ReadKey();
//        }
//    }
//}
//            string kullanıcıadı, sifre;
//            Console.WriteLine("Kullanıcı Adı Giriniz");
//            kullanıcıadı = Console.ReadLine();

//            Console.WriteLine("Şifrenizi Giriniz");
//            sifre = Console.ReadLine();

//            if (kullanıcıadı == "byboo" && sifre == "12345")
//            {
//                Console.WriteLine("Giriş başarılı");
//            }
//            else
//            {
//                Console.WriteLine("Kulllanıcı adı veya şifre hatalı lütfen tekrar deneyiniz");
//            }

//            Console.ReadKey();


//        }
//    }
//}
//            for (int adim = 0; adim <= 100; adim = adim + 2)
//            {
//                Console.WriteLine(adim);
//            }
//            Console.ReadLine();

//        }
//    }
//}
//        int buyuk = 0, kucuk = 0, sayi = 0;                               SIKINTILI BİR ARKADAŞ!!!!!!!!!!!!!!!!!

//        for (int i = 1; i <= 5; i++)
//        {
//            Console.Write((i) + ". sayıyı giriniz");
//            sayi = Convert.ToInt32(Console.ReadLine());

//            if (i == 1)
//            {
//                buyuk = sayi;
//                kucuk = sayi;
//            }
//            if (kucuk > sayi)
//            {
//                kucuk = sayi;
//            }
//            if (buyuk < sayi)
//            {
//                buyuk = sayi;
//            }
//        }

//        Console.WriteLine("en büyük sayı" + buyuk);
//        Console.WriteLine("en küçük sayı" + kucuk);

//        Console.ReadKey();
//    }
//}
//}
//            int sayi;

//            Console.WriteLine("Sayıyı giriniz");
//            sayi = Convert.ToInt32(Console.ReadLine());

//            if (sayi % 7 == 0)
//            {
//                Console.WriteLine("Sayı 7'nin katıdır");
//            }
//            else
//            {
//                Console.WriteLine("Sayı 7'nin katı değildir");
//            }

//            Console.ReadKey();
//        }
//    }
//}
//            int s = 0;
//            for (int i = 1; i <= 5; i++)
//            {
//                Console.WriteLine(i + ".Sayıyı giriniz:");

//                int sayi = Convert.ToInt32(Console.ReadLine());

//                s += sayi;
//            }
//            Console.WriteLine("toplam" + s);
//            Console.WriteLine("ortalaması" + s / 5);

//            Console.ReadKey();

//        }
//    }
//}
//            for (int a = 0; a < 100; a++)
//            {
//                Console.SetCursorPosition(a, 15);
//                Console.Write("Seni Seviyorumm");
//                System.Threading.Thread.Sleep(10);
//            }
//            Console.ReadKey();

//        }
//    }
//}
//            int s = 0;

//            for (int i = 1; i <= 10; i++)
//            {
//                Console.WriteLine(i + ".sayı giriniz:");
//                int sayi = Convert.ToInt32(Console.ReadLine());
//                s += sayi;
//            }
//            Console.WriteLine("toplam:" + s);
//            Console.WriteLine("ortalama:" + s / 10);

//            Console.ReadKey();

//        }
//    }
//}

//        int s = 0;
//        for (int i = 1; i <= 12; i++)
//        {
//            Console.WriteLine(i + ".Sayı giriniz");
//            int sayi1 = Convert.ToInt32(Console.ReadLine());
//            s += sayi1;
//        }
//        Console.WriteLine("Toplam:" + s);
//        Console.WriteLine("Ortalama" + s / 12);


//        Console.ReadKey();
//    }
//}
//}
//            int s = 0;
//            for (int i = 1; i <= 4; i++)
//            {
//                Console.WriteLine(i + ".Sayı giriniz");
//                int sayi = Convert.ToInt32(Console.ReadLine());
//                s += sayi;
//            }
//            Console.WriteLine("Toplam:" + s);
//            Console.WriteLine("Ortolama" + s / 4);


//            Console.ReadKey();
//        }
//    } 

//}

//            int s = 0;
//            for (int i = 1; i <= 5; i++)
//            {
//                Console.WriteLine(i + ".Sayı giriniz");
//                int sayi = Convert.ToInt32(Console.ReadLine());
//                s += sayi;
//            }
//            Console.WriteLine("Toplam:" + s);
//            Console.WriteLine("Ortalama:" + s / 5);

//            Console.ReadKey();
//        }
//    }
//}

//        int s = 0;
//        for (int i = 1; i <= 13; i++)
//        {
//            Console.WriteLine(i + ".Sayı giriniz");
//            int sayi = Convert.ToInt32(Console.ReadLine());
//            s += sayi;
//        }

//        Console.WriteLine("Toplam:" + s);
//        Console.WriteLine("Ortalama:" + s / 13);

//        Console.ReadKey();

//    } 
//}
//}

//            int s = 0;
//            for (int i = 1; i <= 10; i++)
//            {
//                Console.WriteLine(i + ".Sayıyı giriniz");
//                int sayi = Convert.ToInt32(Console.ReadLine());
//                s += sayi;
//            }
//            Console.WriteLine("Toplam" + s);
//            Console.WriteLine("Ortalama" + s / 10);

//            Console.ReadKey();
//        }
//    }
//}




//        Console.Write("Bir sayı girin: ");
//        int sayi = int.Parse(Console.ReadLine());

//        int toplam = 0;

//        for (int i = 1; i <= sayi; i++)
//        {
//            toplam += i;
//        }

//        Console.WriteLine($"1'den {sayi}'ye kadar olan sayıların toplamı: {toplam}");
//        Console.ReadKey();
//    }

//}
//}
//            Console.WriteLine("Bir sayı giriniz:");
//            int sayi = int.Parse(Console.ReadLine());

//            if (MükemmelSayiMi(sayi))
//            {
//                Console.WriteLine($"{sayi} bir mükemmel sayıdır.");
//            }
//            else
//            {
//                Console.WriteLine($"{sayi} bir mükemmel sayı değildir.");
//            }
//        }

//    }
//}

//        Console.WriteLine("Bir sayı giriniz: ");
//        if (int.TryParse(Console.ReadLine(), out int number))
//        {
//            if (IsPerfectNumber(number))
//            {
//                Console.WriteLine($"{number} bir mükemmel sayıdır.");
//            }
//            else
//            {
//                Console.WriteLine($"{number} bir mükemmel sayı değildir.");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Lütfen geçerli bir tamsayı giriniz.");
//        }
//        Console.ReadKey();

//    }
//}
//}

//        Console.Write("Bir sayı girin: ");
//        int sayi = int.Parse(Console.ReadLine());

//        int basamakSayisi = sayi.ToString().Length;

//        int toplam = 0;
//        int geçiciSayi = sayi;

//        while (geçiciSayi > 0)
//        {
//            int basamak = geçiciSayi % 10;
//            toplam += (int)Math.Pow(basamak, basamakSayisi);
//            geçiciSayi /= 10;
//        }

//        if (toplam == sayi)
//        {
//            Console.WriteLine($"{sayi} bir Armstrong sayısıdır");
//        }
//        else
//        {
//            Console.WriteLine($"{sayi} bir Armstrong sayısı değildir");

//        Console.ReadKey();

//        }
//    }
//}
//            List<string> ogrenciListe = new List<string> { "Ahmet", "Mehmet" };
//            int ogrencisayi = ogrenciListe.Count;

//            Console.WriteLine("Geziye katılacak öğrencilerin listesini yönetmek için:");
//            Console.WriteLine("1 - Yeni öğrenci ekle");
//            Console.WriteLine("2 - Toplam eklenen öğrenci sayısını gör");
//            Console.WriteLine("3 - Aracı kontrol et");
//            Console.WriteLine("0 - Programdan çık");

//            while (true)
//            {
//                Console.WriteLine("\nBir işlem seçin:");
//                int karar = Convert.ToInt32(Console.ReadLine());

//                switch (karar)
//                {
//                    case 1:
//                        Console.WriteLine("Eklemek istediğiniz öğrencinin adını yazın:");
//                        string yeniOgrenci = Console.ReadLine();
//                        ogrenciListe.Add(yeniOgrenci);
//                        ogrencisayi++;
//                        Console.WriteLine($"{yeniOgrenci} listeye eklendi.");
//                        break;

//                    case 2:
//                        Console.WriteLine($"Toplam eklenen öğrenci sayısı: {ogrencisayi}");
//                        Console.WriteLine("Öğrenciler:");
//                        foreach (var ogrenci in ogrenciListe)
//                        {
//                            Console.WriteLine("- " + ogrenci);
//                        }
//                        break;

//                    case 3:
//                        Console.WriteLine("Araç kapasitesini girin:");
//                        int kapasite = Convert.ToInt32(Console.ReadLine());

//                        if (ogrencisayi <= kapasite)
//                        {
//                            Console.WriteLine("Tüm öğrenciler araca sığabilir.");
//                        }
//                        else
//                        {
//                            Console.WriteLine($"Aracın kapasitesi yetersiz! {ogrencisayi - kapasite} kişi dışarıda kalacak.");
//                        }
//                        break;

//                    case 0:
//                        Console.WriteLine("Programdan çıkılıyor...");
//                        return;

//                    default:
//                        Console.WriteLine("Geçersiz seçim, lütfen tekrar deneyin.");
//                        break;
//                }
//            }
//        }
//    }
//}

using System;
using System.Collections.Generic;

class Program
{
    
    public class Urun
    {
        public string Adi { get; set; }
        public decimal BirimFiyat { get; set; }
        public int Adet { get; set; }

        public Urun(string adi, decimal birimFiyat, int adet)
        {
            Adi = adi;
            BirimFiyat = birimFiyat;
            Adet = adet;
        }
    }

    
    public class Depo
    {
        public List<Urun> Urunler { get; set; }

        public Depo()
        {
            Urunler = new List<Urun>();
        }

        public void UrunEkle(string adi, decimal birimFiyat, int adet)
        {
            var mevcutUrun = Urunler.Find(u => u.Adi == adi);
            if (mevcutUrun != null)
            {
                mevcutUrun.Adet += adet;
            }
            else
            {
                Urunler.Add(new Urun(adi, birimFiyat, adet));
            }
            Console.WriteLine($"{adi} ürünü depoya eklendi.");
        }

       
        public bool UrunSat(string adi, int adet, decimal param)
        {
            var urun = Urunler.Find(u => u.Adi == adi);
            if (urun == null)
            {
                Console.WriteLine("Depoda bu ürün bulunmamaktadır.");
                return false;
            }
            if (urun.Adet < adet)
            {
                Console.WriteLine("Depoda yeterli adet yok.");
                return false;
            }

            decimal toplamTutar = urun.BirimFiyat * adet;
            if (param < toplamTutar)
            {
                Console.WriteLine("Yeterli paranız yok.");
                return false;
            }

            urun.Adet -= adet;
            Console.WriteLine($"{adet} adet {adi} satıldı. Toplam tutar: {toplamTutar} TL.");
            return true;
        }

        
        public void UrunleriListele()
        {
            if (Urunler.Count == 0)
            {
                Console.WriteLine("Depoda hiç ürün yok.");
                return;
            }
            foreach (var urun in Urunler)
            {
                Console.WriteLine($"Ürün: {urun.Adi}, Birim Fiyatı: {urun.BirimFiyat} TL, Stok: {urun.Adet}");
            }
        }
    }

    static void Main(string[] args)
    {
        Depo depo = new Depo();
        decimal bakiye = 1000m;  

        while (true)
        {
            Console.WriteLine("\n1. Ürün Ekle");
            Console.WriteLine("2. Ürün Sat");
            Console.WriteLine("3. Depoyu Listele");
            Console.WriteLine("4. Çıkış");
            Console.Write("Seçiminizi yapın: ");
            string secim = Console.ReadLine();

            if (secim == "1")
            {
                Console.Write("Ürün adı: ");
                string adi = Console.ReadLine();

                Console.Write("Birim fiyatı: ");
                decimal birimFiyat = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Adet: ");
                int adet = Convert.ToInt32(Console.ReadLine());

                depo.UrunEkle(adi, birimFiyat, adet);
            }
            else if (secim == "2")
            {
                Console.Write("Satmak istediğiniz ürün adı: ");
                string adi = Console.ReadLine();

                Console.Write("Satmak istediğiniz adet: ");
                int adet = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Mevcut bakiyeniz: {bakiye} TL");

                if (depo.UrunSat(adi, adet, bakiye))
                {
                    decimal toplamTutar = depo.Urunler.Find(u => u.Adi == adi).BirimFiyat * adet;
                    bakiye -= toplamTutar;  // Satış yapıldıktan sonra bakiyeyi düşür
                }
            }
            else if (secim == "3")
            {
                depo.UrunleriListele();
            }
            else if (secim == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("Geçersiz seçim, tekrar deneyin.");
            }
        }
    }
}
