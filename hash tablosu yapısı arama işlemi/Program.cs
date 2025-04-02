using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using System.Xml;

namespace Proje5
{
    // Ana program sınıfı
    class TProgram
    {
        // Main metodu, uygulamanın başlangıç noktasıdır
        static void Main(string[] args)
        {
            int size;

            // Kullanıcıdan hash tablosunun boyutunu alır
            Console.WriteLine("Hash tablo boyu : "); 
            size = int.Parse(Console.ReadLine()); // Boyut girilir ve integer olarak parse edilir

            // Hash tabloyu oluşturur
            Tablo htablo = new Tablo(size);

            int numara;
            string isim;
            int secim = menu(); // Menüden seçim yapılır

            // Kullanıcı çıkış yapana kadar seçim alır
            while (secim != 0)
            {
                switch (secim)
                {
                    // 1 numara seçildiğinde, kullanıcıdan numara ve isim alınıp tabloya eklenir
                    case 1:
                        Console.WriteLine("numara : "); 
                        numara = int.Parse(Console.ReadLine()); // Kullanıcıdan numara alınır
                        Console.WriteLine("isim : "); 
                        isim = Console.ReadLine(); // Kullanıcıdan isim alınır
                        htablo.ekle(numara, isim); // Tabloya ekleme yapılır
                        break;

                    // 2 numara seçildiğinde, silinecek kişinin numarası alınır ve tablo üzerinden silme yapılır
                    case 2:
                        Console.WriteLine("silinecek kişinin numarası : "); 
                        numara = int.Parse(Console.ReadLine()); // Silinecek kişinin numarası alınır
                        htablo.sil(numara); // Tablo üzerinden silme işlemi yapılır
                        break;

                    // 3 numara seçildiğinde, hash tabloyu yazdırır
                    case 3: 
                        htablo.yazdır(); // Tabloyu yazdırma işlemi yapılır
                        break;

                    // 4 numara seçildiğinde, hash tablosundaki kişi sayısını yazdırır
                    case 4: 
                        htablo.adetBul(); // Tablodaki kişi sayısı yazdırılır
                        break;

                    // 5 numara seçildiğinde, aranan kişinin numarası alınır ve tablo üzerinden arama yapılır
                    case 5: 
                        Console.WriteLine("aranan kişinin numarası : "); 
                        numara = int.Parse(Console.ReadLine()); // Aranacak kişinin numarası alınır
                        htablo.kişibul(numara); // Tablo üzerinde kişi arama yapılır
                        break;

                    // 0 numara seçildiğinde, program sonlanır
                    case 0: 
                        break;

                    // Hatalı seçim yapılırsa uyarı verir
                    default:
                        Console.WriteLine("Hatalı seçim !");
                        break;
                }

                // Menü tekrar görüntülenir
                secim = menu(); // Kullanıcıdan yeni bir seçim alınır
            }

            // Programın sonlandırıldığını belirten mesaj
            Console.WriteLine("Çıkış yapılıyor...");
        }

        // Kullanıcıya seçim yapması için menü gösteren metod
        private static int menu()
        {
            int secim;

            // Menü seçenekleri
            Console.WriteLine("1-Ekle");
            Console.WriteLine("2-Sil");
            Console.WriteLine("3-Yazdır");
            Console.WriteLine("4-Kişi sayısı");
            Console.WriteLine("5-Kişi bul");
            Console.WriteLine("0-Çıkış");

            // Kullanıcının seçim yapmasını sağlar
            Console.WriteLine("Seçiminiz : ");
            secim = int.Parse(Console.ReadLine()); // Seçim integer olarak parse edilir

            return secim; // Seçilen değer döndürülür
        }
    }
}
