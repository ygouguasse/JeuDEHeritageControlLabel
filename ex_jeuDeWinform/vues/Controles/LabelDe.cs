using ex_jeuDeWinform.modeles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_jeuDeWinform.vues.Controles
{
    public class LabelDe : LabelEvenement
    {
        private De _De = new De();

        public De De { get => _De; set => ChangerDe(value); }

        public LabelDe()
        {
            BorderStyle = BorderStyle.FixedSingle;
           // TextAlign=  alignc

        }

        public void ChangerDe(De value)
        {
             AbonnerEvenements();

             DesAbonnerEvenements();

              De=value;

            ActualiserAffichage();

        }


        public override AbonnerEvenements()
        {

            De.ValeurChangee += De_ValeurChangee;


        }

        private void De_ValeurChangee(object? sender, EventArgs e)
        {
            ActualiserAffichage();
        }




    }
}
