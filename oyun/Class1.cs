using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oyun
{
    internal class CozumKontrol
    {
        private Button[,] butonlar;
        private int[,] dogruCozum;

        
        public CozumKontrol(Button[,] butonlar, int[,] dogruCozum)
        {
            this.butonlar = butonlar;
            this.dogruCozum = dogruCozum;
        }

        public void KontrolEt()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Button btn = butonlar[i, j];
                    if (btn != null)
                    {
                        if (int.TryParse(btn.Text, out int girilenDeger))
                        {
                            if (girilenDeger == dogruCozum[i, j])
                            {
                                btn.BackColor = Color.LightGreen;
                            }
                            else
                            {
                                btn.BackColor = Color.LightCoral;
                            }
                        }
                        else
                        {
                            btn.BackColor = Color.White;
                        }
                    }
                }
            }
        }
    }
}
