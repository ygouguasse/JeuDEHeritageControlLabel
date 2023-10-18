using ex_jeuDeWinform.modeles;

namespace ex_jeuDeWinform.vues.controles
{
    public class LabelNomJoueur : Label
    {
        private Joueur _joueur = new Joueur();

        public Joueur Joueur { get => _joueur; set => ChangerJoueur(value); }

        private void ChangerJoueur(Joueur joueur)
        {
            DesabonnerEvenements();
            _joueur = joueur;
            ActualiserAffichage();
            AbonnerEvenements();
        }

        private void AbonnerEvenements()
        {
            _joueur.ChangementsSelectionne += Joueur_ChangementsSelectionne;
        }

        private void DesabonnerEvenements()
        {
            _joueur.ChangementsSelectionne -= Joueur_ChangementsSelectionne;
        }

        private void Joueur_ChangementsSelectionne(object? sender, EventArgs e)
        {
            ActualiserBackColor();
        }

        private void ActualiserAffichage()
        {
            Text = _joueur.Nom;
            ActualiserBackColor();
        }

        private void ActualiserBackColor()
        {
            BackColor = Control.DefaultBackColor;
            if (_joueur.Selectionne)
            {
                BackColor = Color.Red;
            }
        }

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
