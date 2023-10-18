namespace ex_jeuDeWinform.modeles
{
    public class Joueur
    {
        public const int PointsPourGagner = 100;

        public string Nom { get; }
        public int Points { get; private set; }
        public bool Selectionne { get; private set; }

        public event EventHandler? ChangementPoints;
        public event EventHandler? GagneLaPartie;
        public event EventHandler? ChangementsSelectionne;

        public Joueur()
        {
            Nom = "nom par defaut";
            Points = 0;
        }

        public Joueur(string nom)
        {
            Nom = nom;
            Points = 0;
        }

        public void AjouterPoints(int points)
        {
            Points += points;
            ChangementPoints?.Invoke(this, EventArgs.Empty);

            if (Points >= PointsPourGagner)
            {
                GagneLaPartie?.Invoke(this, EventArgs.Empty);
            }
        }

        public void Selectionner()
        {
            Selectionne = true;
            ChangementsSelectionne?.Invoke(this, EventArgs.Empty);
        }

        public void Deselectionner()
        {
            Selectionne = false;
            ChangementsSelectionne?.Invoke(this, EventArgs.Empty);
        }
    }
}
