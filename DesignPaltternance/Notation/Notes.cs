using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPaltternance.Notation
{
    public class Notes : Observer, NotationSubject
    {
        public Observer Observer { get; set; }
        private float Moyenne { get; set; }
        private List<Note> notes;

        public Notes()
        {
            notes = new List<Note>();
        }

        public float GetMoyenne()
        {
            return Moyenne;
        }

        public void AddNote(Note note)
        {
            note.AddObserver(this);
            notes.Add(note);
            Update();
        }

        public void AddObserver(Observer observer)
        {
            this.Observer = observer;
        }

        public void Notify()
        {
            if (this.Observer != null)
            {
                Observer.Update();
            }
        }

        public void RemoveObserver()
        {
            Observer = null;
        }

        public void Update()
        {
            float totalValue = 0;
            int totalCoef = 0;
            foreach (Note note in notes)
            {
                totalValue += note.GetNoteValue();
                totalCoef += note.GetCoef();
            }
            this.Moyenne = totalValue / totalCoef;

            Notify();
        }
    }
}
