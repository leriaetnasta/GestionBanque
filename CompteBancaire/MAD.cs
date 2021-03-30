using System;
namespace compte_bancaire
{
    public class Mad
    {
        private double valeur;
        public Mad(double valeur)
        {
            this.valeur = valeur;
        }
        public void afficher()
        {
            Console.WriteLine("Solde: " + valeur);
        }
        public static Mad operator +(Mad Mad1, Mad Mad2)
        {
            return new Mad(Mad1.valeur + Mad2.valeur);
        }
        public static Mad operator-(Mad Mad1, Mad Mad2)
        {
            return new Mad(Mad1.valeur - Mad2.valeur);
        }
        public static Mad operator*(Mad Mad1, Mad Mad2)=>new Mad(Mad1.valeur * Mad2.valeur);
        
        public static bool operator >=(Mad Mad1, Mad Mad2) //les operateurs prends 2 val en parametres
        {
            if (Mad1.valeur >= Mad2.valeur)
            {
                return true;
            }
            return false;
        }
        public static bool operator >(Mad Mad1, Mad Mad2)
        {
            if (Mad1.valeur > Mad2.valeur)
            {
                return true;
            }
            return false;
        }
        public static bool operator<(Mad Mad1, Mad Mad2)
        {
            if (Mad1.valeur < Mad2.valeur)
            {
                return true;
            }
            return false;
        }
        public static bool operator <=(Mad Mad1, Mad Mad2)
        {
            if (Mad1.valeur <= Mad2.valeur)
            {
                return true;
            }
            return false;
        
    }
    }
}
