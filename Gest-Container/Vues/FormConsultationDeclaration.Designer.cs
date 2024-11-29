
namespace GestContainer.Vues
{
    partial class FormConsultationDeclaration
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonModification = new System.Windows.Forms.Button();
            this.dataGridViewListDeclaration = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListDeclaration)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonModification);
            this.groupBox1.Controls.Add(this.dataGridViewListDeclaration);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 426);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Liste des déclarations";
            // 
            // buttonModification
            // 
            this.buttonModification.Location = new System.Drawing.Point(607, 328);
            this.buttonModification.Name = "buttonModification";
            this.buttonModification.Size = new System.Drawing.Size(130, 23);
            this.buttonModification.TabIndex = 1;
            this.buttonModification.Text = "Modifier une Déclaration";
            this.buttonModification.UseVisualStyleBackColor = true;
            this.buttonModification.Click += new System.EventHandler(this.buttonModification_Click);
            // 
            // dataGridViewListDeclaration
            // 
            this.dataGridViewListDeclaration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListDeclaration.Location = new System.Drawing.Point(22, 31);
            this.dataGridViewListDeclaration.Name = "dataGridViewListDeclaration";
            this.dataGridViewListDeclaration.Size = new System.Drawing.Size(656, 266);
            this.dataGridViewListDeclaration.TabIndex = 0;
            // 
            // FormConsultationDeclaration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormConsultationDeclaration";
            this.Text = "Consultation Déclaration";
            this.Load += new System.EventHandler(this.FormConsultationDeclaration_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListDeclaration)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonModification;
        private System.Windows.Forms.DataGridView dataGridViewListDeclaration;
    }
}