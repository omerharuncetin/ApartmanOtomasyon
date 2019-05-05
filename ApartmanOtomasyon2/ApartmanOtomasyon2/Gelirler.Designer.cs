namespace ApartmanOtomasyon2
{
    partial class Gelirler
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDaireNo = new System.Windows.Forms.ComboBox();
            this.nrcTutar = new System.Windows.Forms.NumericUpDown();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstDaireNo = new System.Windows.Forms.ListBox();
            this.lstTutar = new System.Windows.Forms.ListBox();
            this.lstTarih = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nrcTutar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Daire no:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tutar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(345, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tarih:";
            // 
            // cmbDaireNo
            // 
            this.cmbDaireNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDaireNo.FormattingEnabled = true;
            this.cmbDaireNo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbDaireNo.Location = new System.Drawing.Point(124, 59);
            this.cmbDaireNo.Name = "cmbDaireNo";
            this.cmbDaireNo.Size = new System.Drawing.Size(176, 28);
            this.cmbDaireNo.TabIndex = 3;
            // 
            // nrcTutar
            // 
            this.nrcTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nrcTutar.Location = new System.Drawing.Point(124, 113);
            this.nrcTutar.Name = "nrcTutar";
            this.nrcTutar.Size = new System.Drawing.Size(176, 27);
            this.nrcTutar.TabIndex = 4;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpTarih.Location = new System.Drawing.Point(439, 57);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(246, 27);
            this.dtpTarih.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(439, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 53);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpTarih);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nrcTutar);
            this.groupBox1.Controls.Add(this.cmbDaireNo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(39, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 259);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gelirler";
            // 
            // lstDaireNo
            // 
            this.lstDaireNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstDaireNo.FormattingEnabled = true;
            this.lstDaireNo.ItemHeight = 20;
            this.lstDaireNo.Location = new System.Drawing.Point(39, 300);
            this.lstDaireNo.Name = "lstDaireNo";
            this.lstDaireNo.Size = new System.Drawing.Size(161, 284);
            this.lstDaireNo.TabIndex = 8;
            // 
            // lstTutar
            // 
            this.lstTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstTutar.FormattingEnabled = true;
            this.lstTutar.ItemHeight = 20;
            this.lstTutar.Location = new System.Drawing.Point(311, 300);
            this.lstTutar.Name = "lstTutar";
            this.lstTutar.Size = new System.Drawing.Size(161, 284);
            this.lstTutar.TabIndex = 9;
            // 
            // lstTarih
            // 
            this.lstTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstTarih.FormattingEnabled = true;
            this.lstTarih.ItemHeight = 20;
            this.lstTarih.Location = new System.Drawing.Point(579, 300);
            this.lstTarih.Name = "lstTarih";
            this.lstTarih.Size = new System.Drawing.Size(161, 284);
            this.lstTarih.TabIndex = 10;
            // 
            // Gelirler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 622);
            this.Controls.Add(this.lstTarih);
            this.Controls.Add(this.lstTutar);
            this.Controls.Add(this.lstDaireNo);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.Name = "Gelirler";
            this.Text = "Gelirler";
            this.Load += new System.EventHandler(this.Gelirler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nrcTutar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDaireNo;
        private System.Windows.Forms.NumericUpDown nrcTutar;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstDaireNo;
        private System.Windows.Forms.ListBox lstTutar;
        private System.Windows.Forms.ListBox lstTarih;
    }
}