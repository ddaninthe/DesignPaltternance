using DesignPaltternance.Classes.Filieres;
using DesignPaltternance.Classes.Niveaux;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPaltternance.Classes
{
    public class Classe
    {
        public Niveau Niveau { get; }
        public Filiere Filiere;

        internal Classe(Niveau niveau)
        {
            this.Niveau = niveau;
        }

        internal void SetFiliere(Filiere filiere)
        {
            this.Filiere = filiere;
        }
    }
}
