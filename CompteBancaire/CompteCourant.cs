using System;
namespace compte_bancaire
{
    public class CompteCourant: Compte
    {
        private Mad decouvert;

        public CompteCourant(double d,double s, string n, string p, string a) : base(s, n, p, a)
        {
            decouvert = new Mad(d);
        }
        public override bool Debiter(Mad amount)
        {
            
            if () {
                
                return base.Debiter(amount);
            }
            else
            {
                Console.WriteLine("somme>decouvert");
                return false;

            }

        }



    }
}
