using DesignPaltternance.Classes;
using DesignPaltternance.Notation;
using DesignPaltternance.Responsabilities;
using System;
using System.Collections.Generic;

namespace DesignPaltternance
{
    public class Eleve : IEleve
    {
        public List<Responsability> Responsabilities { get; }
        public Bulletin Bulletin { get; }
        public Classe Classe { get; }
        public string Name { get; }

        internal Eleve(string name, Classe classe)
        {
            this.Name = name;
            this.Classe = classe;
            Bulletin = new Bulletin(classe);
            Responsabilities = new List<Responsability>();
        }

        public void AddNote(string matiere, int note, int coef)
        {
            Bulletin.AddNote(matiere, new Note(note, coef));
        }

        public float GetMoyenne()
        {
            return Bulletin.GetMoyenneGenerale();
        }

        public int GetOpens()
        {
            int opens = 0;
            foreach (Responsability responsability in Responsabilities)
            {
                opens += responsability.GetOpen();
            }

            return opens;
        }
    }
}
