namespace Bonjour
{
    partial class Hello
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
            this.lblPrn = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtPrn = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.Valider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrn
            // 
            this.lblPrn.AutoSize = true;
            this.lblPrn.Location = new System.Drawing.Point(84, 51);
            this.lblPrn.Name = "lblPrn";
            this.lblPrn.Size = new System.Drawing.Size(43, 13);
            this.lblPrn.TabIndex = 0;
            this.lblPrn.Text = "Prenom";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(84, 103);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom";
            this.lblNom.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtPrn
            // 
            this.txtPrn.Location = new System.Drawing.Point(201, 48);
            this.txtPrn.Name = "txtPrn";
            this.txtPrn.Size = new System.Drawing.Size(100, 20);
            this.txtPrn.TabIndex = 2;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(201, 100);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 3;
            // 
            // Valider
            // 
            this.Valider.Location = new System.Drawing.Point(226, 173);
            this.Valider.Name = "Valider";
            this.Valider.Size = new System.Drawing.Size(75, 23);
            this.Valider.TabIndex = 4;
            this.Valider.Text = "Valider";
            this.Valider.UseVisualStyleBackColor = true;
            this.Valider.Click += new System.EventHandler(this.Valider_Click);
            // 
            // Hello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Valider);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtPrn);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblPrn);
            this.Name = "Hello";
            this.Text = "Hello";
            this.Load += new System.EventHandler(this.Hello_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrn;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtPrn;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Button Valider;
    }
}