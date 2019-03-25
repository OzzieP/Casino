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
        public string[] tirage = new string[3];

        // Méthode pour le premier mode de jeu
        public bool Partie()
        {
            NbAlea alea = new NbAlea();
            int i;
            string nbGagnant = "7";
            bool result;

            for (i = 0; i < alea.nombre.Length; i++)
            {
                this.tirage[i] = alea.nombre[i].ToString();
            }

            if (tirage[0] == nbGagnant && tirage[1] == nbGagnant && tirage[2] ==  nbGagnant)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }

        // Méthode pour le deuxième mode de jeu
        public bool PartieMode2(int nbGeneration)
        {
            string nbGagnant = "7";
            bool result;

            do
            {
                NbAlea alea = new NbAlea();

                for (int j = 0; j < alea.nombre.Length; j++)
                {
                    this.tirage[j] = alea.nombre[j].ToString();
                }

                if (tirage[0] == nbGagnant && tirage[1] == nbGagnant && tirage[2] == nbGagnant)
                {
                    result = true;
                    return result;
                }
                else
                {
                    result = false;
                    nbGeneration--;
                }

            } while (nbGeneration > 0);

            return result;
        }
    }
}
