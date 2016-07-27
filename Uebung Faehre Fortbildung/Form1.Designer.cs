namespace Uebung_Faehre_Fortbildung
{
    partial class Formfaehre
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonFahreugeaufnehmen = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonfaehreneu = new System.Windows.Forms.Button();
            this.textBoxlaenge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxbaujahr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxfaehrename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelmeldung = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonFahreugeaufnehmen
            // 
            this.buttonFahreugeaufnehmen.Location = new System.Drawing.Point(64, 43);
            this.buttonFahreugeaufnehmen.Name = "buttonFahreugeaufnehmen";
            this.buttonFahreugeaufnehmen.Size = new System.Drawing.Size(212, 41);
            this.buttonFahreugeaufnehmen.TabIndex = 0;
            this.buttonFahreugeaufnehmen.Text = "Fahrzeuge aufnehmen";
            this.buttonFahreugeaufnehmen.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonfaehreneu);
            this.groupBox1.Controls.Add(this.textBoxlaenge);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxbaujahr);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxfaehrename);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(73, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 213);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Daten Faehre";
            // 
            // buttonfaehreneu
            // 
            this.buttonfaehreneu.Location = new System.Drawing.Point(0, 146);
            this.buttonfaehreneu.Name = "buttonfaehreneu";
            this.buttonfaehreneu.Size = new System.Drawing.Size(196, 31);
            this.buttonfaehreneu.TabIndex = 2;
            this.buttonfaehreneu.Text = "neue Fähre";
            this.buttonfaehreneu.UseVisualStyleBackColor = true;
            this.buttonfaehreneu.Click += new System.EventHandler(this.buttonfaehreneu_Click);
            // 
            // textBoxlaenge
            // 
            this.textBoxlaenge.Location = new System.Drawing.Point(92, 99);
            this.textBoxlaenge.Name = "textBoxlaenge";
            this.textBoxlaenge.Size = new System.Drawing.Size(83, 20);
            this.textBoxlaenge.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Länge";
            // 
            // textBoxbaujahr
            // 
            this.textBoxbaujahr.Location = new System.Drawing.Point(92, 62);
            this.textBoxbaujahr.Name = "textBoxbaujahr";
            this.textBoxbaujahr.Size = new System.Drawing.Size(83, 20);
            this.textBoxbaujahr.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Baujahr";
            // 
            // textBoxfaehrename
            // 
            this.textBoxfaehrename.Location = new System.Drawing.Point(92, 29);
            this.textBoxfaehrename.Name = "textBoxfaehrename";
            this.textBoxfaehrename.Size = new System.Drawing.Size(83, 20);
            this.textBoxfaehrename.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelmeldung});
            this.statusStrip1.Location = new System.Drawing.Point(0, 633);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1196, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelmeldung
            // 
            this.toolStripStatusLabelmeldung.Name = "toolStripStatusLabelmeldung";
            this.toolStripStatusLabelmeldung.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabelmeldung.Text = "toolStripStatusLabel1";
            // 
            // Formfaehre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 655);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonFahreugeaufnehmen);
            this.Name = "Formfaehre";
            this.Text = "Fahrzeugeverwaltung";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFahreugeaufnehmen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonfaehreneu;
        private System.Windows.Forms.TextBox textBoxlaenge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxbaujahr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxfaehrename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelmeldung;
    }
}

