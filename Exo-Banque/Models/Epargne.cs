using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Banque.Models
{
    public sealed class Epargne : Compte
    {
        public DateTime? DateDernierRetrait { get; set; }
        
        public void Retrait(double montant)
        {
            
            if (Solde < montant) throw new InvalidOperationException("Le montant est trop élévé par rapport au solde.");
            base.Retrait(montant);
            DateDernierRetrait = DateTime.Now;
        }

        
    }
}
