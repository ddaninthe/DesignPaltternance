using DesignPaltternance.Classes;
using DesignPaltternance.Notation;
using DesignPaltternance.Responsabilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPaltternance
{
    public interface IEleve
    {
        List<Responsability> Responsabilities { get; }
        Bulletin Bulletin { get; }
        Classe Classe { get; }

        int GetOpens();
    }
}
