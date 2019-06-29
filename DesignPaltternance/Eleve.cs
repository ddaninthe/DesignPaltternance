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

        Eleve(Classe classe)
        {
            this.Classe = classe;
        }

        void AddResponsability(Responsability responsability)
        {
            Responsabilities.Add(responsability);
        }

        private int GetOpens()
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
