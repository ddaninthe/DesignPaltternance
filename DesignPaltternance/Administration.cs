using System;
using System.Collections.Generic;
using System.Text;
using DesignPaltternance.Classes.Niveaux;

namespace DesignPaltternance
{
    class Administration
    {
        private Validator Validator;

        Administration()
        {
            Validator = new AnneeValidator();
        }

        bool ValidateEleve(IEleve eleve)
        {
            return eleve.Classe.Niveau.Accept(Validator, eleve);
        }
    }
}
