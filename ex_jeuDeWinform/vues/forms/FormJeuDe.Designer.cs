namespace ex_jeuDeWinform
{
    partial class FormJeuDe
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            modeles.De de1 = new modeles.De();
            modeles.De de2 = new modeles.De();
            modeles.De de3 = new modeles.De();
            modeles.De de4 = new modeles.De();
            modeles.De de5 = new modeles.De();
            modeles.Joueur joueur1 = new modeles.Joueur();
            modeles.Joueur joueur2 = new modeles.Joueur();
            modeles.Joueur joueur3 = new modeles.Joueur();
            modeles.Joueur joueur4 = new modeles.Joueur();
            modeles.Joueur joueur5 = new modeles.Joueur();
            modeles.Joueur joueur6 = new modeles.Joueur();
            labelDe1 = new vues.controles.LabelDe();
            labelDe2 = new vues.controles.LabelDe();
            labelDe3 = new vues.controles.LabelDe();
            labelDe4 = new vues.controles.LabelDe();
            labelDe5 = new vues.controles.LabelDe();
            btnJouerTour = new Button();
            labelNomJoueur1 = new vues.controles.LabelNomJoueur();
            labelNomJoueur2 = new vues.controles.LabelNomJoueur();
            labelNomJoueur3 = new vues.controles.LabelNomJoueur();
            labelPointsJoueur1 = new vues.controles.LabelPointsJoueur();
            labelPointsJoueur2 = new vues.controles.LabelPointsJoueur();
            labelPointsJoueur3 = new vues.controles.LabelPointsJoueur();
            SuspendLayout();
            // 
            // labelDe1
            // 
            labelDe1.BorderStyle = BorderStyle.FixedSingle;
            labelDe1.De = de1;
            labelDe1.Location = new Point(12, 9);
            labelDe1.Name = "labelDe1";
            labelDe1.Size = new Size(76, 55);
            labelDe1.TabIndex = 0;
            labelDe1.Text = "77";
            labelDe1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelDe2
            // 
            labelDe2.BorderStyle = BorderStyle.FixedSingle;
            labelDe2.De = de2;
            labelDe2.Location = new Point(94, 9);
            labelDe2.Name = "labelDe2";
            labelDe2.Size = new Size(76, 55);
            labelDe2.TabIndex = 1;
            labelDe2.Text = "77";
            labelDe2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelDe3
            // 
            labelDe3.BorderStyle = BorderStyle.FixedSingle;
            labelDe3.De = de3;
            labelDe3.Location = new Point(176, 9);
            labelDe3.Name = "labelDe3";
            labelDe3.Size = new Size(76, 55);
            labelDe3.TabIndex = 2;
            labelDe3.Text = "77";
            labelDe3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelDe4
            // 
            labelDe4.BorderStyle = BorderStyle.FixedSingle;
            labelDe4.De = de4;
            labelDe4.Location = new Point(258, 9);
            labelDe4.Name = "labelDe4";
            labelDe4.Size = new Size(76, 55);
            labelDe4.TabIndex = 3;
            labelDe4.Text = "77";
            labelDe4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelDe5
            // 
            labelDe5.BorderStyle = BorderStyle.FixedSingle;
            labelDe5.De = de5;
            labelDe5.Location = new Point(340, 9);
            labelDe5.Name = "labelDe5";
            labelDe5.Size = new Size(76, 55);
            labelDe5.TabIndex = 4;
            labelDe5.Text = "77";
            labelDe5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnJouerTour
            // 
            btnJouerTour.Location = new Point(12, 67);
            btnJouerTour.Name = "btnJouerTour";
            btnJouerTour.Size = new Size(404, 77);
            btnJouerTour.TabIndex = 5;
            btnJouerTour.Text = "Jouer tour";
            btnJouerTour.UseVisualStyleBackColor = true;
            btnJouerTour.Click += btnJouerTour_Click;
            // 
            // labelNomJoueur1
            // 
            labelNomJoueur1.AutoSize = true;
            labelNomJoueur1.BackColor = SystemColors.Control;
            labelNomJoueur1.Joueur = joueur1;
            labelNomJoueur1.Location = new Point(12, 147);
            labelNomJoueur1.Name = "labelNomJoueur1";
            labelNomJoueur1.Size = new Size(300, 48);
            labelNomJoueur1.TabIndex = 6;
            labelNomJoueur1.Text = "labelNomJoueur1";
            // 
            // labelNomJoueur2
            // 
            labelNomJoueur2.AutoSize = true;
            labelNomJoueur2.BackColor = SystemColors.Control;
            labelNomJoueur2.Joueur = joueur2;
            labelNomJoueur2.Location = new Point(12, 195);
            labelNomJoueur2.Name = "labelNomJoueur2";
            labelNomJoueur2.Size = new Size(300, 48);
            labelNomJoueur2.TabIndex = 7;
            labelNomJoueur2.Text = "labelNomJoueur2";
            // 
            // labelNomJoueur3
            // 
            labelNomJoueur3.AutoSize = true;
            labelNomJoueur3.BackColor = SystemColors.Control;
            labelNomJoueur3.Joueur = joueur3;
            labelNomJoueur3.Location = new Point(12, 243);
            labelNomJoueur3.Name = "labelNomJoueur3";
            labelNomJoueur3.Size = new Size(300, 48);
            labelNomJoueur3.TabIndex = 8;
            labelNomJoueur3.Text = "labelNomJoueur3";
            // 
            // labelPointsJoueur1
            // 
            labelPointsJoueur1.AutoSize = true;
            labelPointsJoueur1.Joueur = joueur4;
            labelPointsJoueur1.Location = new Point(318, 147);
            labelPointsJoueur1.Name = "labelPointsJoueur1";
            labelPointsJoueur1.Size = new Size(91, 48);
            labelPointsJoueur1.TabIndex = 9;
            labelPointsJoueur1.Text = "pt j1";
            // 
            // labelPointsJoueur2
            // 
            labelPointsJoueur2.AutoSize = true;
            labelPointsJoueur2.Joueur = joueur5;
            labelPointsJoueur2.Location = new Point(318, 195);
            labelPointsJoueur2.Name = "labelPointsJoueur2";
            labelPointsJoueur2.Size = new Size(91, 48);
            labelPointsJoueur2.TabIndex = 10;
            labelPointsJoueur2.Text = "pt j2";
            // 
            // labelPointsJoueur3
            // 
            labelPointsJoueur3.AutoSize = true;
            labelPointsJoueur3.Joueur = joueur6;
            labelPointsJoueur3.Location = new Point(318, 245);
            labelPointsJoueur3.Name = "labelPointsJoueur3";
            labelPointsJoueur3.Size = new Size(91, 48);
            labelPointsJoueur3.TabIndex = 11;
            labelPointsJoueur3.Text = "pt j3";
            // 
            // FormJeuDe
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 302);
            Controls.Add(labelPointsJoueur3);
            Controls.Add(labelPointsJoueur2);
            Controls.Add(labelPointsJoueur1);
            Controls.Add(labelNomJoueur3);
            Controls.Add(labelNomJoueur2);
            Controls.Add(labelNomJoueur1);
            Controls.Add(btnJouerTour);
            Controls.Add(labelDe5);
            Controls.Add(labelDe4);
            Controls.Add(labelDe3);
            Controls.Add(labelDe2);
            Controls.Add(labelDe1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "FormJeuDe";
            Text = "Jeu de dés";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private vues.controles.LabelDe labelDe1;
        private vues.controles.LabelDe labelDe2;
        private vues.controles.LabelDe labelDe3;
        private vues.controles.LabelDe labelDe4;
        private vues.controles.LabelDe labelDe5;
        private Button btnJouerTour;
        private vues.controles.LabelNomJoueur labelNomJoueur1;
        private vues.controles.LabelNomJoueur labelNomJoueur2;
        private vues.controles.LabelNomJoueur labelNomJoueur3;
        private vues.controles.LabelPointsJoueur labelPointsJoueur1;
        private vues.controles.LabelPointsJoueur labelPointsJoueur2;
        private vues.controles.LabelPointsJoueur labelPointsJoueur3;
    }
}