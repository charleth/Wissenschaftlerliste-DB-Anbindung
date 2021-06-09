
namespace Wissenschaftlerliste
{
    partial class Hauptfenster
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
            this.listBoxWissenschaftler = new System.Windows.Forms.ListBox();
            this.buttonLoeschen = new System.Windows.Forms.Button();
            this.textBoxVornameEingeben = new System.Windows.Forms.TextBox();
            this.textBoxNachnameEingeben = new System.Windows.Forms.TextBox();
            this.numericUpDownGeburtsjahr = new System.Windows.Forms.NumericUpDown();
            this.buttonSpeichern = new System.Windows.Forms.Button();
            this.labelVorname = new System.Windows.Forms.Label();
            this.labelNachname = new System.Windows.Forms.Label();
            this.labelGeburtsjahr = new System.Windows.Forms.Label();
            this.labelFachrichtungEingeben = new System.Windows.Forms.Label();
            this.textBoxFachrichtungEingeben = new System.Windows.Forms.TextBox();
            this.buttonBearbeiten = new System.Windows.Forms.Button();
            this.buttonAbbrechen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGeburtsjahr)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxWissenschaftler
            // 
            this.listBoxWissenschaftler.FormattingEnabled = true;
            this.listBoxWissenschaftler.Location = new System.Drawing.Point(12, 20);
            this.listBoxWissenschaftler.Name = "listBoxWissenschaftler";
            this.listBoxWissenschaftler.Size = new System.Drawing.Size(274, 394);
            this.listBoxWissenschaftler.TabIndex = 0;
            // 
            // buttonLoeschen
            // 
            this.buttonLoeschen.Location = new System.Drawing.Point(292, 343);
            this.buttonLoeschen.Name = "buttonLoeschen";
            this.buttonLoeschen.Size = new System.Drawing.Size(75, 23);
            this.buttonLoeschen.TabIndex = 1;
            this.buttonLoeschen.Text = "Löschen";
            this.buttonLoeschen.UseVisualStyleBackColor = true;
            this.buttonLoeschen.Click += new System.EventHandler(this.buttonLoeschen_Click);
            // 
            // textBoxVornameEingeben
            // 
            this.textBoxVornameEingeben.Location = new System.Drawing.Point(292, 39);
            this.textBoxVornameEingeben.Name = "textBoxVornameEingeben";
            this.textBoxVornameEingeben.Size = new System.Drawing.Size(100, 20);
            this.textBoxVornameEingeben.TabIndex = 2;
            // 
            // textBoxNachnameEingeben
            // 
            this.textBoxNachnameEingeben.Location = new System.Drawing.Point(292, 95);
            this.textBoxNachnameEingeben.Name = "textBoxNachnameEingeben";
            this.textBoxNachnameEingeben.Size = new System.Drawing.Size(100, 20);
            this.textBoxNachnameEingeben.TabIndex = 3;
            // 
            // numericUpDownGeburtsjahr
            // 
            this.numericUpDownGeburtsjahr.Location = new System.Drawing.Point(292, 151);
            this.numericUpDownGeburtsjahr.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDownGeburtsjahr.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            -2147483648});
            this.numericUpDownGeburtsjahr.Name = "numericUpDownGeburtsjahr";
            this.numericUpDownGeburtsjahr.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownGeburtsjahr.TabIndex = 4;
            // 
            // buttonSpeichern
            // 
            this.buttonSpeichern.Location = new System.Drawing.Point(292, 259);
            this.buttonSpeichern.Name = "buttonSpeichern";
            this.buttonSpeichern.Size = new System.Drawing.Size(75, 23);
            this.buttonSpeichern.TabIndex = 5;
            this.buttonSpeichern.Text = "Hinzufügen";
            this.buttonSpeichern.UseVisualStyleBackColor = true;
            this.buttonSpeichern.Click += new System.EventHandler(this.buttonSpeichern_Click);
            // 
            // labelVorname
            // 
            this.labelVorname.AutoSize = true;
            this.labelVorname.Location = new System.Drawing.Point(292, 20);
            this.labelVorname.Name = "labelVorname";
            this.labelVorname.Size = new System.Drawing.Size(49, 13);
            this.labelVorname.TabIndex = 6;
            this.labelVorname.Text = "Vorname";
            // 
            // labelNachname
            // 
            this.labelNachname.AutoSize = true;
            this.labelNachname.Location = new System.Drawing.Point(292, 76);
            this.labelNachname.Name = "labelNachname";
            this.labelNachname.Size = new System.Drawing.Size(59, 13);
            this.labelNachname.TabIndex = 7;
            this.labelNachname.Text = "Nachname";
            // 
            // labelGeburtsjahr
            // 
            this.labelGeburtsjahr.AutoSize = true;
            this.labelGeburtsjahr.Location = new System.Drawing.Point(292, 129);
            this.labelGeburtsjahr.Name = "labelGeburtsjahr";
            this.labelGeburtsjahr.Size = new System.Drawing.Size(61, 13);
            this.labelGeburtsjahr.TabIndex = 8;
            this.labelGeburtsjahr.Text = "Geburtsjahr";
            // 
            // labelFachrichtungEingeben
            // 
            this.labelFachrichtungEingeben.AutoSize = true;
            this.labelFachrichtungEingeben.Location = new System.Drawing.Point(292, 191);
            this.labelFachrichtungEingeben.Name = "labelFachrichtungEingeben";
            this.labelFachrichtungEingeben.Size = new System.Drawing.Size(69, 13);
            this.labelFachrichtungEingeben.TabIndex = 9;
            this.labelFachrichtungEingeben.Text = "Fachrichtung";
            // 
            // textBoxFachrichtungEingeben
            // 
            this.textBoxFachrichtungEingeben.Location = new System.Drawing.Point(292, 217);
            this.textBoxFachrichtungEingeben.Name = "textBoxFachrichtungEingeben";
            this.textBoxFachrichtungEingeben.Size = new System.Drawing.Size(100, 20);
            this.textBoxFachrichtungEingeben.TabIndex = 10;
            // 
            // buttonBearbeiten
            // 
            this.buttonBearbeiten.Location = new System.Drawing.Point(292, 301);
            this.buttonBearbeiten.Name = "buttonBearbeiten";
            this.buttonBearbeiten.Size = new System.Drawing.Size(75, 23);
            this.buttonBearbeiten.TabIndex = 11;
            this.buttonBearbeiten.Text = "Bearbeiten";
            this.buttonBearbeiten.UseVisualStyleBackColor = true;
            this.buttonBearbeiten.Click += new System.EventHandler(this.buttonBearbeiten_Click);
            // 
            // buttonAbbrechen
            // 
            this.buttonAbbrechen.Enabled = false;
            this.buttonAbbrechen.Location = new System.Drawing.Point(373, 301);
            this.buttonAbbrechen.Name = "buttonAbbrechen";
            this.buttonAbbrechen.Size = new System.Drawing.Size(75, 23);
            this.buttonAbbrechen.TabIndex = 12;
            this.buttonAbbrechen.Text = "Abbrechen";
            this.buttonAbbrechen.UseVisualStyleBackColor = true;
            this.buttonAbbrechen.Click += new System.EventHandler(this.buttonAbbrechen_Click);
            // 
            // Hauptfenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 434);
            this.Controls.Add(this.buttonAbbrechen);
            this.Controls.Add(this.buttonBearbeiten);
            this.Controls.Add(this.textBoxFachrichtungEingeben);
            this.Controls.Add(this.labelFachrichtungEingeben);
            this.Controls.Add(this.labelGeburtsjahr);
            this.Controls.Add(this.labelNachname);
            this.Controls.Add(this.labelVorname);
            this.Controls.Add(this.buttonSpeichern);
            this.Controls.Add(this.numericUpDownGeburtsjahr);
            this.Controls.Add(this.textBoxNachnameEingeben);
            this.Controls.Add(this.textBoxVornameEingeben);
            this.Controls.Add(this.buttonLoeschen);
            this.Controls.Add(this.listBoxWissenschaftler);
            this.Name = "Hauptfenster";
            this.Text = "Wissenschaftlerliste";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGeburtsjahr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxWissenschaftler;
        private System.Windows.Forms.Button buttonLoeschen;
        private System.Windows.Forms.TextBox textBoxVornameEingeben;
        private System.Windows.Forms.TextBox textBoxNachnameEingeben;
        private System.Windows.Forms.NumericUpDown numericUpDownGeburtsjahr;
        private System.Windows.Forms.Button buttonSpeichern;
        private System.Windows.Forms.Label labelVorname;
        private System.Windows.Forms.Label labelNachname;
        private System.Windows.Forms.Label labelGeburtsjahr;
        private System.Windows.Forms.Label labelFachrichtungEingeben;
        private System.Windows.Forms.TextBox textBoxFachrichtungEingeben;
        private System.Windows.Forms.Button buttonBearbeiten;
        private System.Windows.Forms.Button buttonAbbrechen;
    }
}

