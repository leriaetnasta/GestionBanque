using System;
namespace compte_bancaire
{
    public class Compte
    {
        
        private int numcompte;
        private static int cpt = 1;
        private Client titulaire;
        private Mad solde;
        private static Mad plafond = new Mad(3500);

        public Compte(double s, string n, string p, string a)
        {
            numcompte = cpt++;
            titulaire = new Client(n, p, a);
            solde = new Mad(s);
        }
        public void afficher()
        {
            Console.WriteLine("Numero de compte: " + numcompte);
            titulaire.afficher();
            solde.afficher();

        }
        public void Crediter(Mad amount)
        {
            solde += amount;
        }

        public bool Debiter(Mad amount)
        {
            Mad Null = new Mad(0);
            if (amount <= solde && amount <= plafond && amount >= Null)
            {
                solde -= amount;
                return true;
            }
            return false;
        }

        public void Virement(Compte Compte2, Mad amount)
        {
            if (this.Debiter(amount) == true)
            {
                Compte2.Crediter(amount);
            }
        }
    }
}
