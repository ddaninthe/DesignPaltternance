using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPaltternance.Responsabilities
{
    public class Delegue : Responsability
    {
        private static readonly int OPEN = 2;

        public int GetOpen()
        {
            return OPEN;
        }
    }
}
