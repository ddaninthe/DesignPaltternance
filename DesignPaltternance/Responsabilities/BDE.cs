using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPaltternance.Responsabilities
{
    class BDE : Responsability
    {
        private static readonly int OPEN = 4;

        public int GetOpen()
        {
            return OPEN;
        }
    }
}
