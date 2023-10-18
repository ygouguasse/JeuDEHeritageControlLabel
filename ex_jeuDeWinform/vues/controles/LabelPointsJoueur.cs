using ex_jeuDeWinform.modeles;
using System;
namespace ex_jeuDeWinform.vues.controles
{
    public class LabelPointsJoueur : Label
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
            _joueur.ChangementPoints += Joueur_ChangementPoints; ;
        }

        private void DesabonnerEvenements()
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
