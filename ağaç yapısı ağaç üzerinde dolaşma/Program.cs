using System;
using System.ComponentModel.Design;
using System.Data.SqlTypes;

namespace Proje2
{
    // Ana program sınıfı
    class Program
    {
        // Main metodu, uygulamanın başlangıç noktasıdır
        static void Main(string[] args)
        {
            // StackYapısı sınıfından bir nesne oluşturuluyor
            StackYapısı stc = new StackYapısı();
            int sayi;
            
            // Menüden bir seçim alınır
            int secim = menu();
            
            // Kullanıcı çıkış yapana kadar seçim alınır ve işlem yapılır
            while (secim != 0)
            {
                switch (secim)
                {
                    // 1 numara seçildiğinde, kullanıcıdan bir sayı alınır ve push metodu ile stack'e eklenir
                    case 1:
                        Console.WriteLine("Sayı : ");
                        sayi = int.Parse(Console.ReadLine()); // Kullanıcıdan sayı alınır
                        stc.push(sayi); // Stack'e sayı eklenir
                        break;

                    // 2 numara seçildiğinde, pop metodu çağrılır ve stack'ten bir sayı çıkarılır
                    case 2:
                        sayi = stc.pop(); // Stack'ten sayı çıkarılır
                        if (sayi != -1)
                        {
                            Console.WriteLine("Çıkan sayı : " + sayi);
                        }
                        else
                        {
                            Console.WriteLine("Stack boştur"); // Eğer stack boşsa, mesaj yazdırılır
                        }
                        break;

                    // 3 numara seçildiğinde, stack'teki elemanlar yazdırılır
                    case 3:
                        stc.print(); // Stack'teki tüm elemanlar yazdırılır
                        break;

                    // 4 numara seçildiğinde, stack'teki en üst eleman yazdırılır
                    case 4:
                        stc.topPrint(); // En üst eleman yazdırılır
                        break;

                    // 0 numara seçildiğinde, program sonlanır
                    case 0:
                        break;

                    // Hatalı seçim yapılırsa uyarı verir
                    default:
                        Console.WriteLine("Hatalı seçim.");
                        break;
                }

                // Menü tekrar gösterilir
                secim = menu(); // Yeni bir seçim için menü gösterilir
            }
            
            // Programın sonlandığını belirten mesaj
            Console.WriteLine("Program kapatılıyor...");
        }

        // Kullanıcıya seçim yapması için menü gösteren metod
        private static int menu()
        {
            int secim;
            
            // Menü seçenekleri
            Console.WriteLine("1-Push");
            Console.WriteLine("2-Pop");
            Console.WriteLine("3-Print");
            Console.WriteLine("4-Top");
            Console.WriteLine("0-Exit");

            // Kullanıcıdan seçim alınır
            secim = int.Parse(Console.ReadLine()); // Seçim integer olarak parse edilir
            return secim; // Seçilen değer döndürülür
        }
    }

    // Node sınıfı, stack yapısındaki her elemanı temsil eder
    class Node
    {
        public int data; // Node'un veri alanı
        public Node next; // Bir sonraki node'a işaret eden pointer

        // Constructor: Node oluşturulurken veri ile birlikte oluşturulmasını sağlar
        public Node(int data)
        {
            this.data = data; // Veri atanır
            next = null; // Başlangıçta sonraki node null'dır
        }
    }

    // StackYapısı sınıfı, stack veri yapısını temsil eder
    class StackYapısı
    {
        Node top; // Stack'in en üst elemanını temsil eder

        // Constructor: Stack başta boş olarak başlatılır
        public StackYapısı()
        {
            top = null; // Başlangıçta stack boştur
        }

        // push metodu: Yeni eleman stack'e ekler
        public void push(int data)
        {
            // Yeni bir Node oluşturulur
            Node eleman = new Node(data);
            
            // Eğer stack boşsa
            if (top == null)
            {
                top = eleman; // Top, yeni eleman olur
                Console.WriteLine("Stack yapısı oluşturuldu, ilk eleman stack'e yerleştirildi.");
            }
            else
            {
                // Yeni eleman, stack'in en üstüne eklenir
                eleman.next = top;
                top = eleman;
                Console.WriteLine("Eleman eklendi.");
            }
        }

        // pop metodu: Stack'ten en üst elemanı çıkarır
        public int pop()
        {
            // Eğer stack boşsa
            if (top == null)
            {
                Console.WriteLine("Stack boş.");
                return -1; // Boş stack'ten pop yapılamaz, -1 döndürülür
            }
            else
            {
                // En üst eleman çıkarılır
                int sayi = top.data; // En üst elemanın verisi alınır
                top = top.next; // Top, bir sonraki node'a işaret eder
                Console.WriteLine(sayi + " Stack'ten çıkarıldı.");
                return sayi; // Çıkarılan eleman döndürülür
            }
        }

        // print metodu: Stack'teki tüm elemanları yazdırır
        public void print()
        {
            // Eğer stack boşsa
            if (top == null)
            {
            }
        }
    }
}
