﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPaltternance.Classes.Niveaux
{
    public interface Niveau
    {
        string GetName();
        bool Accept(Validator validator, IEleve eleve);
    }
}
