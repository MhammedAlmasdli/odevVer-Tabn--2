namespace odevVerıTabnı_2.UI
{
    partial class ForMenu
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
            this.components = new System.ComponentModel.Container();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.textAd = new System.Windows.Forms.TextBox();
            this.textacklama = new System.Windows.Forms.TextBox();
            this.btnTamam = new System.Windows.Forms.Button();
            this.btniptal = new System.Windows.Forms.Button();
            this.cbkatgori = new System.Windows.Forms.ComboBox();
            this.nnfiyat = new System.Windows.Forms.NumericUpDown();
            this.nnadat = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nnfiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nnadat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Datay";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "fiyat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "kadgori";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "urun";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(63, 12);
            this.textID.Name = "textID";
            this.textID.ReadOnly = true;
            this.textID.Size = new System.Drawing.Size(273, 24);
            this.textID.TabIndex = 0;
            // 
            // textAd
            // 
            this.textAd.Location = new System.Drawing.Point(63, 42);
            this.textAd.Name = "textAd";
            this.textAd.Size = new System.Drawing.Size(273, 24);
            this.textAd.TabIndex = 1;
            // 
            // textacklama
            // 
            this.textacklama.Location = new System.Drawing.Point(63, 165);
            this.textacklama.Multiline = true;
            this.textacklama.Name = "textacklama";
            this.textacklama.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textacklama.Size = new System.Drawing.Size(274, 108);
            this.textacklama.TabIndex = 5;
            // 
            // btnTamam
            // 
            this.btnTamam.Location = new System.Drawing.Point(137, 300);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(87, 58);
            this.btnTamam.TabIndex = 6;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // btniptal
            // 
            this.btniptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btniptal.Location = new System.Drawing.Point(244, 300);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(92, 58);
            this.btniptal.TabIndex = 7;
            this.btniptal.Text = "iptal";
            this.btniptal.UseVisualStyleBackColor = true;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // cbkatgori
            // 
            this.cbkatgori.FormattingEnabled = true;
            this.cbkatgori.Items.AddRange(new object[] {
            "Türk Kahvesi",
            "Espresso",
            "Latte ",
            "Cappuccino ",
            "Americano ",
            "Mocha",
            "Macchiato ",
            "Flat White",
            "Cortado",
            "Affogato ",
            "şay"});
            this.cbkatgori.Location = new System.Drawing.Point(63, 73);
            this.cbkatgori.Name = "cbkatgori";
            this.cbkatgori.Size = new System.Drawing.Size(274, 24);
            this.cbkatgori.TabIndex = 2;
            // 
            // nnfiyat
            // 
            this.nnfiyat.Location = new System.Drawing.Point(63, 102);
            this.nnfiyat.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nnfiyat.Name = "nnfiyat";
            this.nnfiyat.Size = new System.Drawing.Size(274, 24);
            this.nnfiyat.TabIndex = 3;
            // 
            // nnadat
            // 
            this.nnadat.Location = new System.Drawing.Point(63, 132);
            this.nnadat.Name = "nnadat";
            this.nnadat.Size = new System.Drawing.Size(274, 24);
            this.nnadat.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "adat";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ForMenu
            // 
            this.AcceptButton = this.btnTamam;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btniptal;
            this.ClientSize = new System.Drawing.Size(373, 399);
            this.Controls.Add(this.nnadat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nnfiyat);
            this.Controls.Add(this.cbkatgori);
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.textacklama);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ForMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ForMenu";
            this.Load += new System.EventHandler(this.ForMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nnfiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nnadat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textAd;
        private System.Windows.Forms.TextBox textacklama;
        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.Button btniptal;
        private System.Windows.Forms.ComboBox cbkatgori;
        private System.Windows.Forms.NumericUpDown nnfiyat;
        private System.Windows.Forms.NumericUpDown nnadat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}