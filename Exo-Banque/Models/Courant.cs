using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Banque.Models
{
    public sealed class Courant : Compte
    {       

        private double _ligneCredit = 15;

        public double LigneCredit
        {
            get { return _ligneCredit; }
            set
            {
                _ligneCredit = double.Clamp(value, 0, double.MaxValue);
            }
        }        

        public override void Retrait(double montant)
        {
            if (-LigneCredit > Solde - montant) throw new Exception("Le solde depasse le montant autorisé par le crédit.");
            base.Retrait(montant);
        }


        public static double operator +(Courant left, Courant right)
        {
            /*
            double s1 = 0;
            double s2 = 0;
            if (left.Solde > 0)
            {
                s1 = left.Solde;
            }
            if (right.Solde > 0)
            {
                s2 = right.Solde;
            }
            return s1 + s2;

            //OU
            //return ((left.Solde > 0) ? left.Solde : 0) + ((right.Solde > 0) ? right.Solde : 0);
            //OU
            //return double.Max(0, left.Solde) + double.Max(0, right.Solde);*/
            return left.Solde + right;
        }

        public static double operator +(double left, Courant right)
        {
            double s1 = 0;
            double s2 = 0;
            if (left > 0)
            {
                s1 = left;
            }
            if (right.Solde > 0)
            {
                s2 = right.Solde;
            }
            return s1 + s2;

            //OU
            //return ((left > 0) ? left : 0) + ((right.Solde > 0) ? right.Solde : 0);
            //OU
            //return double.Max(0, left) + double.Max(0, right.Solde);
        }

    }
}
