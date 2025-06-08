using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oyun
{
    internal class Class2
    {

        
        Label[,] letterGrid = new Label[20, 20];

        
        List<Label> selectedLetters = new List<Label>();

        
        List<string> wordList = new List<string> { "KÖPRÜ", "KARTAL", "ÇİÇEK", "YAĞMUR", "ÖĞRENCİ",
                                                    "ŞEMSİYE", "BAHÇE", "KÜTÜPHANE", "GÖZLÜK", "YOLCULUK",
                                                    "SERÜVEN", "TUNÇ", "KASABA", "DENİZ", "PAZARLIK",
                                                     "FENER", "SAKLAMA", "PATİKA", "YERLEŞİM", "KUMSAL",
                                                   "MÜZİSYEN", "YILDIZ", "JAGUAR", "KÜÇÜKÇEKMECE", "GÖKDELEN"};

       
        HashSet<string> foundWords = new HashSet<string>();

        
    }
}
