using DesignPaltternance.Classes.Filieres;
using DesignPaltternance.Classes.Niveaux;
using DesignPaltternance.Matieres;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPaltternance.Classes
{
    public class Classe
    {
        public Niveau Niveau { get; }
        public Filiere Filiere;
        public List<Matiere> Matieres;

        internal Classe(Niveau niveau)
        {
            Matieres = new List<Matiere>();
            this.Niveau = niveau;

            if (niveau is Premiere)
            {
                Matieres.Add(new C());
            }
        }

        internal void SetFiliere(Filiere filiere)
        {
            this.Filiere = filiere;

            if (filiere is AL)
            {
                Matieres.Add(new DesignPattern());
                Matieres.Add(new JEE());
            }
            if (filiere is MOC)
            {
                Matieres.Add(new IOS());
            }
        }
    }
}
