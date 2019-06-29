using System;
using System.Collections.Generic;
using System.Text;
using DesignPaltternance.Classes.Filieres;
using DesignPaltternance.Classes.Niveaux;

namespace DesignPaltternance.Classes
{
    public class ClasseBuilder
    {
        private static Dictionary<string, Filiere> Filieres = new Dictionary<string, Filiere>();
        private static Dictionary<string, Niveau> Niveaux = new Dictionary<string, Niveau>();

        private Filiere Filiere;
        private Niveau Niveau;

        public ClasseBuilder(string niveauName)
        {
            if (!Niveaux.ContainsKey(niveauName))
            {
                switch(niveauName)
                {
                    case Premiere.Name:
                        Niveaux.Add(Premiere.Name, new Premiere());
                        break;
                    case Quatrieme.Name:
                        Niveaux.Add(Quatrieme.Name, new Quatrieme());
                        break;
                }
            }

            this.Niveau = Niveaux[niveauName];
        }

        public void filiere(string filiereName)
        {
            if (!Filieres.ContainsKey(filiereName))
            {
                switch(filiereName)
                {
                    case AL.Name:
                        Filieres.Add(AL.Name, new AL());
                        break;
                    case MOC.Name:
                        Filieres.Add(MOC.Name, new MOC());
                        break;
                }
            }

            this.Filiere = Filieres[filiereName];
        }

        public Classe build()
        {
            Classe classe = new Classe(this.Niveau);
            if (Filiere != null)
            {
                classe.SetFiliere(Filiere);
            }
            return classe;
        }
    }
}
