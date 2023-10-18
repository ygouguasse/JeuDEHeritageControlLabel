using ex_jeuDeWinform.controleurs;
using ex_jeuDeWinform.modeles;

namespace ex_jeuDeWinform
{
    public partial class FormJeuDe : Form
    {
        Controleur _controleur = new Controleur();

        public FormJeuDe()
        {
            InitializeComponent();
            InitialiserControles();
            AbonnerEvenements();
        }

        private void InitialiserControles()
        {
            labelDe1.De = _controleur.Des[0];
            labelDe2.De = _controleur.Des[1];
            labelDe3.De = _controleur.Des[2];
            labelDe4.De = _controleur.Des[3];
            labelDe5.De = _controleur.Des[4];

            labelNomJoueur1.Joueur = _controleur.Joueurs[0];
            labelNomJoueur2.Joueur = _controleur.Joueurs[1];
            labelNomJoueur3.Joueur = _controleur.Joueurs[2];

            labelPointsJoueur1.Joueur = _controleur.Joueurs[0];
            labelPointsJoueur2.Joueur = _controleur.Joueurs[1];
            labelPointsJoueur3.Joueur = _controleur.Joueurs[2];
        }

        private void AbonnerEvenements()
        {
            foreach (var joueur in _controleur.Joueurs)
            {
                joueur.GagneLaPartie += Joueur_GagneLaPartie;
            }
        }

        private void Joueur_GagneLaPartie(object? sender, EventArgs e)
        {
            Joueur joueur = sender as Joueur;
            MessageBox.Show(joueur.Nom + " gagne la partie en " + _controleur.NombreTours + " tours!");
            Close();
        }

        private void btnJouerTour_Click(object sender, EventArgs e)
        {
            _controleur.JouerTour();
        }

        private void FormJeuDe_Load(object sender, EventArgs e)
        {

        }
    }
}