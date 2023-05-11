using System;

namespace Eren_Tarhan
{
    internal interface Ucak
    {
       public string Model { get; set; }

       public int YolcuKapasitesi { get; set; }

       public  int BagajKapasitesi { get; set; }

       public int Hiz { get; set; }
    }
}
