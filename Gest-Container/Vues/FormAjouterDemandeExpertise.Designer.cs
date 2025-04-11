
namespace GestContainer.Vues
{
    partial class FormAjouterDemandeExpertise
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
            this.dateTimeDateConstat = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCommentaireConstatation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxContactResponsable = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewListDeclaration = new System.Windows.Forms.DataGridView();
            this.buttonDemandeExpertise = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListDeclaration)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date de Constat des dommage";
            // 
            // dateTimeDateConstat
            // 
            this.dateTimeDateConstat.Location = new System.Drawing.Point(37, 46);
            this.dateTimeDateConstat.Name = "dateTimeDateConstat";
            this.dateTimeDateConstat.Size = new System.Drawing.Size(177, 20);
            this.dateTimeDateConstat.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Commentaire constation préliminaires";
            // 
            // textBoxCommentaireConstatation
            // 
            this.textBoxCommentaireConstatation.Location = new System.Drawing.Point(37, 120);
            this.textBoxCommentaireConstatation.Name = "textBoxCommentaireConstatation";
            this.textBoxCommentaireConstatation.Size = new System.Drawing.Size(328, 20);
            this.textBoxCommentaireConstatation.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contact du Responsable";
            // 
            // textBoxContactResponsable
            // 
            this.textBoxContactResponsable.Location = new System.Drawing.Point(37, 188);
            this.textBoxContactResponsable.Name = "textBoxContactResponsable";
            this.textBoxContactResponsable.Size = new System.Drawing.Size(328, 20);
            this.textBoxContactResponsable.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "La Déclaration Incident";
            // 
            // dataGridViewListDeclaration
            // 
            this.dataGridViewListDeclaration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListDeclaration.Location = new System.Drawing.Point(37, 253);
            this.dataGridViewListDeclaration.Name = "dataGridViewListDeclaration";
            this.dataGridViewListDeclaration.Size = new System.Drawing.Size(525, 195);
            this.dataGridViewListDeclaration.TabIndex = 7;
            // 
            // buttonDemandeExpertise
            // 
            this.buttonDemandeExpertise.Location = new System.Drawing.Point(604, 253);
            this.buttonDemandeExpertise.Name = "buttonDemandeExpertise";
            this.buttonDemandeExpertise.Size = new System.Drawing.Size(184, 23);
            this.buttonDemandeExpertise.TabIndex = 8;
            this.buttonDemandeExpertise.Text = "Envoyer la demande";
            this.buttonDemandeExpertise.UseVisualStyleBackColor = true;
            this.buttonDemandeExpertise.Click += new System.EventHandler(this.buttonDemandeExpertise_Click);
            // 
            // FormAjouterDemandeExpertise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.buttonDemandeExpertise);
            this.Controls.Add(this.dataGridViewListDeclaration);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxContactResponsable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCommentaireConstatation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimeDateConstat);
            this.Controls.Add(this.label1);
            this.Name = "FormAjouterDemandeExpertise";
            this.Text = "Demande d\'une Expertise";
            this.Load += new System.EventHandler(this.FormAjouterDemandeExpertise_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListDeclaration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeDateConstat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCommentaireConstatation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxContactResponsable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewListDeclaration;
        private System.Windows.Forms.Button buttonDemandeExpertise;
    }
}