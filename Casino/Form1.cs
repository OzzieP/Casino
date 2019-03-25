using Casino.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casino
{
    public partial class Form1 : Form
    {
        private Joueur joueur;

        public Form1()
        {
            InitializeComponent();
            this.joueur = new Joueur(100);
            label8.Text = joueur.credit.ToString();
            // 1 pour jouer
            // 10 quand tu gagnes
        }

        // affichage valeur 1 dans label1

        // affichage valeur 2 dans le label2

        // affichage valeur 3 dans le label3


        // lance la machine a $$$ && utlisation du controller && retirer argent au joueur
        // Bouton JOUER
        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrWhiteSpace(textBox1.Text))
            {
                joueur.RetirerCredit(null);
                label8.Text = joueur.credit.ToString();

                ControllerNbAlea nbAlea = new ControllerNbAlea();
                bool aGagne = nbAlea.Partie();

                label1.Text = nbAlea.tirage[0];
                label2.Text = nbAlea.tirage[1];
                label3.Text = nbAlea.tirage[2];

                if (aGagne == true)
                {
                    joueur.AjouterCredit(null);
                    label9.Text = "Gagné !";
                }
                else
                {
                    label9.Text = "Perdu !";
                }
            }
            else
            {
                joueur.RetirerCredit(int.Parse(textBox1.Text));
                label8.Text = joueur.credit.ToString();

                ControllerNbAlea nbAlea = new ControllerNbAlea();
                bool aGagne = nbAlea.PartieMode2(int.Parse(textBox1.Text));

                label1.Text = nbAlea.tirage[0];
                label2.Text = nbAlea.tirage[1];
                label3.Text = nbAlea.tirage[2];

                if (aGagne == true)
                {
                    joueur.AjouterCredit(int.Parse(textBox1.Text));
                    label9.Text = "Gagné !";
                }
                else
                {
                    label9.Text = "Perdu !";
                }
            }
        }

        // ajouter de l'argent au joueur
        private void button2_Click(object sender, EventArgs e)
        {
            joueur.AjouterCredit(null);
            label8.Text = joueur.credit.ToString();
        }

        // afficher dans le label9 gagné ou perdu !
        // affichage du solde joueur dans le label8
    }
}
