using Demo_InterfaceFiltre.Models;

namespace Demo_InterfaceFiltre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Personne> joueurs = new List<Personne>()
                {
                new Personne() { Nom = "Thierry" },
                new Personne() { Nom = "Michaël" }
                };

            List<Propriete> proprietes = new List<Propriete>()
            {
                new Propriete() { Nom = "TFTIC", Prix = 200},
                new Propriete() { Nom = "E6K", Prix = 220 }
            };


            for (int i = 0; i < 20; i++)
            {
                Random RNG = new Random();
                Personne j = joueurs[i % joueurs.Count];
                Propriete prop = proprietes[RNG.Next(2)];
                if(prop.Proprietaire is null)
                {
                    prop.Proprietaire = j;
                }
                else
                {
                    if(j == prop.Proprietaire)
                    {
                        Console.WriteLine($"Vous êtes chez vous! ({prop.Nom})");
                        Console.WriteLine($"Que voulez-vous faire?");
                        IProprietaire p = prop;
                        Console.WriteLine($"Changer l'hypothèque? (La propriété {(p.EstHypotequee ? "est déjà" : "n'est pas")} hypotéquée)");
                        string answer = Console.ReadLine();
                        if( answer == "oui")
                        {
                            p.ChangerHypoteque();
                            Console.WriteLine("Changement effectué.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Vous êtes arrivé à ({prop.Nom}). Reposez-vous!");
                        IVisiteur p = prop;
                        p.Sejourner(j);
                    }
                }
            }
        }
    }
}
