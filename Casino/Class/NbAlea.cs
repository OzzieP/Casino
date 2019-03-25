using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.Class
{
    public class NbAlea
    {
        public int nombre;

        public NbAlea()
        {
            Random rand = new Random();
            this.nombre = rand.Next(1, 9);
        }
    }
}
