using System;

namespace Eren_Tarhan
{
    internal class Rezervasyon
    {
        public int ucret;

        Random random = new Random();

        public Rezervasyon() 
        {
            ucret = Convert.ToInt32(random.Next(750, 15000));
        }
    }
}
