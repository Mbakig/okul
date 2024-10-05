using System;

class Program
{
    static void Main()
    {
        // Kullanıcıdan iki sayı al
        Console.Write("Birinci sayıyı girin: ");
        double sayi1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("İkinci sayıyı girin: ");
        double sayi2 = Convert.ToDouble(Console.ReadLine());

        // Geometrik ortalamayı hesapla
        double geometrikOrtalama = Math.Sqrt(sayi1 * sayi2);

        // Sonucu ekrana yazdır
        Console.WriteLine($"Geometrik Ortalama: {geometrikOrtalama}");
    }
}
