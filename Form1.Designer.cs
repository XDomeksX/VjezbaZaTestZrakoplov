namespace VjezbaZaTestZrakoplov
{
    partial class Form1
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
            this.CMBvrsta = new System.Windows.Forms.ComboBox();
            this.BTNupisi = new System.Windows.Forms.Button();
            this.BTNispisi = new System.Windows.Forms.Button();
            this.DTPgod = new System.Windows.Forms.DateTimePicker();
            this.RTBispis = new System.Windows.Forms.RichTextBox();
            this.LBLvrsta = new System.Windows.Forms.Label();
            this.TXTime = new System.Windows.Forms.TextBox();
            this.LBLime = new System.Windows.Forms.Label();
            this.TRBbrzina = new System.Windows.Forms.TrackBar();
            this.LBLgod = new System.Windows.Forms.Label();
            this.LBLbrzina = new System.Windows.Forms.Label();
            this.CHBda = new System.Windows.Forms.CheckBox();
            this.LBLaerodinamika = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TRBbrzina)).BeginInit();
            this.SuspendLayout();
            // 
            // CMBvrsta
            // 
            this.CMBvrsta.FormattingEnabled = true;
            this.CMBvrsta.Items.AddRange(new object[] {
            "helikopter parakopter",
            "parakopterus",
            "čopa"});
            this.CMBvrsta.Location = new System.Drawing.Point(12, 39);
            this.CMBvrsta.Name = "CMBvrsta";
            this.CMBvrsta.Size = new System.Drawing.Size(121, 21);
            this.CMBvrsta.TabIndex = 0;
            // 
            // BTNupisi
            // 
            this.BTNupisi.Location = new System.Drawing.Point(822, 29);
            this.BTNupisi.Name = "BTNupisi";
            this.BTNupisi.Size = new System.Drawing.Size(287, 140);
            this.BTNupisi.TabIndex = 1;
            this.BTNupisi.Text = "Upisi";
            this.BTNupisi.UseVisualStyleBackColor = true;
            this.BTNupisi.Click += new System.EventHandler(this.BTNupisi_Click);
            // 
            // BTNispisi
            // 
            this.BTNispisi.Location = new System.Drawing.Point(822, 226);
            this.BTNispisi.Name = "BTNispisi";
            this.BTNispisi.Size = new System.Drawing.Size(287, 140);
            this.BTNispisi.TabIndex = 2;
            this.BTNispisi.Text = "Ispisi";
            this.BTNispisi.UseVisualStyleBackColor = true;
            this.BTNispisi.Click += new System.EventHandler(this.BTNispisi_Click);
            // 
            // DTPgod
            // 
            this.DTPgod.Location = new System.Drawing.Point(12, 149);
            this.DTPgod.Name = "DTPgod";
            this.DTPgod.Size = new System.Drawing.Size(200, 20);
            this.DTPgod.TabIndex = 3;
            // 
            // RTBispis
            // 
            this.RTBispis.Location = new System.Drawing.Point(269, 29);
            this.RTBispis.Name = "RTBispis";
            this.RTBispis.Size = new System.Drawing.Size(494, 337);
            this.RTBispis.TabIndex = 4;
            this.RTBispis.Text = "";
            // 
            // LBLvrsta
            // 
            this.LBLvrsta.AutoSize = true;
            this.LBLvrsta.Location = new System.Drawing.Point(12, 20);
            this.LBLvrsta.Name = "LBLvrsta";
            this.LBLvrsta.Size = new System.Drawing.Size(89, 13);
            this.LBLvrsta.TabIndex = 5;
            this.LBLvrsta.Text = "Vrsta zrakoplova:";
            // 
            // TXTime
            // 
            this.TXTime.Location = new System.Drawing.Point(12, 93);
            this.TXTime.Name = "TXTime";
            this.TXTime.Size = new System.Drawing.Size(100, 20);
            this.TXTime.TabIndex = 6;
            // 
            // LBLime
            // 
            this.LBLime.AutoSize = true;
            this.LBLime.Location = new System.Drawing.Point(12, 77);
            this.LBLime.Name = "LBLime";
            this.LBLime.Size = new System.Drawing.Size(82, 13);
            this.LBLime.TabIndex = 7;
            this.LBLime.Text = "Ime zrakoplova:";
            // 
            // TRBbrzina
            // 
            this.TRBbrzina.LargeChange = 10;
            this.TRBbrzina.Location = new System.Drawing.Point(363, 429);
            this.TRBbrzina.Maximum = 400;
            this.TRBbrzina.Minimum = 60;
            this.TRBbrzina.Name = "TRBbrzina";
            this.TRBbrzina.Size = new System.Drawing.Size(320, 45);
            this.TRBbrzina.SmallChange = 10;
            this.TRBbrzina.TabIndex = 8;
            this.TRBbrzina.Value = 60;
            // 
            // LBLgod
            // 
            this.LBLgod.AutoSize = true;
            this.LBLgod.Location = new System.Drawing.Point(15, 133);
            this.LBLgod.Name = "LBLgod";
            this.LBLgod.Size = new System.Drawing.Size(90, 13);
            this.LBLgod.TabIndex = 9;
            this.LBLgod.Text = "God. proizvodnje:";
            // 
            // LBLbrzina
            // 
            this.LBLbrzina.AutoSize = true;
            this.LBLbrzina.Location = new System.Drawing.Point(501, 396);
            this.LBLbrzina.Name = "LBLbrzina";
            this.LBLbrzina.Size = new System.Drawing.Size(39, 13);
            this.LBLbrzina.TabIndex = 10;
            this.LBLbrzina.Text = "Brzina:";
            // 
            // CHBda
            // 
            this.CHBda.AutoSize = true;
            this.CHBda.Location = new System.Drawing.Point(12, 212);
            this.CHBda.Name = "CHBda";
            this.CHBda.Size = new System.Drawing.Size(41, 17);
            this.CHBda.TabIndex = 11;
            this.CHBda.Text = "DA";
            this.CHBda.UseVisualStyleBackColor = true;
            // 
            // LBLaerodinamika
            // 
            this.LBLaerodinamika.AutoSize = true;
            this.LBLaerodinamika.Location = new System.Drawing.Point(15, 193);
            this.LBLaerodinamika.Name = "LBLaerodinamika";
            this.LBLaerodinamika.Size = new System.Drawing.Size(77, 13);
            this.LBLaerodinamika.TabIndex = 13;
            this.LBLaerodinamika.Text = "Aerodinamika?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 501);
            this.Controls.Add(this.LBLaerodinamika);
            this.Controls.Add(this.CHBda);
            this.Controls.Add(this.LBLbrzina);
            this.Controls.Add(this.LBLgod);
            this.Controls.Add(this.TRBbrzina);
            this.Controls.Add(this.LBLime);
            this.Controls.Add(this.TXTime);
            this.Controls.Add(this.LBLvrsta);
            this.Controls.Add(this.RTBispis);
            this.Controls.Add(this.DTPgod);
            this.Controls.Add(this.BTNispisi);
            this.Controls.Add(this.BTNupisi);
            this.Controls.Add(this.CMBvrsta);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TRBbrzina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CMBvrsta;
        private System.Windows.Forms.Button BTNupisi;
        private System.Windows.Forms.Button BTNispisi;
        private System.Windows.Forms.DateTimePicker DTPgod;
        private System.Windows.Forms.RichTextBox RTBispis;
        private System.Windows.Forms.Label LBLvrsta;
        private System.Windows.Forms.TextBox TXTime;
        private System.Windows.Forms.Label LBLime;
        private System.Windows.Forms.TrackBar TRBbrzina;
        private System.Windows.Forms.Label LBLgod;
        private System.Windows.Forms.Label LBLbrzina;
        private System.Windows.Forms.CheckBox CHBda;
        private System.Windows.Forms.Label LBLaerodinamika;
    }
}

