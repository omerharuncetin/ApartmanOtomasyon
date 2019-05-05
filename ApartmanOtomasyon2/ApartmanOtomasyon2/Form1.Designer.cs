namespace ApartmanOtomasyon2
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
            this.btnGelirler = new System.Windows.Forms.Button();
            this.btnGiderler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGelirler
            // 
            this.btnGelirler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGelirler.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGelirler.Location = new System.Drawing.Point(57, 50);
            this.btnGelirler.Name = "btnGelirler";
            this.btnGelirler.Size = new System.Drawing.Size(199, 355);
            this.btnGelirler.TabIndex = 0;
            this.btnGelirler.Text = "Gelirler";
            this.btnGelirler.UseVisualStyleBackColor = true;
            this.btnGelirler.Click += new System.EventHandler(this.BtnGelirler_Click);
            // 
            // btnGiderler
            // 
            this.btnGiderler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiderler.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiderler.Location = new System.Drawing.Point(378, 50);
            this.btnGiderler.Name = "btnGiderler";
            this.btnGiderler.Size = new System.Drawing.Size(199, 355);
            this.btnGiderler.TabIndex = 1;
            this.btnGiderler.Text = "Giderler";
            this.btnGiderler.UseVisualStyleBackColor = true;
            this.btnGiderler.Click += new System.EventHandler(this.BtnGiderler_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(658, 464);
            this.Controls.Add(this.btnGiderler);
            this.Controls.Add(this.btnGelirler);
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.Name = "Form1";
            this.Text = "Apartman Otomasyon";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGelirler;
        private System.Windows.Forms.Button btnGiderler;
    }
}

