using System;

namespace Eren_Tarhan
{
    internal class UcakOlusturma : Ucak
    {
       public string Model { get; set; }

       public int YolcuKapasitesi { get; set; }

        public int BagajKapasitesi { get; set; }

        public int Hiz { get; set; }

        private Random Random = new Random();

        public UcakOlusturma() 
        {
            int random = Random.Next(0, 6);

            switch (random) 
            {
                case 0:
                    Model = "ATR 42";
                    YolcuKapasitesi = 50;
                    BagajKapasitesi = 250;
                    Hiz = 560;
                    break;

                case 1:
                    Model = "Comac C919";
                    YolcuKapasitesi = 350;
                    BagajKapasitesi = 2000;
                    Hiz = 830;
                    break;

                case 2:
                    Model = "Boeing 787";
                    YolcuKapasitesi = 300;
                    BagajKapasitesi = 1500;
                    Hiz = 900;
                    break;

                case 3:
                    Model = "Douglas DC-3";
                    YolcuKapasitesi = 35;
                    BagajKapasitesi = 140;
                    Hiz = 270;
                    break;

                case 4:
                    Model = "Hawker Siddeley HS 748";
                    YolcuKapasitesi = 60;
                    BagajKapasitesi = 300;
                    Hiz = 400;
                    break;

                case 5:
                    Model = "NAMC YS-11";
                    YolcuKapasitesi = 100;
                    BagajKapasitesi = 450;
                    Hiz = 500;
                    break;

                default:
                    break;
            }
        }
    }
}
