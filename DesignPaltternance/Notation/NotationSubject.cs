using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPaltternance.Notation
{
    public interface NotationSubject
    {
        Observer Observer { get; }

        void AddObserver(Observer observer);
        void RemoveObserver();
        void Notify();
    }
}
