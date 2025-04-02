using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Proje5
{
    // Node sınıfı: Bağlantılı liste elemanlarını temsil eder
    class Node
    {
        // Anahtar (key) değeri, her node'un benzersiz bir tanımlayıcısıdır
        public int key;
        
        // Node'un ismini tutan string değişkeni
        public string isim;
        
        // Sonraki (next) node'u işaret eden işaretçi
        public Node next;

        // Varsayılan yapıcı metot: next işaretçisi null olarak başlatılır
        public Node()
        {
            this.next = null;  // Bu node'un bağlantısı yok (null)
        }

        // Parametreli yapıcı metot: Node'un key ve isim değerlerini atar
        public Node(int key, string isim)
        {
            this.key = key;     // Node'a verilen key değeri
            this.isim = isim;   // Node'a verilen isim
            this.next = null;   // Başlangıçta node'un bağlantısı yok (null)
        }
    }
}
