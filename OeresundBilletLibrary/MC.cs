using System;
using System.Collections.Generic;
using System.Text;
using BilletLibrary;

namespace OeresundBilletLibrary
{

    public class MC : Køretøjer , IBroBizz
    {
        
        #region Constructor

        public MC()
        {
        }

        public MC(string nummerPlade, DateTime dato) : base(nummerPlade, dato)
        {
        }

        #endregion

        #region Methods

        public override decimal Pris()
        {
            return 210;
        }

        public override string Køretøj()
        {
            return "Øresund MC";
        }

        public decimal BroBizz()
        {
            return 73;
        }

        #endregion

    }
}
