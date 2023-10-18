using ex_jeuDeWinform.modeles;

namespace ex_jeuDeWinform.vues.controles
{
    public class LabelPointsJoueur : LabelEvenements
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

        protected override void AbonnerEvenements()
        {
            _joueur.ChangementPoints += Joueur_ChangementPoints; ;
        }

        protected override void DesabonnerEvenements()
        {
            _joueur.ChangementsSelectionne -= Joueur_ChangementPoints;
        }

        private void Joueur_ChangementPoints(object? sender, EventArgs e)
        {
            ActualiserAffichage();
        }

        private void ActualiserAffichage()
        {
            Text = _joueur.Points.ToString();
        }
    }
}
