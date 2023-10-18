using ex_jeuDeWinform.modeles;

namespace ex_jeuDeWinform.vues.controles
{
    public class LabelDe : LabelEvenements
    {
        private De _de = new De();

        public De De { get => _de; set => ChangerDe(value); }

        public LabelDe()
        {
            BorderStyle = BorderStyle.FixedSingle;
            TextAlign = ContentAlignment.MiddleCenter;
        }

        private void ChangerDe(De value)
        {
            DesabonnerEvenements();
            _de = value;
            ActualiserAffichage();
            AbonnerEvenements();
        }

        protected override void AbonnerEvenements()
        {
            _de.ValeurChangee += De_ValeurChangee;
        }

        protected override void DesabonnerEvenements()
        {
            _de.ValeurChangee -= De_ValeurChangee;
        }

        private void De_ValeurChangee(object? sender, EventArgs e)
        {
            ActualiserAffichage();
        }

        private void ActualiserAffichage()
        {
            Text = _de.ToString();
        }
    }
}
