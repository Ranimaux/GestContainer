
namespace GestContainer.Vues
{
    partial class FormAjoutDeclaration
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
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonAjoutDeclaration = new System.Windows.Forms.Button();
            this.textBoxCommentaire = new System.Windows.Forms.TextBox();
            this.checkBoxUrgence = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboBoxProbleme = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 24);
            this.label1.MinimumSize = new System.Drawing.Size(150, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Commentaire déclaration :";
            // 
            // ButtonAjoutDeclaration
            // 
            this.ButtonAjoutDeclaration.Location = new System.Drawing.Point(551, 372);
            this.ButtonAjoutDeclaration.Name = "ButtonAjoutDeclaration";
            this.ButtonAjoutDeclaration.Size = new System.Drawing.Size(75, 23);
            this.ButtonAjoutDeclaration.TabIndex = 1;
            this.ButtonAjoutDeclaration.Text = "Envoyer";
            this.ButtonAjoutDeclaration.UseVisualStyleBackColor = true;
            this.ButtonAjoutDeclaration.Click += new System.EventHandler(this.ButtonAjoutDeclaration_Click);
            // 
            // textBoxCommentaire
            // 
            this.textBoxCommentaire.Location = new System.Drawing.Point(218, 24);
            this.textBoxCommentaire.Multiline = true;
            this.textBoxCommentaire.Name = "textBoxCommentaire";
            this.textBoxCommentaire.Size = new System.Drawing.Size(305, 202);
            this.textBoxCommentaire.TabIndex = 2;
            // 
            // checkBoxUrgence
            // 
            this.checkBoxUrgence.AutoSize = true;
            this.checkBoxUrgence.Location = new System.Drawing.Point(218, 268);
            this.checkBoxUrgence.Margin = new System.Windows.Forms.Padding(8);
            this.checkBoxUrgence.MinimumSize = new System.Drawing.Size(10, 10);
            this.checkBoxUrgence.Name = "checkBoxUrgence";
            this.checkBoxUrgence.Size = new System.Drawing.Size(15, 14);
            this.checkBoxUrgence.TabIndex = 5;
            this.checkBoxUrgence.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxUrgence.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 268);
            this.label2.MinimumSize = new System.Drawing.Size(150, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 50);
            this.label2.TabIndex = 6;
            this.label2.Text = "Urgence :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Probleme :";
            // 
            // ComboBoxProbleme
            // 
            this.ComboBoxProbleme.FormattingEnabled = true;
            this.ComboBoxProbleme.Location = new System.Drawing.Point(218, 322);
            this.ComboBoxProbleme.Name = "ComboBoxProbleme";
            this.ComboBoxProbleme.Size = new System.Drawing.Size(305, 21);
            this.ComboBoxProbleme.TabIndex = 8;
            this.ComboBoxProbleme.SelectedIndexChanged += new System.EventHandler(this.ComboBoxProbleme_SelectedIndexChanged);
            // 
            // FormAjoutDeclaration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(672, 439);
            this.Controls.Add(this.ComboBoxProbleme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxUrgence);
            this.Controls.Add(this.textBoxCommentaire);
            this.Controls.Add(this.ButtonAjoutDeclaration);
            this.Controls.Add(this.label1);
            this.Name = "FormAjoutDeclaration";
            this.Text = "Déclarer un incident";
            this.Load += new System.EventHandler(this.FormAjoutDeclaration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonAjoutDeclaration;
        private System.Windows.Forms.TextBox textBoxCommentaire;
        private System.Windows.Forms.CheckBox checkBoxUrgence;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboBoxProbleme;
    }
}