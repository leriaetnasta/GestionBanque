using System;
namespace compte_bancaire
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Compte cmpt = new Compte(0,"talha", "loubna", "Casablanca");
            Compte cmpt2 = new Compte(10000,"talha2", "loubna2", "Casablanca");
            cmpt.afficher();
            cmpt2.afficher();
            Mad amount = new Mad(500);
            cmpt2.Virement(cmpt, amount);
            cmpt.afficher();
            cmpt2.afficher();
        }
    }
}
