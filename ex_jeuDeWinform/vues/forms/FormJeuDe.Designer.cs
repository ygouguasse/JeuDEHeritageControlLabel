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
            btnJouerTour = new Button();
            SuspendLayout();
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
            // FormJeuDe
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 302);
            Controls.Add(btnJouerTour);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "FormJeuDe";
            Text = "Jeu de dés";
            ResumeLayout(false);
        }

        #endregion
        private Button btnJouerTour;
    }
}