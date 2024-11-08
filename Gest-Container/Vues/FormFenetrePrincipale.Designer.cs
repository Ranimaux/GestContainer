
namespace GestContainer.Vues
{
    partial class FormFenetrePrincipale
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
            this.menuPrincipalMenuStrip = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // menuPrincipalMenuStrip
            // 
            this.menuPrincipalMenuStrip.BackgroundImage = global::GestContainer.Properties.Resources.logo_tholdi2;
            this.menuPrincipalMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipalMenuStrip.Name = "menuPrincipalMenuStrip";
            this.menuPrincipalMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuPrincipalMenuStrip.Size = new System.Drawing.Size(815, 24);
            this.menuPrincipalMenuStrip.TabIndex = 1;
            this.menuPrincipalMenuStrip.Text = "menuPrincipalMenuStrip";
            // 
            // FormFenetrePrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(815, 450);
            this.Controls.Add(this.menuPrincipalMenuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuPrincipalMenuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFenetrePrincipale";
            this.RightToLeftLayout = true;
            this.Text = "GestionContainer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipalMenuStrip;
    }
}