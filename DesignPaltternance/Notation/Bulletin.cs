using DesignPaltternance.Classes;
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
                Notes n = new Notes();
                n.AddObserver(this);
                Notes.Add(m.GetName(), n);
            }
        }

        internal bool AddNote(string matiere, Note note)
        {
            if (Notes.ContainsKey(matiere))
            {
                Notes[matiere].AddNote(note);
                return true;
            }
            return false;
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
