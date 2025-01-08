using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Banque.Models
{
    public class Courant
    {
        public string Numero { get; set; } = string.Empty;

        public double Solde { get; private set; }

        private double _ligneCredit = 15;

        public double LigneCredit
        {
            get { return _ligneCredit; }
            set
            {
                _ligneCredit = double.Clamp(value, 0, double.MaxValue);
            }
        }

        public Personne? Titulaire { get; set; }

        public void Retrait(double montant)
        {
            if (0 - LigneCredit <= Solde - montant) { 
                Solde -= montant;
            }
            else
            {
                throw new Exception("Le solde depasse le montant autorisé par le crédit.");
            }
            
        }

        public void Depot(double montant)
        {
            Solde += montant;
        }

    }
}
