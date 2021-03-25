using System;
namespace compte_bancaire
{
    public class Operation
    {
        private int N;
        private Mad montant;
        private Date d;
        private string libelle;
        public Operation(int n, double m, Date d,string l)
        {
            this.N = n;
            montant = new Mad(m);
            this.d = d;
            libelle = l;
        }
    }
}
