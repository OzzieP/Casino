using Casino.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Casino.Controller
{
    public class ControllerNbAlea
    {
        string[] Partie()
        {
            string[] tirage = new string[3];
            int i;
            for (i = 0; i< 3; i++)
            {
                tirage[i] = NbAlea.NbAlea();
            }

            return tirage;
        } 
    }
}
