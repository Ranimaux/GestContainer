
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
            this.components = new System.ComponentModel.Container();
            this.metroTextBoxCommentaire = new MetroFramework.Controls.MetroTextBox();
            this.metroCheckBoxUrgence = new MetroFramework.Controls.MetroCheckBox();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBoxProbleme = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroButtonAjoutDeclaration = new MetroFramework.Controls.MetroButton();
            this.metroStyleManagerAjoutDeclaration = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManagerAjoutDeclaration)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTextBoxCommentaire
            // 
            // 
            // 
            // 
            this.metroTextBoxCommentaire.CustomButton.Image = null;
            this.metroTextBoxCommentaire.CustomButton.Location = new System.Drawing.Point(125, 1);
            this.metroTextBoxCommentaire.CustomButton.Name = "";
            this.metroTextBoxCommentaire.CustomButton.Size = new System.Drawing.Size(73, 79);
            this.metroTextBoxCommentaire.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxCommentaire.CustomButton.TabIndex = 1;
            this.metroTextBoxCommentaire.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxCommentaire.CustomButton.UseSelectable = true;
            this.metroTextBoxCommentaire.CustomButton.Visible = false;
            this.metroTextBoxCommentaire.Lines = new string[0];
            this.metroTextBoxCommentaire.Location = new System.Drawing.Point(194, 139);
            this.metroTextBoxCommentaire.MaxLength = 100;
            this.metroTextBoxCommentaire.Name = "metroTextBoxCommentaire";
            this.metroTextBoxCommentaire.PasswordChar = '\0';
            this.metroTextBoxCommentaire.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxCommentaire.SelectedText = "";
            this.metroTextBoxCommentaire.SelectionLength = 0;
            this.metroTextBoxCommentaire.SelectionStart = 0;
            this.metroTextBoxCommentaire.ShortcutsEnabled = true;
            this.metroTextBoxCommentaire.Size = new System.Drawing.Size(199, 75);
            this.metroTextBoxCommentaire.TabIndex = 10;
            this.metroTextBoxCommentaire.UseSelectable = true;
            this.metroTextBoxCommentaire.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxCommentaire.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroCheckBoxUrgence
            // 
            this.metroCheckBoxUrgence.AutoSize = true;
            this.metroCheckBoxUrgence.BackColor = System.Drawing.Color.Transparent;
            this.metroCheckBoxUrgence.ForeColor = System.Drawing.Color.Gold;
            this.metroCheckBoxUrgence.Location = new System.Drawing.Point(259, 251);
            this.metroCheckBoxUrgence.Name = "metroCheckBoxUrgence";
            this.metroCheckBoxUrgence.Size = new System.Drawing.Size(67, 15);
            this.metroCheckBoxUrgence.TabIndex = 11;
            this.metroCheckBoxUrgence.Text = "Urgence";
            this.metroCheckBoxUrgence.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBoxUrgence.UseSelectable = true;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(34, 251);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(199, 29);
            this.metroComboBox1.TabIndex = 12;
            this.metroComboBox1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.Visible = false;
            // 
            // metroComboBoxProbleme
            // 
            this.metroComboBoxProbleme.BackColor = System.Drawing.Color.White;
            this.metroComboBoxProbleme.FormattingEnabled = true;
            this.metroComboBoxProbleme.ItemHeight = 23;
            this.metroComboBoxProbleme.Location = new System.Drawing.Point(356, 251);
            this.metroComboBoxProbleme.Name = "metroComboBoxProbleme";
            this.metroComboBoxProbleme.Size = new System.Drawing.Size(199, 29);
            this.metroComboBoxProbleme.TabIndex = 13;
            this.metroComboBoxProbleme.UseSelectable = true;
            this.metroComboBoxProbleme.SelectedIndexChanged += new System.EventHandler(this.metroComboBoxProbleme_SelectedIndexChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Black;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.Color.Gold;
            this.metroLabel2.Location = new System.Drawing.Point(356, 227);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(173, 19);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "Liste Probleme :              ";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Black;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.ForeColor = System.Drawing.Color.Gold;
            this.metroLabel3.Location = new System.Drawing.Point(35, 227);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(196, 19);
            this.metroLabel3.TabIndex = 15;
            this.metroLabel3.Text = "Liste Container :                    ";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel3.UseCustomForeColor = true;
            this.metroLabel3.Visible = false;
            // 
            // metroButtonAjoutDeclaration
            // 
            this.metroButtonAjoutDeclaration.BackColor = System.Drawing.Color.Gold;
            this.metroButtonAjoutDeclaration.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButtonAjoutDeclaration.ForeColor = System.Drawing.Color.Gold;
            this.metroButtonAjoutDeclaration.Location = new System.Drawing.Point(480, 333);
            this.metroButtonAjoutDeclaration.Name = "metroButtonAjoutDeclaration";
            this.metroButtonAjoutDeclaration.Size = new System.Drawing.Size(75, 25);
            this.metroButtonAjoutDeclaration.TabIndex = 16;
            this.metroButtonAjoutDeclaration.Text = "Envoyer";
            this.metroButtonAjoutDeclaration.UseSelectable = true;
            this.metroButtonAjoutDeclaration.Click += new System.EventHandler(this.metroButtonAjoutDeclaration_Click);
            // 
            // metroStyleManagerAjoutDeclaration
            // 
            this.metroStyleManagerAjoutDeclaration.Owner = null;
            this.metroStyleManagerAjoutDeclaration.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Black;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.Gold;
            this.metroLabel1.Location = new System.Drawing.Point(194, 115);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(189, 19);
            this.metroLabel1.TabIndex = 17;
            this.metroLabel1.Text = "Commentaire Déclaration :";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // FormAjoutDeclaration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 382);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButtonAjoutDeclaration);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroComboBoxProbleme);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.metroCheckBoxUrgence);
            this.Controls.Add(this.metroTextBoxCommentaire);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gold;
            this.Name = "FormAjoutDeclaration";
            this.Padding = new System.Windows.Forms.Padding(20, 65, 20, 22);
            this.Text = "Déclarer un incident";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.Gold;
            this.Load += new System.EventHandler(this.FormAjoutDeclaration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManagerAjoutDeclaration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox metroTextBoxCommentaire;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroComboBox metroComboBoxProbleme;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton metroButtonAjoutDeclaration;
        private MetroFramework.Components.MetroStyleManager metroStyleManagerAjoutDeclaration;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxUrgence;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}