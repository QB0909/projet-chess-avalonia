using System;
using System.Collections.Generic;

namespace Models
{
    public class Competition
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }

        // Liste des joueurs inscrits
        public List<Joueur> JoueursInscrits { get; set; } = new List<Joueur>();

        // Liste des parties jouées
        public List<Partie> Parties { get; set; } = new List<Partie>();

        public Competition() { }

        public Competition(string nom, DateTime dateDebut, DateTime dateFin)
        {
            Nom = nom;
            DateDebut = dateDebut;
            DateFin = dateFin;
        }

        public void InscrireJoueur(Joueur joueur)
        {
            if (!JoueursInscrits.Contains(joueur))
                JoueursInscrits.Add(joueur);
        }
    }
}
