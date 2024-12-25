namespace odevVerıTabnı_2
{
    partial class Anaforum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anaforum));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnStasanlar = new System.Windows.Forms.Button();
            this.btnurunekle = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnUrun = new System.Windows.Forms.ToolStripButton();
            this.btnUrunduznle = new System.Windows.Forms.ToolStripButton();
            this.btnurunsil = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.btnurunBol = new System.Windows.Forms.ToolStripButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnMusterıEkle = new System.Windows.Forms.ToolStripButton();
            this.btnMusterıDuznle = new System.Windows.Forms.ToolStripButton();
            this.btnMusterSil = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.mySqlConnection1 = new MySql.Data.MySqlClient.MySqlConnection();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnurunekle)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(849, 494);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnStasanlar);
            this.tabPage2.Controls.Add(this.btnurunekle);
            this.tabPage2.Controls.Add(this.toolStrip2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(841, 465);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ürunler";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnStasanlar
            // 
            this.btnStasanlar.Location = new System.Drawing.Point(8, 318);
            this.btnStasanlar.Name = "btnStasanlar";
            this.btnStasanlar.Size = new System.Drawing.Size(249, 126);
            this.btnStasanlar.TabIndex = 3;
            this.btnStasanlar.Text = "satışnlar";
            this.btnStasanlar.UseVisualStyleBackColor = true;
            this.btnStasanlar.Click += new System.EventHandler(this.btnStasanlar_Click);
            // 
            // btnurunekle
            // 
            this.btnurunekle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.btnurunekle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnurunekle.Location = new System.Drawing.Point(3, 30);
            this.btnurunekle.Name = "btnurunekle";
            this.btnurunekle.RowHeadersWidth = 51;
            this.btnurunekle.RowTemplate.Height = 26;
            this.btnurunekle.Size = new System.Drawing.Size(835, 432);
            this.btnurunekle.TabIndex = 2;
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUrun,
            this.btnUrunduznle,
            this.btnurunsil,
            this.toolStripLabel2,
            this.toolStripTextBox2,
            this.btnurunBol});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(835, 27);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "Eklee";
            // 
            // btnUrun
            // 
            this.btnUrun.Image = ((System.Drawing.Image)(resources.GetObject("btnUrun.Image")));
            this.btnUrun.ImageTransparentColor = System.Drawing.Color.DarkViolet;
            this.btnUrun.Name = "btnUrun";
            this.btnUrun.Size = new System.Drawing.Size(60, 24);
            this.btnUrun.Text = "Ekle";
            this.btnUrun.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // btnUrunduznle
            // 
            this.btnUrunduznle.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunduznle.Image")));
            this.btnUrunduznle.ImageTransparentColor = System.Drawing.Color.DarkViolet;
            this.btnUrunduznle.Name = "btnUrunduznle";
            this.btnUrunduznle.Size = new System.Drawing.Size(79, 24);
            this.btnUrunduznle.Text = "Düznle";
            // 
            // btnurunsil
            // 
            this.btnurunsil.Image = ((System.Drawing.Image)(resources.GetObject("btnurunsil.Image")));
            this.btnurunsil.ImageTransparentColor = System.Drawing.Color.DarkViolet;
            this.btnurunsil.Name = "btnurunsil";
            this.btnurunsil.Size = new System.Drawing.Size(49, 24);
            this.btnurunsil.Text = "Sil";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(35, 24);
            this.toolStripLabel2.Text = "Ara:";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.AutoSize = false;
            this.toolStripTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(150, 27);
            // 
            // btnurunBol
            // 
            this.btnurunBol.Image = ((System.Drawing.Image)(resources.GetObject("btnurunBol.Image")));
            this.btnurunBol.ImageTransparentColor = System.Drawing.Color.DarkViolet;
            this.btnurunBol.Name = "btnurunBol";
            this.btnurunBol.Size = new System.Drawing.Size(54, 24);
            this.btnurunBol.Text = "Bul";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(841, 465);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Muşteiler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2.Location = new System.Drawing.Point(3, 30);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 26;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(835, 432);
            this.dataGridView2.StandardTab = true;
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMusterıEkle,
            this.btnMusterıDuznle,
            this.btnMusterSil,
            this.toolStripLabel1,
            this.toolStripTextBox1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(835, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "Ekle";
            // 
            // btnMusterıEkle
            // 
            this.btnMusterıEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnMusterıEkle.Image")));
            this.btnMusterıEkle.ImageTransparentColor = System.Drawing.Color.DarkViolet;
            this.btnMusterıEkle.Name = "btnMusterıEkle";
            this.btnMusterıEkle.Size = new System.Drawing.Size(60, 24);
            this.btnMusterıEkle.Text = "Ekle";
            this.btnMusterıEkle.Click += new System.EventHandler(this.btnMusterıEkle_Click);
            // 
            // btnMusterıDuznle
            // 
            this.btnMusterıDuznle.Image = ((System.Drawing.Image)(resources.GetObject("btnMusterıDuznle.Image")));
            this.btnMusterıDuznle.ImageTransparentColor = System.Drawing.Color.DarkViolet;
            this.btnMusterıDuznle.Name = "btnMusterıDuznle";
            this.btnMusterıDuznle.Size = new System.Drawing.Size(79, 24);
            this.btnMusterıDuznle.Text = "Düznle";
            this.btnMusterıDuznle.Click += new System.EventHandler(this.btnMusterıDuznle_Click);
            // 
            // btnMusterSil
            // 
            this.btnMusterSil.Image = ((System.Drawing.Image)(resources.GetObject("btnMusterSil.Image")));
            this.btnMusterSil.ImageTransparentColor = System.Drawing.Color.DarkViolet;
            this.btnMusterSil.Name = "btnMusterSil";
            this.btnMusterSil.Size = new System.Drawing.Size(49, 24);
            this.btnMusterSil.Text = "Sil";
            this.btnMusterSil.Click += new System.EventHandler(this.btnMusterSil_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 24);
            this.toolStripLabel1.Text = "Ara:";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(150, 27);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.DarkViolet;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(54, 24);
            this.toolStripButton2.Text = "Bul";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 472);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(849, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Anaforum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 494);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Anaforum";
            this.Text = "Coffee Sitesi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnurunekle)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripButton btnMusterıEkle;
        private System.Windows.Forms.ToolStripButton btnMusterıDuznle;
        private System.Windows.Forms.ToolStripButton btnMusterSil;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnUrun;
        private System.Windows.Forms.ToolStripButton btnUrunduznle;
        private System.Windows.Forms.ToolStripButton btnurunsil;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.DataGridView btnurunekle;
        private System.Windows.Forms.ToolStripButton btnurunBol;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection1;
        private System.Windows.Forms.Button btnStasanlar;
    }
}

