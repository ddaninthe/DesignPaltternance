using DesignPaltternance.Classes.Niveaux;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPaltternance
{
    public interface Validator
    {
        bool Validate(Premiere premiere, IEleve eleve);
        bool Validate(Quatrieme quatrieme, IEleve eleve);
    }
}
