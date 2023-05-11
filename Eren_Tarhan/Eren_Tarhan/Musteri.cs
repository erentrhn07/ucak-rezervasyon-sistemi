﻿using System;

namespace Eren_Tarhan
{
    internal class Musteri
    {
        public string Ad { get; set; }

        public string Soyad { get; set; }

        public string Yaş { get; set; }

        public string KimlikNo { get; set; }

        public string TelNo { get; set; }

        public int Cinsiyet { get; set; }

        public int Engel { get; set; }

        public Musteri(string ad, string soyad, string yas, string kimlikNo, string telNo, int cinsiyet, int engel) 
        {
            Ad = ad;
            Soyad = soyad;
            Yaş = yas;
            KimlikNo = kimlikNo;
            TelNo = telNo;
            Cinsiyet = cinsiyet;
            Engel = engel;
        }
}
}
