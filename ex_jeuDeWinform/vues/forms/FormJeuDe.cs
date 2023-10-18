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
    }
}