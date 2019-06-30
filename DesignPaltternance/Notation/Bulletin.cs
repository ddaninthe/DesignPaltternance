﻿using DesignPaltternance.Classes;
using DesignPaltternance.Matieres;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPaltternance.Notation
{
    public class Bulletin : Observer
    {
        private Dictionary<string, Notes> Notes;
        private float MoyenneGenerale;

        public Bulletin(Classe classe)
        {
            Notes = new Dictionary<string, Notes>(classe.Matieres.Count);
            foreach (Matiere m in classe.Matieres)
            {
                Notes.Add(m.GetName(), new Notes());
            }
        }

        public float GetMoyenneGenerale()
        {
            return MoyenneGenerale;
        }

        public void Update()
        {
            float total = 0;
            foreach (Notes notes in Notes.Values)
            {
                total += notes.GetMoyenne();
            }
            MoyenneGenerale = total / Notes.Count;
        }
    }
}
