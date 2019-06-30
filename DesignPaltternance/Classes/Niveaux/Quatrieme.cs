using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPaltternance.Classes.Niveaux
{
    public class Quatrieme : Niveau
    {
        public const string Name = "Quatrieme";

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
