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
    }
}
