using ex_jeuDeWinform.modeles;
using ex_jeuDeWinform.vues.Controles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_jeuDeWinform.vues.controles
{
    public class LabelJoueur : LabelEvenement
    {
        private Joueur _joueur = new Joueur();

        public Joueur Joueur { get => _joueur; set => ChagerJoueur(value);}

        public LabelJoueur()
        {
            BorderStyle = BorderStyle.FixedSingle;
            TextAlign= ContentAlignment.MiddleCenter;

        }

    
        public void ChagerJoueur(Joueur value)
        {
            AbonnerEvenements();

            _joueur = value;

            DesAbonnerEvenements();

            ActualiserAfficher();

        }


        public override void AbonnerEvenements()
        {
            _joueur.ChangementsSelectionne += _joueur_ChangementsSelectionne;

        }

        private void _joueur_ChangementsSelectionne(object? sender, EventArgs e)
        {
            ActualiserAfficher();
        }

        public override void DesAbonnerEvenements()
        {
            _joueur.ChangementsSelectionne-= _joueur_ChangementsSelectionne;

        }


        private void ActualiserAfficher()
        {

            Text=Joueur.ToString();

        }



    }
}
