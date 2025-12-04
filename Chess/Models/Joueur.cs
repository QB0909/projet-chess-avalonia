using System;

namespace Models
{
    public class Joueur
    {
        public int Id { get; set; } // Pour la base de données
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public int Elo { get; set; } = 1000; // Elo initial par défaut

        public Joueur() { }

        public Joueur(string nom, string prenom, DateTime dateNaissance, string email = "", string telephone = "")
        {
            Nom = nom;
            Prenom = prenom;
            DateNaissance = dateNaissance;
            Email = email;
            Telephone = telephone;
        }
    }
}
