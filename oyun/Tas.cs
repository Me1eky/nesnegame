using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static oyun.satranctahtasi;

namespace oyun
{
    internal class Tas
    {

        public TasTipi Tip { get; set; }
        public TasRengi Renk { get; set; }
        //public Picturebox IliskiliPictureBox { get; set; }
        public string Konum { get; set; }

        //public Tas(TasTipi tip, TasRengi renk, PictureBox pb, string konum)
        //{
        //    Tip = tip;
        //    Renk = renk;
        //    IliskiliPictureBox = pb;
        //    Konum = konum;
        //}
        public bool GecerliHamleMi(string hedefKonum, List<Tas> tumTaslar)
        {
            // Taş tipine göre hareket kuralları
            // Basit örnek: Piyon hareketi
            if (Tip == TasTipi.Piyon && Renk == TasRengi.Beyaz)
            {
                return hedefKonum[0] == Konum[0] &&
                       hedefKonum[1] == Konum[1] + 1; // Beyaz piyon bir ileri
            }
            // Diğer taşlar için kurallar eklenmeli
            return false;
        }
    }
}
