using ex_jeuDeWinform.modeles;

namespace ex_jeuDeWinform.vues.controles
{
    public class LabelDe : Label
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

        private void AbonnerEvenements()
        {
            _de.ValeurChangee += De_ValeurChangee;
        }

        private void DesabonnerEvenements()
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

        /// <summary>
        /// Cette méthode est appelé lorsque le conteneur est supprimer.
        /// Si contenu dans une Form, lorsque la Form se fait Close(), elle dispose de tous ses controles
        /// avant. Vous pouvez le voir dans le fichier Form.Designer.cs des Form.
        /// On va libérer les ressources avant de se faire supprimer.
        /// </summary>
        /// <param name="disposing">true si les ressources gérées doivent être supprimées; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                DesabonnerEvenements();
            }
            base.Dispose(disposing);
        }
    }
}
