using System;
namespace compte_bancaire
{
    public class CompteEpargne : Compte
    {
        
        private double TauxInteret;

        public CompteEpargne(double t, double s, string n, string p, string a) :base(s,n,p,a)
        {
            while(t < 0 || t > 100)
            {
                Console.WriteLine("entrer un taux juste");
                t=double.Parse(Console.ReadLine());
            }
            TauxInteret = t;
        }
        public void calculInteret()
        {
            Mad taux = new Mad(TauxInteret / 100);
            Crediter(solde * taux);
             
        }



    
    }
}
