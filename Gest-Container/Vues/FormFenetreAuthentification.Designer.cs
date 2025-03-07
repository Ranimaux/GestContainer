
namespace GestContainer.Vues
{
    partial class FormFenetreAuthentification
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
            this.groupBoxFormAuthentification = new System.Windows.Forms.GroupBox();
            this.CheckBoxPassword = new System.Windows.Forms.CheckBox();
            this.ButtonAuthentification = new System.Windows.Forms.Button();
            this.TextBoxPassWord = new System.Windows.Forms.TextBox();
            this.TextBoxIdentifiant = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxFormAuthentification.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxFormAuthentification
            // 
            this.groupBoxFormAuthentification.Controls.Add(this.CheckBoxPassword);
            this.groupBoxFormAuthentification.Controls.Add(this.ButtonAuthentification);
            this.groupBoxFormAuthentification.Controls.Add(this.TextBoxPassWord);
            this.groupBoxFormAuthentification.Controls.Add(this.TextBoxIdentifiant);
            this.groupBoxFormAuthentification.Controls.Add(this.label2);
            this.groupBoxFormAuthentification.Controls.Add(this.label1);
            this.groupBoxFormAuthentification.Location = new System.Drawing.Point(26, 25);
            this.groupBoxFormAuthentification.Name = "groupBoxFormAuthentification";
            this.groupBoxFormAuthentification.Size = new System.Drawing.Size(423, 280);
            this.groupBoxFormAuthentification.TabIndex = 0;
            this.groupBoxFormAuthentification.TabStop = false;
            this.groupBoxFormAuthentification.Text = "Authentification";
            // 
            // CheckBoxPassword
            // 
            this.CheckBoxPassword.AutoSize = true;
            this.CheckBoxPassword.Location = new System.Drawing.Point(150, 127);
            this.CheckBoxPassword.Name = "CheckBoxPassword";
            this.CheckBoxPassword.Size = new System.Drawing.Size(139, 17);
            this.CheckBoxPassword.TabIndex = 5;
            this.CheckBoxPassword.Text = "Afficher le mot de passe";
            this.CheckBoxPassword.UseVisualStyleBackColor = true;
            this.CheckBoxPassword.CheckedChanged += new System.EventHandler(this.CheckBoxPassword_CheckedChanged);
            // 
            // ButtonAuthentification
            // 
            this.ButtonAuthentification.Location = new System.Drawing.Point(261, 170);
            this.ButtonAuthentification.Name = "ButtonAuthentification";
            this.ButtonAuthentification.Size = new System.Drawing.Size(112, 23);
            this.ButtonAuthentification.TabIndex = 4;
            this.ButtonAuthentification.Text = "Se Connecter";
            this.ButtonAuthentification.UseVisualStyleBackColor = true;
            this.ButtonAuthentification.Click += new System.EventHandler(this.ButtonAuthentification_Click);
            // 
            // TextBoxPassWord
            // 
            this.TextBoxPassWord.Location = new System.Drawing.Point(150, 101);
            this.TextBoxPassWord.Name = "TextBoxPassWord";
            this.TextBoxPassWord.Size = new System.Drawing.Size(146, 20);
            this.TextBoxPassWord.TabIndex = 3;
            // 
            // TextBoxIdentifiant
            // 
            this.TextBoxIdentifiant.Location = new System.Drawing.Point(150, 63);
            this.TextBoxIdentifiant.Name = "TextBoxIdentifiant";
            this.TextBoxIdentifiant.Size = new System.Drawing.Size(146, 20);
            this.TextBoxIdentifiant.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mot de passe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identifiant";
            // 
            // FormFenetreAuthentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1060, 737);
            this.Controls.Add(this.groupBoxFormAuthentification);
            this.Name = "FormFenetreAuthentification";
            this.Text = "Fenetre Authentification";
            this.Load += new System.EventHandler(this.FormFenetreAuthentification_Load);
            this.groupBoxFormAuthentification.ResumeLayout(false);
            this.groupBoxFormAuthentification.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxFormAuthentification;
        private System.Windows.Forms.TextBox TextBoxPassWord;
        private System.Windows.Forms.TextBox TextBoxIdentifiant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonAuthentification;
        private System.Windows.Forms.CheckBox CheckBoxPassword;
    }
}