using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPaltternance.Classes.Filieres
{
    public class MOC : Filiere
    {
        public const string Name = "MOC";

        public string GetName()
        {
            return Name;
        }
    }
}
