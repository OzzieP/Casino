using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
     public class Joueur
    {
        #region propriétés 
        private string Nom;

        public string nom
        {
            get { return Nom; }
            set { Nom = value; }
        }

        private int Credit;

        public int credit
        {
            get { return Credit; }
            set { Credit = value; }
        }
        #endregion


        #region Constructeur
        public Joueur(string nom, int credit)
        {
            this.nom = nom;
            this.credit = credit;

        }
        #endregion

        #region Methodes
        public void AjouterCredit(int nombre)
        {
            credit += nombre;
        }

        public void RetirerCredit(int nombre)
        {
            credit -= nombre;

        }
        #endregion

    }
}
