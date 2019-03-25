using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
     public class Joueur
    {
        #region Propriétés 
        private int Credit;
        public int credit
        {
            get { return Credit; }
            set { Credit = value; }
        }
        #endregion

        #region Constructeur
        public Joueur(int credit)
        {
            this.credit = credit;
        }
        #endregion

        #region Méthodes
        public void AjouterCredit(int? tour)
        {
            if (tour.HasValue)
            {
                this.credit += 10 * tour.Value;
            }
            else
            {
                this.credit += 10;
            }
        }

        public void RetirerCredit(int? tour)
        {
            if (tour.HasValue)
            {
                this.credit -= tour.Value;
            }
            else
            {
                this.credit -= 1;
            }
        }
        #endregion

    }
}
