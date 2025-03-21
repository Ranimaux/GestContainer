
namespace GestContainer.Vues
{
    partial class FormModificationDeclaration
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCommentaireDeclaration = new System.Windows.Forms.TextBox();
            this.checkBoxUrgence = new System.Windows.Forms.CheckBox();
            this.dateTimePickerDateDeclaration = new System.Windows.Forms.DateTimePicker();
            this.buttonModificationDeclaration = new System.Windows.Forms.Button();
            this.buttonAnnulationDeclaration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Commentaire Déclaration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Urgence";
            // 
            // textBoxCommentaireDeclaration
            // 
            this.textBoxCommentaireDeclaration.Location = new System.Drawing.Point(184, 76);
            this.textBoxCommentaireDeclaration.Name = "textBoxCommentaireDeclaration";
            this.textBoxCommentaireDeclaration.Size = new System.Drawing.Size(341, 20);
            this.textBoxCommentaireDeclaration.TabIndex = 3;
            // 
            // checkBoxUrgence
            // 
            this.checkBoxUrgence.AutoSize = true;
            this.checkBoxUrgence.Location = new System.Drawing.Point(184, 119);
            this.checkBoxUrgence.Name = "checkBoxUrgence";
            this.checkBoxUrgence.Size = new System.Drawing.Size(15, 14);
            this.checkBoxUrgence.TabIndex = 5;
            this.checkBoxUrgence.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDateDeclaration
            // 
            this.dateTimePickerDateDeclaration.Location = new System.Drawing.Point(184, 179);
            this.dateTimePickerDateDeclaration.Name = "dateTimePickerDateDeclaration";
            this.dateTimePickerDateDeclaration.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDateDeclaration.TabIndex = 6;
            this.dateTimePickerDateDeclaration.Visible = false;
            // 
            // buttonModificationDeclaration
            // 
            this.buttonModificationDeclaration.Location = new System.Drawing.Point(450, 270);
            this.buttonModificationDeclaration.Name = "buttonModificationDeclaration";
            this.buttonModificationDeclaration.Size = new System.Drawing.Size(75, 23);
            this.buttonModificationDeclaration.TabIndex = 7;
            this.buttonModificationDeclaration.Text = "Valider Modification";
            this.buttonModificationDeclaration.UseVisualStyleBackColor = true;
            this.buttonModificationDeclaration.Click += new System.EventHandler(this.buttonModificationDeclaration_Click);
            // 
            // buttonAnnulationDeclaration
            // 
            this.buttonAnnulationDeclaration.Location = new System.Drawing.Point(34, 270);
            this.buttonAnnulationDeclaration.Name = "buttonAnnulationDeclaration";
            this.buttonAnnulationDeclaration.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnulationDeclaration.TabIndex = 8;
            this.buttonAnnulationDeclaration.Text = "Annuler Modification";
            this.buttonAnnulationDeclaration.UseVisualStyleBackColor = true;
            this.buttonAnnulationDeclaration.Click += new System.EventHandler(this.buttonAnnulationDeclaration_Click);
            // 
            // FormModificationDeclaration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAnnulationDeclaration);
            this.Controls.Add(this.buttonModificationDeclaration);
            this.Controls.Add(this.dateTimePickerDateDeclaration);
            this.Controls.Add(this.checkBoxUrgence);
            this.Controls.Add(this.textBoxCommentaireDeclaration);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FormModificationDeclaration";
            this.Text = "FormModificationDeclaration";
            this.Load += new System.EventHandler(this.FormModificationDeclaration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCommentaireDeclaration;
        private System.Windows.Forms.CheckBox checkBoxUrgence;
        private System.Windows.Forms.Button buttonModificationDeclaration;
        private System.Windows.Forms.Button buttonAnnulationDeclaration;
        protected System.Windows.Forms.DateTimePicker dateTimePickerDateDeclaration;
    }
}