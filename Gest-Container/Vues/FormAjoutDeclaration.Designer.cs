
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
            this.ButtonAjoutDeclaration.Location = new System.Drawing.Point(578, 264);
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
            this.checkBoxUrgence.Location = new System.Drawing.Point(218, 264);
            this.checkBoxUrgence.Margin = new System.Windows.Forms.Padding(8);
            this.checkBoxUrgence.MinimumSize = new System.Drawing.Size(10, 10);
            this.checkBoxUrgence.Name = "checkBoxUrgence";
            this.checkBoxUrgence.Size = new System.Drawing.Size(58, 17);
            this.checkBoxUrgence.TabIndex = 5;
            this.checkBoxUrgence.Text = "Urgent";
            this.checkBoxUrgence.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxUrgence.UseVisualStyleBackColor = true;
            // 
            // FormAjoutDeclaration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(931, 656);
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
    }
}