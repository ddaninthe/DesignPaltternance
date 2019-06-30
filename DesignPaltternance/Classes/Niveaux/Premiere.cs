using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPaltternance.Classes.Niveaux
{
    public class Premiere: Niveau
    {
        public const string Name = "Premiere";

        public string GetName()
        {
            return Name;
        }

        public bool Accept(Validator validator, IEleve eleve)
        {
            return validator.Validate(this, eleve);
        }
    }
}
