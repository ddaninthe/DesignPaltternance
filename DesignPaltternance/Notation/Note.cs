using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPaltternance.Notation
{
    public class Note : NotationSubject
    {
        public Observer Observer { get; set; }
        private int Coef;
        private int note;

        public Note(int note, int coef)
        {
            this.note = note;
            this.Coef = coef;
        }

        public int GetNoteValue()
        {
            return Coef * note;
        }

        public int GetCoef()
        {
            return Coef;
        }

        public void setCoef(int coef)
        {
            this.Coef = coef;
            this.Notify();
        }

        public void setNote(int note)
        {
            this.note = note;
            this.Notify();
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
            this.Observer = null;
        }
    }
}
