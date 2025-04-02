﻿using System;
using System.ComponentModel.Design;

namespace Proje1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Liste nesnesi oluşturuluyor
            Liste cydaListe = new Liste(); 

            int sayi, indis;
            int secim = menu(); // Menü fonksiyonu ile kullanıcıdan seçim alınır
            while (secim != 0)  // Kullanıcı "0" girene kadar döngü devam eder
            {
                switch (secim)
                {
                    case 1:
                        Console.Write("Sayı : "); sayi = int.Parse(Console.ReadLine());
                        cydaListe.basaEkle(sayi); // Başa eleman ekleme işlemi
                        cydaListe.yazdır(); // Listeyi yazdır
                        break;

                    case 2:
                        Console.Write("Sayı : "); sayi = int.Parse(Console.ReadLine());
                        cydaListe.sonaEkle(sayi); // Sona eleman ekleme işlemi
                        cydaListe.yazdır(); // Listeyi yazdır
                        break;

                    case 3:
                        Console.Write("indis : "); indis = int.Parse(Console.ReadLine()); 
                        cydaListe.aradanSil(indis); // Belirtilen indeksten eleman silme
                        cydaListe.yazdır(); // Listeyi yazdır
                        break;

                    case 0:
                        break;

                    default:
                        Console.WriteLine("Hatalı seçim yaptınız");
                        break;
                }
                secim = menu(); // Menü tekrar gösterilir
            }
            Console.WriteLine("Program kapatılıyor...");
        }

        // Kullanıcıdan seçim almak için kullanılan menü fonksiyonu
        private static int menu()
        {
            int secim;
            Console.WriteLine("\n\n1-Başa ekle");
            Console.WriteLine("2-Sona ekle");
            Console.WriteLine("3-Aradan sil");
            Console.WriteLine("0-Programı kapat");
            Console.Write("Seçiminiz : ");
            secim = int.Parse(Console.ReadLine());
            return secim;
        }
    }

    // Node sınıfı, her bir elemanı temsil eder
    class Node
    {
        public int data;   // Elemanın veri kısmı
        public Node next;  // Sonraki elemana işaretçi
        public Node prev;  // Önceki elemana işaretçi

        // Node sınıfının yapıcı metodu, eleman oluşturur
        public Node(int data)
        {
            this.data = data;
            this.next = null; // Sonraki eleman başlangıçta null
            this.prev = null; // Önceki eleman başlangıçta null
        }
    }
    
    // Liste sınıfı, çift yönlü döngüsel bağlantılı listeyi yönetir
    class Liste
    {
        Node head; // Listenin başını işaret eder
        Node tail; // Listenin sonunu işaret eder

        // Liste yapıcı metodu, başta listeyi boş yapar
        public Liste()
        {
            this.head = null;
            this.tail = null;
        }

        // Başa eleman ekleme fonksiyonu
        public void basaEkle(int data)
        {
            Node eleman = new Node(data); // Yeni bir eleman oluşturulur
            if (head == null)  // Eğer liste boşsa
            {
                head = tail = eleman; // Hem baş hem de son bu eleman olur
                tail.next = head; // Döngüsel yapı için sonun next'i başa bağlanır
                tail.prev = head; // Başın prev'i sona bağlanır
                head.next = tail; // Başın next'i sona bağlanır
                head.prev = tail; // Sonun prev'i başa bağlanır
                Console.WriteLine("Liste yapısı oluşturuldu, ilk eleman eklendi.");
            }
            else
            {
                // Yeni eleman başa eklenir
                eleman.next = head;
                head.prev = eleman;
                head = eleman; // Head artık yeni eklenen elemanı işaret eder
                head.prev = tail; // Başın prev'i son elemanı işaret eder
                tail.next = head; // Sona next olarak başa işaret edilir
                Console.WriteLine("Başa eleman eklendi");
            }
        }
        
        // Sona eleman ekleme fonksiyonu
        public void sonaEkle(int data)
        {
            Node eleman = new Node(data); // Yeni bir eleman oluşturulur
            if (head == null) // Eğer liste boşsa
            {
                head = tail = eleman; // Hem baş hem de son bu eleman olur
                tail.next = head; // Döngüsel yapı için sonun next'i başa bağlanır
                tail.prev = head; // Başın prev'i sona bağlanır
                head.next = tail; // Başın next'i sona bağlanır
                head.prev = tail; // Sonun prev'i başa bağlanır
                Console.WriteLine("Liste yapısı oluşturuldu, ilk eleman eklendi.");
            }
            else
            {
                tail.next = eleman; // Son elemanın next'i yeni elemana işaret eder
                eleman.prev = tail; // Yeni elemanın prev'i son elemana işaret eder
                tail = eleman; // Tail artık yeni elemanı işaret eder
                tail.next = head; // Son elemanın next'i başa bağlanır
                head.prev = tail; // Başın prev'i son elemanı işaret eder
                Console.WriteLine("Sona eleman eklendi");
            }
        }

        // Listeyi yazdırma fonksiyonu
        public void yazdır()
        {
            if (head == null)  // Liste boşsa
                Console.WriteLine("Liste boş");
            else
            {
                Node temp = head; // Temp, listeyi gezmek için kullanılır
                Console.Write("Baş -> ");
                while (temp != tail)  // Tail'e ulaşana kadar listeyi yazdır
                {
                    Console.Write(temp.data + " -> ");
                    temp = temp.next; // Sonraki elemana geç
                }
                Console.Write(temp.data + " son."); // Son elemanı yazdır
            }
        }

        // Belirtilen indisten eleman silme fonksiyonu
        public void aradanSil(int indis)
        {
            if (head == null) // Liste boşsa
            {
                Console.WriteLine("Liste boş");
            }
            else
            {
                Node temp = head; // Temp baştan başlar
                Node temp2 = null; // Önceki eleman
                int i = 0;

                // Belirtilen indise kadar listeyi gez
                while (temp != tail && i < indis)
                {
                    temp2 = temp;
                    temp = temp.next;
                    i++;
                }

                if (i == indis) // İndis bulunmuşsa
                {
                    if (temp == head)  // Eğer silinecek eleman baş ise
                    {
                        head = head.next;
                        head.prev = tail; // Başın prev'i son elemanı işaret eder
                        tail.next = head; // Son elemanın next'i başa işaret eder
                    }
                    else if (temp == tail) // Eğer silinecek eleman son ise
                    {
                        tail = tail.prev;
                        tail.next = head; // Son elemanın next'i başa işaret eder
                        head.prev = tail; // Başın prev'i son elemanı işaret eder
                    }
                    else // Silinecek eleman ortada ise
                    {
                        temp2.next = temp.next;
                        temp.next.prev = temp2; // Eleman silinir
                    }
                    Console.WriteLine("Aradan eleman silindi.");
                }
                else
                {
                    Console.WriteLine("Geçersiz indis");
                }
            }
        }
    }
}
