using ex_jeuDeWinform.modeles;

namespace ex_jeuDeWinform.controleurs
{
    public class Controleur
    {
        public const int MaxDes = 5;
        public const int MaxJoueur = 3;

        private int _idJoueurCourant = 0;

        public De[] Des { get; } = new De[MaxDes];
        public Joueur[] Joueurs { get; } = new Joueur[MaxJoueur];
        public Joueur JoueurCourant { get => Joueurs[_idJoueurCourant]; }
        public int NombreTours { get; private set; } = 1;

        public Controleur()
        {
            CreerLesDes();
            CreerLesJoueurs();
            Joueurs[0].Selectionner();
        }

        private void CreerLesDes()
        {
            for (int i = 0; i < MaxDes; ++i)
            {
                Des[i] = new De(2, 4, 6, 8, 10, 12);
            }
        }

        private void CreerLesJoueurs()
        {
            Joueurs[0] = new Joueur("Fred");
            Joueurs[1] = new Joueur("Arthur");
            Joueurs[2] = new Joueur("Dino");
        }

        public void JouerTour()
        {
            BrasserLesDes();
            AjouterPointsJoueurCourant();
            PasserAuJoueurSuivant();
        }

        public void BrasserLesDes()
        {
            foreach (De de in Des)
            {
                de.Brasser();
            }
        }

        public void AjouterPointsJoueurCourant()
        {
            int points = 0;

            foreach (De de in Des)
            {
                // Utilisation de la surcharge de l'opérateur + de Dé
                points += de;
            }

            JoueurCourant.AjouterPoints(points);
        }

        public void PasserAuJoueurSuivant()
        {
            JoueurCourant.Deselectionner();
            _idJoueurCourant = (_idJoueurCourant + 1) % MaxJoueur;
            JoueurCourant.Selectionner();

            if (_idJoueurCourant == 0)
            {
                NombreTours++;
            }
        }
    }
}
