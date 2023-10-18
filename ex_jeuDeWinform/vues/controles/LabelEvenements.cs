using ex_jeuDeWinform.modeles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_jeuDeWinform.vues.controles
{
    public abstract class LabelEvenements : Label
    {
        protected abstract void AbonnerEvenements();

        protected abstract void DesabonnerEvenements();

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
