namespace ApartmanOtomasyon2
{
    partial class Giderler
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
            this.chkElektrik = new System.Windows.Forms.CheckBox();
            this.chkSu = new System.Windows.Forms.CheckBox();
            this.chkAsansor = new System.Windows.Forms.CheckBox();
            this.chkTemizlik = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nrcTutar = new System.Windows.Forms.NumericUpDown();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.btnEkle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstGiderler = new System.Windows.Forms.ListBox();
            this.lstTutar = new System.Windows.Forms.ListBox();
            this.lstTarih = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nrcTutar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkElektrik
            // 
            this.chkElektrik.AutoSize = true;
            this.chkElektrik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkElektrik.Location = new System.Drawing.Point(16, 30);
            this.chkElektrik.Name = "chkElektrik";
            this.chkElektrik.Size = new System.Drawing.Size(105, 29);
            this.chkElektrik.TabIndex = 0;
            this.chkElektrik.Text = "Elektrik";
            this.chkElektrik.UseVisualStyleBackColor = true;
            // 
            // chkSu
            // 
            this.chkSu.AutoSize = true;
            this.chkSu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkSu.Location = new System.Drawing.Point(16, 65);
            this.chkSu.Name = "chkSu";
            this.chkSu.Size = new System.Drawing.Size(61, 29);
            this.chkSu.TabIndex = 1;
            this.chkSu.Text = "Su";
            this.chkSu.UseVisualStyleBackColor = true;
            // 
            // chkAsansor
            // 
            this.chkAsansor.AutoSize = true;
            this.chkAsansor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkAsansor.Location = new System.Drawing.Point(16, 100);
            this.chkAsansor.Name = "chkAsansor";
            this.chkAsansor.Size = new System.Drawing.Size(114, 29);
            this.chkAsansor.TabIndex = 2;
            this.chkAsansor.Text = "Asansör";
            this.chkAsansor.UseVisualStyleBackColor = true;
            // 
            // chkTemizlik
            // 
            this.chkTemizlik.AutoSize = true;
            this.chkTemizlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkTemizlik.Location = new System.Drawing.Point(16, 135);
            this.chkTemizlik.Name = "chkTemizlik";
            this.chkTemizlik.Size = new System.Drawing.Size(114, 29);
            this.chkTemizlik.TabIndex = 3;
            this.chkTemizlik.Text = "Temizlik";
            this.chkTemizlik.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(253, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tutar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(253, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tarih:";
            // 
            // nrcTutar
            // 
            this.nrcTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nrcTutar.Location = new System.Drawing.Point(384, 35);
            this.nrcTutar.Name = "nrcTutar";
            this.nrcTutar.Size = new System.Drawing.Size(243, 27);
            this.nrcTutar.TabIndex = 6;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpTarih.Location = new System.Drawing.Point(384, 92);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(243, 27);
            this.dtpTarih.TabIndex = 7;
            // 
            // btnEkle
            // 
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Location = new System.Drawing.Point(442, 175);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(185, 53);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkElektrik);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.chkSu);
            this.groupBox1.Controls.Add(this.dtpTarih);
            this.groupBox1.Controls.Add(this.chkAsansor);
            this.groupBox1.Controls.Add(this.nrcTutar);
            this.groupBox1.Controls.Add(this.chkTemizlik);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(43, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(731, 258);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giderler";
            // 
            // lstGiderler
            // 
            this.lstGiderler.FormattingEnabled = true;
            this.lstGiderler.ItemHeight = 16;
            this.lstGiderler.Location = new System.Drawing.Point(43, 289);
            this.lstGiderler.Name = "lstGiderler";
            this.lstGiderler.Size = new System.Drawing.Size(199, 260);
            this.lstGiderler.TabIndex = 10;
            // 
            // lstTutar
            // 
            this.lstTutar.FormattingEnabled = true;
            this.lstTutar.ItemHeight = 16;
            this.lstTutar.Location = new System.Drawing.Point(322, 289);
            this.lstTutar.Name = "lstTutar";
            this.lstTutar.Size = new System.Drawing.Size(161, 260);
            this.lstTutar.TabIndex = 11;
            // 
            // lstTarih
            // 
            this.lstTarih.FormattingEnabled = true;
            this.lstTarih.ItemHeight = 16;
            this.lstTarih.Location = new System.Drawing.Point(613, 289);
            this.lstTarih.Name = "lstTarih";
            this.lstTarih.Size = new System.Drawing.Size(161, 260);
            this.lstTarih.TabIndex = 12;
            // 
            // Giderler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 622);
            this.Controls.Add(this.lstTarih);
            this.Controls.Add(this.lstTutar);
            this.Controls.Add(this.lstGiderler);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.Name = "Giderler";
            this.Text = "Giderler";
            this.Load += new System.EventHandler(this.Giderler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nrcTutar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkElektrik;
        private System.Windows.Forms.CheckBox chkSu;
        private System.Windows.Forms.CheckBox chkAsansor;
        private System.Windows.Forms.CheckBox chkTemizlik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nrcTutar;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstGiderler;
        private System.Windows.Forms.ListBox lstTutar;
        private System.Windows.Forms.ListBox lstTarih;
    }
}