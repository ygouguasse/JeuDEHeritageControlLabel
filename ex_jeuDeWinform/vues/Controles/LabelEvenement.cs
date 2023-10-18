using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_jeuDeWinform.vues.Controles
{
    public abstract class LabelEvenement : Label
    {
        public abstract void AbonnerEvenements();

        public abstract void DesAbonnerEvenements();

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                DesAbonnerEvenements();
            }
            base.Dispose(disposing);
        }



    }
}
