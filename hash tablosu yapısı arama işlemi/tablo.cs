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
            Tablo htablo = new Tablo(size); // Tablo sınıfı oluşturuluyor ve boyut atanıyor
        }
    }
}