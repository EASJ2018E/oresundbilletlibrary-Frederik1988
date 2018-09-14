using System;
using BilletLibrary;

namespace OeresundBilletLibrary
{
    public class Bil : Køretøjer , IBroBizz
    {

        #region Constructors

        public Bil()
        {
        }

        public Bil(string nummerPlade, DateTime dato) : base(nummerPlade, dato)
        {
        }

        #endregion

        #region Methods

        public override decimal Pris()
        {
            return 410;
        }

        public override string Køretøj()
        {
            return "Øresund Bil";
        }

        public decimal BroBizz()
        {
            return 161;
        }

        #endregion

    }
}
