using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfas
{
    public class Carro
    {
        public int posx;
        public int posy;
        public int tipocarro;

        public int choque(bool transporta)
        {
            int retornar = -1;
            if (transporta)
            {
                retornar++;
                retornar -= 5;
            }
            return retornar;
        }

    }
}
