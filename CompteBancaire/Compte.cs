using System;
namespace compte_bancaire
{
    public class Compte
    {
        
        private readonly int numcompte;
        private static int cpt;
        private Client titulaire;
        protected Mad solde;
        protected static Mad plafond;
        ArraySegment<Operation> op;
        static Compte()
        {
            cpt = 1;
            plafond = new Mad(3500);
        }

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
        public bool Crediter(Mad amount)
        {
            Mad Null = new Mad(0);
            if (amount >= Null)
            {
                solde += amount;
                return true;

            }
            return false;
        }

        public virtual bool Debiter(Mad amount)
        {
            Mad Null = new Mad(0);
            if (amount <= solde)
            {
                if (amount <= plafond)
                {
                    if (amount >= Null)
                    {
                        solde -= amount;
                        return true;
                    }
                    else {
                       Console.WriteLine("somme <0");
                       return false; }
                }
                else { Console.WriteLine("somme>plafond");
                        return false; }

            }
            else { Console.WriteLine("solde insuffisant");
                return false;
            }

            
        }

        public bool Virement(Compte Compte2, Mad amount)
        {
            return (this.Debiter(amount) && Compte2.Crediter(amount));
            
        }
        public 
    }
    public bool comparerDec(Mad amount, Mad dec){
    if(this.solde - amount > decouvert){
        return true;
    }
        return false;
    }
}
