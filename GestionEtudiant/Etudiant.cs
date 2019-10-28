using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEtudiant
{
    public class Etudiant
    {
        string prenom, dateNaissance, adresse, telephone;
        int cne, filiere;
        char sexe;

        public Etudiant(string nom, string prenom, string dateNaissance, string adresse, string telephone, int cne, int filiere, char sexe)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.DateNaissance = dateNaissance;
            this.Adresse = adresse;
            this.Telephone = telephone;
            this.Cne = cne;
            this.Filiere = filiere;
            this.Sexe = sexe;
        }

        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string DateNaissance { get; set; }
        public string Adresse { get; set; }
        public string Telephone { get; set; }
        public int Cne { get; set; }
        public int Filiere { get; set; }
        public char Sexe { get; set; }
    }
}
