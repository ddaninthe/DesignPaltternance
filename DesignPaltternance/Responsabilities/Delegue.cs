using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPaltternance.Responsabilities
{
    class Delegue : Responsability
    {
        private static readonly int OPEN = 2;

        public int GetOpen()
        {
            return OPEN;
        }
    }
}
