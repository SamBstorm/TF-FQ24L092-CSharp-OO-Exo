using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Banque.Models
{
    public class Banque
    {

        private Dictionary<String, Courant> Comptes = new Dictionary<string, Courant>(); 

        public Courant this[String numero]
        {
            get
            {
                return Comptes[numero];
            }
        }

        public void Ajouter(Courant courant)
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
            foreach (KeyValuePair<string,Courant> kvpNumeroCompte in Comptes)
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
