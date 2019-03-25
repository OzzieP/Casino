using System;
using Casino;
using Casino.Controller;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        Joueur joueur = new Joueur(100);

        [TestMethod]
        public void PartieMode1_JoueurAjouterCredit()
        {
            joueur.AjouterCredit(null);
            Assert.AreEqual(110, joueur.credit);
        }

        [TestMethod]
        public void PartieMode2_JoueurAjouterCredit()
        {
            joueur.AjouterCredit(5);
            Assert.AreEqual(150, joueur.credit);
        }

        [TestMethod]
        public void PartieMode1_JoueurRetirerCredit()
        {
            joueur.RetirerCredit(null);
            Assert.AreEqual(99, joueur.credit);
        }

        [TestMethod]
        public void PartieMode2_JoueurRetirerCredit()
        {
            joueur.RetirerCredit(5);
            Assert.AreEqual(95, joueur.credit);
        }
    }
}
