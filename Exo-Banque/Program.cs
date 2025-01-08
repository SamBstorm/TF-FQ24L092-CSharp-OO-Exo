using Exo_Banque.Models;

namespace Exo_Banque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Courant c1 = new Courant();
            c1.LigneCredit = 200;
            c1.Titulaire = new Personne()
            {
                Nom = "Doe",
                Prenom = "Jhon",
                DateNaiss = new DateTime(1987, 9, 27)
            };
            c1.Numero = "BE01";

            Banque bank = new Banque();

            bank.Ajouter(c1);
            Courant compteTraite = bank["BE01"];
            compteTraite.Depot(1500);

            Console.WriteLine($"Le titulaire du compte BE01 est {compteTraite.Titulaire.Nom}.");
            Console.WriteLine($"Le Solde du compte BE01 est {compteTraite.Solde} €.");

            compteTraite.Retrait(2000);
            Console.WriteLine($"Le Solde du compte BE01 est {compteTraite.Solde} €.");
        }
    }
}
