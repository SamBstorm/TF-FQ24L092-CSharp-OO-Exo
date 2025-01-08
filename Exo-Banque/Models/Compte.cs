using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Banque.Models
{
    public class Compte
    {
        public string Numero { get; set; }
        public double Solde { get; private set; }
        public Personne Titulaire { get; set; }

        public virtual void Retrait(double montant)
        {
            if (montant <= 0) throw new ArgumentException(nameof(montant), "Le montant doit être supérieur à 0.");
            Solde -= montant;
        }
        public void Depot(double montant)
        {
            if (montant <= 0) throw new ArgumentException(nameof(montant), "Le montant doit être supérieur à 0.");
            Solde += montant;
        }

    }
}
