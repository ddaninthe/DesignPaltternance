using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPaltternance.Notation
{
    public class Bulletin : Observer
    {
        private List<Notes> Notes;
        private float MoyenneGenerale;

        public Bulletin()
        {
            Notes = new List<Notes>();
        }

        public float GetMoyenneGenerale()
        {
            return MoyenneGenerale;
        }

        public void AddNotes(Notes notes)
        {
            notes.AddObserver(this);
            Notes.Add(notes);
            Update();
        }

        public void Update()
        {
            float total = 0;
            foreach (Notes notes in Notes)
            {
                total += notes.GetMoyenne();
            }
            MoyenneGenerale = total / Notes.Count;
        }
    }
}
