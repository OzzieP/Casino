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
            NbAlea alea = new NbAlea();
            string[] tirage = new string[3];
            int i;

            for (i = 0; i < 3; i++)
            {
                tirage[i] = alea.nombre.ToString();
            }

            if (tirage[0] == tirage[1] && tirage[0] == tirage[2])
            {
                tirage[4] = "true";
            }
            else
            {
                tirage[4] = "false";
            }

            return tirage;
        }
    }
}
