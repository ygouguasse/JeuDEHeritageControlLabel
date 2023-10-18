namespace ex_jeuDeWinform.modeles
{
    public class De
    {
        private int[] _faces;

        private static Random _generateurNombre = new Random();

        public int Valeur { get; private set; }

        public event EventHandler? ValeurChangee;

        public De()
        {
            _faces = new int[] { 1, 2, 3, 4, 5, 6 };
            Brasser();
        }

        public De(int face1, int face2, int face3, int face4, int face5, int face6)
        {
            _faces = new int[6];
            _faces[0] = face1;
            _faces[1] = face2;
            _faces[2] = face3;
            _faces[3] = face4;
            _faces[4] = face5;
            _faces[5] = face6;
            Brasser();
        }

        public void Brasser()
        {
            int faceAleatoire = _generateurNombre.Next(6);

            Valeur = _faces[faceAleatoire];

            ValeurChangee?.Invoke(this, EventArgs.Empty);
        }

        static public int operator +(De de1, De de2)
        {
            return de1.Valeur + de2.Valeur;
        }

        static public int operator +(De de1, int valeurAjout)
        {
            return de1.Valeur + valeurAjout;
        }

        static public int operator +(int valeurAjout, De de1)
        {
            return de1.Valeur + valeurAjout;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null ||
                obj is not De ||
                Valeur != ((De)obj).Valeur)
            {
                return false;
            }

            return true;
        }

        public override string ToString()
        {
            return Valeur.ToString();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
