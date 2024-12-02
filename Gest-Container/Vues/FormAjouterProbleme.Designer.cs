
namespace GestContainer.Vues
{
    partial class FormAjouterProbleme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLibelleProbleme = new System.Windows.Forms.TextBox();
            this.ButtonAjouterProbleme = new System.Windows.Forms.Button();
            this.buttonAnnulerProbleme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Libelle du Probleme";
            // 
            // textBoxLibelleProbleme
            // 
            this.textBoxLibelleProbleme.Location = new System.Drawing.Point(187, 45);
            this.textBoxLibelleProbleme.Name = "textBoxLibelleProbleme";
            this.textBoxLibelleProbleme.Size = new System.Drawing.Size(198, 20);
            this.textBoxLibelleProbleme.TabIndex = 2;
            // 
            // ButtonAjouterProbleme
            // 
            this.ButtonAjouterProbleme.Location = new System.Drawing.Point(322, 88);
            this.ButtonAjouterProbleme.Name = "ButtonAjouterProbleme";
            this.ButtonAjouterProbleme.Size = new System.Drawing.Size(116, 23);
            this.ButtonAjouterProbleme.TabIndex = 3;
            this.ButtonAjouterProbleme.Text = "Ajouter le Probleme";
            this.ButtonAjouterProbleme.UseVisualStyleBackColor = true;
            this.ButtonAjouterProbleme.Click += new System.EventHandler(this.ButtonAjouterProbleme_Click);
            // 
            // buttonAnnulerProbleme
            // 
            this.buttonAnnulerProbleme.Location = new System.Drawing.Point(42, 88);
            this.buttonAnnulerProbleme.Name = "buttonAnnulerProbleme";
            this.buttonAnnulerProbleme.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnulerProbleme.TabIndex = 4;
            this.buttonAnnulerProbleme.Text = "Annuler";
            this.buttonAnnulerProbleme.UseVisualStyleBackColor = true;
            this.buttonAnnulerProbleme.Click += new System.EventHandler(this.buttonAnnulerProbleme_Click);
            // 
            // FormAjouterProbleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(450, 123);
            this.Controls.Add(this.buttonAnnulerProbleme);
            this.Controls.Add(this.ButtonAjouterProbleme);
            this.Controls.Add(this.textBoxLibelleProbleme);
            this.Controls.Add(this.label2);
            this.Name = "FormAjouterProbleme";
            this.Text = "FormAjouterProbleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLibelleProbleme;
        private System.Windows.Forms.Button ButtonAjouterProbleme;
        private System.Windows.Forms.Button buttonAnnulerProbleme;
    }
}