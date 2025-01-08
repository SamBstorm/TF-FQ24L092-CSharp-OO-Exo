using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Banque.Models
{
    public class Banque
    {

        private Dictionary<String, Compte> Comptes = new Dictionary<string, Compte>(); 

        public Compte this[String numero]
        {
            get
            {
                return Comptes[numero];
            }
        }

        public void Ajouter(Compte courant)
        {
            if (!String.IsNullOrWhiteSpace(courant.Numero))
            {
                Comptes.Add(courant.Numero, courant);
            }
            else
            {
                throw new Exception("Le numéro de compte doit être informé.");
            }
            
        }

        public void Supprimer(String numero)
        {
            Comptes.Remove(numero);
        }

        public double AvoirDesComptes(Personne titulaire)
        {
            double soldeAvoirs = 0;
            foreach (KeyValuePair<string,Compte> kvpNumeroCompte in Comptes)
            {
                if(kvpNumeroCompte.Value.Titulaire == titulaire)
                {
                    soldeAvoirs += kvpNumeroCompte.Value;
                }
            }
            return soldeAvoirs;
        }
    }
}
