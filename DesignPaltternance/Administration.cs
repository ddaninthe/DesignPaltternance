using System;
using System.Collections.Generic;
using System.Text;
using DesignPaltternance.Classes;
using DesignPaltternance.Classes.Niveaux;
using DesignPaltternance.Responsabilities;

namespace DesignPaltternance
{
    public class Administration
    {
        private Validator Validator;

        public Administration()
        {
            Validator = new AnneeValidator();
        }

        public IEleve RegisterEleve(string name, Classe classe)
        {
            return new Eleve(name, classe);
        }

        public void AddResponsability(IEleve eleve, Responsability resp)
        {
            eleve.Responsabilities.Add(resp);
        }

        public Classe CreateClasse(string niveau, string filiere = null)
        {
            ClasseBuilder builder = new ClasseBuilder(niveau);
            if (filiere != null)
            {
                builder.filiere(filiere);
            }
            return builder.build();
        }

        public bool ValidateEleve(IEleve eleve)
        {
            return eleve.Classe.Niveau.Accept(Validator, eleve)
                && eleve.GetOpens() > 0;
        }
    }
}
