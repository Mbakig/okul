﻿using System;
using System.ComponentModel.Design;
using System.Security.Cryptography;
using System.Security.Principal;

namespace Proje4
{
    // Ana program sınıfı, kullanıcı ile etkileşim sağlar
    class Program
    {
        // Main metodu, programın giriş noktasıdır
        static void Main(string[] args)
        {
            // Liste nesnesi oluşturuluyor
            Liste ogrenciler = new Liste();

            // Öğrenci bilgilerini tutacak değişkenler
            int numara;
            string ad, soyad, dersAdi;
            float vize, final, ortalama;

            // Menüyü göster ve kullanıcıdan seçim al
            int secim = menu();

            // Menüde seçim yapılmadığı sürece program döngüde çalışır
            while (secim != 0)
            {
                switch (secim)
                {
                    // Öğrenci ekleme
                    case 1:
                        Console.Write("Numara: "); numara = int.Parse(Console.ReadLine());
                        Console.Write("İsim: "); ad = Console.ReadLine();
                        Console.Write("Soyisim: "); soyad = Console.ReadLine();
                        Console.Write("Ders Adı: "); dersAdi = Console.ReadLine();
                        Console.Write("Vize: "); vize = float.Parse(Console.ReadLine());
                        Console.Write("Final: "); final = float.Parse(Console.ReadLine());
                        // Öğrenciyi ekle
                        ogrenciler.ekle(numara, ad, soyad, dersAdi, vize, final);
                        break;

                    // Öğrenci silme
                    case 2:
                        Console.Write("Numara: "); numara = int.Parse(Console.ReadLine());
                        // Öğrenciyi sil
                        ogrenciler.sil(numara);
                        break;

                    // Öğrencileri yazdırma
                    case 3:
                        ogrenciler.yazdır();
                        break;

                    // En başarılı öğrenciyi gösterme
                    case 4:
                        ogrenciler.enBaşarılıÖğrenci();
                        break;

                    // Programı kapatma
                    case 0:
                        break;

                    // Hatalı seçim
                    default:
                        Console.WriteLine("Hatalı seçim yaptınız!");
                        break;
                }
                // Menü tekrar gösterilir
                secim = menu();
            }
            // Program kapanış mesajı
            Console.WriteLine("Program kapatılıyor...");
        }

        // Menü seçimi için metot
        private static int menu()
        {
            int secim;
            Console.WriteLine("\n1-Öğrenci ekle");
            Console.WriteLine("2-Öğrenci sil");
            Console.WriteLine("3-Öğrencileri yazdır");
            Console.WriteLine("4-En başarılı öğrenciyi göster");
            Console.WriteLine("0-Programı kapat");
            Console.WriteLine("Seçiminiz: ");
            secim = int.Parse(Console.ReadLine());
            return secim;
        }
    }

    // Öğrenci sınıfı (Node) - Bağlantılı liste elemanıdır
    class Ögrenci
    {
        public int numara; // Öğrencinin numarası
        public string ad, soyad, dersAdi; // Öğrencinin adı, soyadı ve ders adı
        public float vize, final, ortalama; // Vize, final ve ortalama notlar
        public string durum; // Öğrencinin durumu ("Geçti" veya "Kaldı")

        public Ögrenci next; // Sonraki öğrenci (bağlantılı liste özelliği)

        // Yapıcı metod, öğrenciyi başlatır
        public Ögrenci(int n, string a, string s, string d, float v, float f)
        {
            this.numara = n;
            this.ad = a;
            this.soyad = s;
            this.dersAdi = d;
            this.vize = v;
            this.final = f;

            // Ortalamayı hesapla (Vize %40, Final %60)
            this.ortalama = this.vize * 40 / 100 + this.final * 60 / 100;

            // Durumu belirle (Ortalama 50'den küçükse "Kaldı", yoksa "Geçti")
            this.durum = this.ortalama < 50 ? "Kaldı" : "Geçti";
            this.next = null; // Bağlantılı listenin başlangıcında bu elemanın sonrasında kimse yok
        }
    }

    // Liste sınıfı - Bağlantılı liste yapısını yönetir
    class Liste
    {
        Ögrenci head; // Bağlantılı listenin başı

        public Liste()
        {
            head = null; // Başlangıçta liste boş
        }

        // Yeni bir öğrenci ekler
        public void ekle(int n, string a, string s, string d, float v, float f)
        {
            Ögrenci ogr = new Ögrenci(n, a, s, d, v, f); // Yeni öğrenci nesnesi oluşturuluyor
            if (head == null) // Eğer liste boşsa
            {
                head = ogr; // Yeni öğrenci başa eklenir
                Console.WriteLine(n + " numaralı öğrenci listeye eklendi.");
            }
            else
            {
                ogr.next = head; // Yeni öğrenci listenin başına eklenir
                head = ogr; // Head artık yeni öğrenciye işaret eder
                Console.WriteLine(n + " numaralı öğrenci eklendi.");
            }
        }

        // Öğrenci silme
        public void sil(int numara)
        {
            bool sonuc = false; // Silme işlemi başarılı mı diye kontrol

            if (head == null) // Liste boşsa
            {
                sonuc = true;
                Console.WriteLine("Listede kayıtlı öğrenci yok!");
            }
            else if (head.next == null && head.numara == numara) // Liste tek elemanlıysa ve o öğrenci silinecekse
            {
                sonuc = true;
                head = head.next; // Liste boşaltılır
                Console.WriteLine(numara + " numaralı öğrenci silindi, listede hiç öğrenci kalmadı.");
            }
            else if (head.next != null && head.numara == numara) // Eğer silinecek öğrenci başta ise
            {
                sonuc = true;
                head = head.next; // İlk eleman silinir
                Console.WriteLine(numara + " numaralı öğrenci silindi.");
            }
            else
            {
                // Listede diğer elemanları kontrol et
                Ögrenci temp = head;
                Ögrenci temp2 = temp;

                while (temp.next != null)
                {
                    if (numara == temp.numara) // Silinecek öğrenci bulunursa
                    {
                        sonuc = true;
                        temp2.next = temp.next; // Öğrenciyi listeden çıkar
                        Console.WriteLine(numara + " numaralı öğrenci silindi.");
                    }
                    temp2 = temp;
                    temp = temp.next;
                }

                // Son öğrenci silinirse
                if (numara == temp.numara)
                {
                    sonuc = true;
                    temp2.next = null; // Son eleman silinir
                    Console.WriteLine(numara + " numaralı öğrenci silindi.");
                }
            }

            // Silme işlemi başarısızsa
            if (sonuc == false)
            {
                Console.WriteLine(numara + " numaralı öğrenciye ait kayıt bulunamadı.");
            }
        }

        // Öğrencileri yazdırma
        public void yazdır()
        {
            if (head == null) // Liste boşsa
            {
                Console.WriteLine("Listede kayıtlı öğrenci yok.");
            }
            else
            {
                // Listeyi baştan sona yazdır
                Ögrenci temp = head;
                Console.WriteLine("Numara\tAd\tSoyad\tDersAdı\tOrtalama\tDurum ");
                while (temp.next != null)
                {
                    Console.WriteLine(temp.numara + "\t" + temp.ad + "\t" + temp.soyad + "\t" + temp.dersAdi + "\t" + temp.ortalama + "\t" + temp.durum);
                    temp = temp.next;
                }
                // Son elemanı yazdır
                Console.WriteLine(temp.numara + "\t" + temp.ad + "\t" + temp.soyad + "\t" + temp.dersAdi + "\t" + temp.ortalama + "\t" + temp.durum);
            }
        }

        // En başarılı öğrenciyi bulma
        public void enBaşarılıÖğrenci()
        {
            if (head == null) // Liste boşsa
            {
                Console.WriteLine("Listede kayıtlı öğrenci yok.");
            }
            else
            {
                // En başarılı öğrenciyi bulmak için başla
                Ögrenci temp = head;
                Ögrenci yuksekOgr = head;
                float enYuksekOrtalama = head.ortalama;

                // Listeyi gezerek en yüksek ortalamayı bul
                while (temp.next != null)
                {
                    if (enYuksekOrtalama < temp.ortalama)
                    {
                        enYuksekOrtalama = temp.ortalama;
                        yuksekOgr = temp;
                    }
                    temp = temp.next;
                }

                // Son öğrenciyi kontrol et
                if (enYuksekOrtalama < temp.ortalama)
                {
                    enYuksekOrtalama = temp.ortalama;
                    yuksekOgr = temp;
                }

                // En başarılı öğrenciyi yazdır
                Console.WriteLine("En yüksek ortalamalı öğrenci bilgileri:");
                Console.WriteLine("Numara\tAd\tSoyad\tDersAdı\tOrtalama\tDurum ");
                Console.WriteLine(yuksekOgr.numara + "\t" + yuksekOgr.ad + "\t" + yuksekOgr.soyad + "\t" + yuksekOgr.dersAdi + "\t" + yuksekOgr.ortalama + "\t" + yuksekOgr.durum);
            }
        }
    }
}
