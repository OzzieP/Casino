using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.Class
{
    public class NbAlea
    {
        public int[] nombre = new int[3];

        public NbAlea()
        {
            Random rand = new Random();

            for (int i = 0; i < nombre.Length; i++)
            {
                this.nombre[i] = rand.Next(1, 9);
            }
        }
    }
}
