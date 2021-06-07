
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
            this.SuspendLayout();
            // 
            // listBoxWissenschaftler
            // 
            this.listBoxWissenschaftler.FormattingEnabled = true;
            this.listBoxWissenschaftler.Location = new System.Drawing.Point(47, 24);
            this.listBoxWissenschaftler.Name = "listBoxWissenschaftler";
            this.listBoxWissenschaftler.Size = new System.Drawing.Size(212, 316);
            this.listBoxWissenschaftler.TabIndex = 0;
            // 
            // Hauptfenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 388);
            this.Controls.Add(this.listBoxWissenschaftler);
            this.Name = "Hauptfenster";
            this.Text = "Wissenschaftlerliste";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxWissenschaftler;
    }
}

