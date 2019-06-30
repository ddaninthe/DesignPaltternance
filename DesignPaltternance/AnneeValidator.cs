using DesignPaltternance.Classes.Niveaux;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPaltternance
{
    class AnneeValidator : Validator
    {
        public bool Validate(Premiere premiere, IEleve eleve)
        {
            return eleve.Bulletin.GetMoyenneGenerale() > 9;
        }

        public bool Validate(Quatrieme quatrieme, IEleve eleve)
        {
            return eleve.Bulletin.GetMoyenneGenerale() > 11;
        }
    }
}
