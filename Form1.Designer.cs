namespace BackupWinForm
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.OrigineButt = new System.Windows.Forms.Button();
            this.DestinazioneButt = new System.Windows.Forms.Button();
            this.DestinazioneBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.origineBox = new System.Windows.Forms.TextBox();
            this.destinazioneBox = new System.Windows.Forms.TextBox();
            this.CopiaButt = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OrigineButt
            // 
            this.OrigineButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrigineButt.Location = new System.Drawing.Point(21, 61);
            this.OrigineButt.Name = "OrigineButt";
            this.OrigineButt.Size = new System.Drawing.Size(190, 58);
            this.OrigineButt.TabIndex = 1;
            this.OrigineButt.Text = "Origine";
            this.OrigineButt.UseVisualStyleBackColor = true;
            this.OrigineButt.Click += new System.EventHandler(this.OrigineButt_Click);
            // 
            // DestinazioneButt
            // 
            this.DestinazioneButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestinazioneButt.Location = new System.Drawing.Point(21, 208);
            this.DestinazioneButt.Name = "DestinazioneButt";
            this.DestinazioneButt.Size = new System.Drawing.Size(190, 58);
            this.DestinazioneButt.TabIndex = 1;
            this.DestinazioneButt.Text = "Destinazione";
            this.DestinazioneButt.UseVisualStyleBackColor = true;
            this.DestinazioneButt.Click += new System.EventHandler(this.DestinazioneButt_Click);
            // 
            // origineBox
            // 
            this.origineBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.origineBox.Location = new System.Drawing.Point(239, 99);
            this.origineBox.Name = "origineBox";
            this.origineBox.Size = new System.Drawing.Size(432, 20);
            this.origineBox.TabIndex = 2;
            // 
            // destinazioneBox
            // 
            this.destinazioneBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.destinazioneBox.Location = new System.Drawing.Point(239, 246);
            this.destinazioneBox.Name = "destinazioneBox";
            this.destinazioneBox.Size = new System.Drawing.Size(432, 20);
            this.destinazioneBox.TabIndex = 2;
            // 
            // CopiaButt
            // 
            this.CopiaButt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CopiaButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopiaButt.Location = new System.Drawing.Point(450, 335);
            this.CopiaButt.Name = "CopiaButt";
            this.CopiaButt.Size = new System.Drawing.Size(221, 49);
            this.CopiaButt.TabIndex = 3;
            this.CopiaButt.Text = "Esegui Backup";
            this.CopiaButt.UseVisualStyleBackColor = true;
            this.CopiaButt.Click += new System.EventHandler(this.CopiaButt_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorBox
            // 
            this.errorBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.errorBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.errorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorBox.Location = new System.Drawing.Point(21, 358);
            this.errorBox.Name = "errorBox";
            this.errorBox.ReadOnly = true;
            this.errorBox.Size = new System.Drawing.Size(291, 19);
            this.errorBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 461);
            this.Controls.Add(this.errorBox);
            this.Controls.Add(this.CopiaButt);
            this.Controls.Add(this.destinazioneBox);
            this.Controls.Add(this.origineBox);
            this.Controls.Add(this.DestinazioneButt);
            this.Controls.Add(this.OrigineButt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1000, 500);
            this.MinimumSize = new System.Drawing.Size(730, 500);
            this.Name = "Form1";
            this.Text = "Backup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button OrigineButt;
        private System.Windows.Forms.Button DestinazioneButt;
        private System.Windows.Forms.FolderBrowserDialog DestinazioneBrowser;
        private System.Windows.Forms.TextBox origineBox;
        private System.Windows.Forms.TextBox destinazioneBox;
        private System.Windows.Forms.Button CopiaButt;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox errorBox;
    }
}

