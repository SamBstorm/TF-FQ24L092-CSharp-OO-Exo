using Demo_Polymorphisme01.Models;

namespace Demo_Polymorphisme01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Joueur joueur = new Joueur();

            Equipement e = new Equipement() { 
                Nom = "Epée de vérité",
                Bonus = 10
            };


            Equipement e1 = new Equipement()
            {
                Nom = "Casque du savoir",
                Bonus = 5
            };

            ObjetSoin potion = new ObjetSoin()
            {
                Nom = "Potion de santé",
                Bonus = 20
            };

            ObjetSoin potion1 = new ObjetSoin()
            {
                Nom = "Potion de magie",
                Bonus = 20
            };

            ObjetQuete cle = new ObjetQuete() { Nom = "Clé du donjon" };

            joueur.Ramasser(e);
            joueur.Ramasser(e1);
            joueur.Ramasser(potion);
            joueur.Ramasser(potion1);
            joueur.Ramasser(cle);

            joueur.Utiliser(cle);
            joueur.Utiliser(e);
            joueur.Utiliser(e1);
            joueur.Utiliser(e);
            joueur.Utiliser(potion);
            joueur.Utiliser(potion1);
        }
    }
}
