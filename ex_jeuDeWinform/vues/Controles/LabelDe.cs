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
            TextAlign = ContentAlignment.MiddleCenter;

        }

        public void ChangerDe(De value)
        {
             AbonnerEvenements();

             DesAbonnerEvenements();

             _De = value;

            ActualiserAffichage();

        }

       



        public override void AbonnerEvenements()
        {

            _De.ValeurChangee += _De_ValeurChangee;


        }

        private void _De_ValeurChangee(object? sender, EventArgs e)
        {
            ActualiserAffichage();
        }


        public override void DesAbonnerEvenements()
        {

            _De.ValeurChangee-= _De_ValeurChangee;

        }

        private void ActualiserAffichage()
        {

            Text=_De.ToString();


        }




    }
}
