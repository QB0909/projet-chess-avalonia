using System;
using System.Collections.Generic;

namespace Models
{
    public enum Resultat
    {
        BlancGagne,
        NoirGagne,
        Nul
    }

    public class Partie
    {
        public int Id { get; set; }
        public Joueur JoueurBlanc { get; set; }
        public Joueur JoueurNoir { get; set; }
        public List<string> Coups { get; set; } = new List<string>(); // Simple représentation des coups
        public Resultat Resultat { get; set; }

        public Partie() { }

        public Partie(Joueur blanc, Joueur noir)
        {
            JoueurBlanc = blanc;
            JoueurNoir = noir;
        }

        public void AjouterCoup(string coup)
        {
            Coups.Add(coup);
        }
    }
}
