﻿using DesignPaltternance.Classes;
using DesignPaltternance.Notation;
using DesignPaltternance.Responsabilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPaltternance
{
    public interface IEleve
    {
        string Name { get; }
        List<Responsability> Responsabilities { get; }
        Bulletin Bulletin { get; }
        Classe Classe { get; }

        int GetOpens();
        void AddNote(string matiere, int note, int coef);
        float GetMoyenne();
    }
}
