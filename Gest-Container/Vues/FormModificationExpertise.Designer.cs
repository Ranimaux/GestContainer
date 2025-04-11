
namespace GestContainer.Vues
{
    partial class FormModificationExpertise
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
            this.textBoxcommentaireConstatation = new System.Windows.Forms.TextBox();
            this.textBoxContactResponsable = new System.Windows.Forms.TextBox();
            this.dateTimeDateConstat = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewListDeclaration = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonValModif = new System.Windows.Forms.Button();
            this.buttonCancelModif = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListDeclaration)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date de Constation des dommages";
            // 
            // textBoxcommentaireConstatation
            // 
            this.textBoxcommentaireConstatation.Location = new System.Drawing.Point(35, 159);
            this.textBoxcommentaireConstatation.Name = "textBoxcommentaireConstatation";
            this.textBoxcommentaireConstatation.Size = new System.Drawing.Size(406, 20);
            this.textBoxcommentaireConstatation.TabIndex = 1;
            // 
            // textBoxContactResponsable
            // 
            this.textBoxContactResponsable.Location = new System.Drawing.Point(35, 224);
            this.textBoxContactResponsable.Name = "textBoxContactResponsable";
            this.textBoxContactResponsable.Size = new System.Drawing.Size(406, 20);
            this.textBoxContactResponsable.TabIndex = 2;
            // 
            // dateTimeDateConstat
            // 
            this.dateTimeDateConstat.Location = new System.Drawing.Point(35, 86);
            this.dateTimeDateConstat.Name = "dateTimeDateConstat";
            this.dateTimeDateConstat.Size = new System.Drawing.Size(200, 20);
            this.dateTimeDateConstat.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Commentaire constation préliminaires";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contact du Responsable";
            // 
            // dataGridViewListDeclaration
            // 
            this.dataGridViewListDeclaration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListDeclaration.Location = new System.Drawing.Point(35, 299);
            this.dataGridViewListDeclaration.Name = "dataGridViewListDeclaration";
            this.dataGridViewListDeclaration.Size = new System.Drawing.Size(637, 338);
            this.dataGridViewListDeclaration.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "La Déclaration Incident";
            // 
            // buttonValModif
            // 
            this.buttonValModif.Location = new System.Drawing.Point(933, 576);
            this.buttonValModif.Name = "buttonValModif";
            this.buttonValModif.Size = new System.Drawing.Size(129, 23);
            this.buttonValModif.TabIndex = 8;
            this.buttonValModif.Text = "Valider Modification";
            this.buttonValModif.UseVisualStyleBackColor = true;
            this.buttonValModif.Click += new System.EventHandler(this.buttonValModif_Click);
            // 
            // buttonCancelModif
            // 
            this.buttonCancelModif.Location = new System.Drawing.Point(708, 576);
            this.buttonCancelModif.Name = "buttonCancelModif";
            this.buttonCancelModif.Size = new System.Drawing.Size(117, 23);
            this.buttonCancelModif.TabIndex = 9;
            this.buttonCancelModif.Text = "Annuler Modification";
            this.buttonCancelModif.UseVisualStyleBackColor = true;
            this.buttonCancelModif.Click += new System.EventHandler(this.buttonCancelModif_Click);
            // 
            // FormModificationExpertise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1105, 672);
            this.Controls.Add(this.buttonCancelModif);
            this.Controls.Add(this.buttonValModif);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewListDeclaration);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimeDateConstat);
            this.Controls.Add(this.textBoxContactResponsable);
            this.Controls.Add(this.textBoxcommentaireConstatation);
            this.Controls.Add(this.label1);
            this.Name = "FormModificationExpertise";
            this.Text = "FormModificationExpertise";
            this.Load += new System.EventHandler(this.FormModificationExpertise_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListDeclaration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxcommentaireConstatation;
        private System.Windows.Forms.TextBox textBoxContactResponsable;
        private System.Windows.Forms.DateTimePicker dateTimeDateConstat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewListDeclaration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonValModif;
        private System.Windows.Forms.Button buttonCancelModif;
    }
}