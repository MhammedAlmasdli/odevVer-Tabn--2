using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using odevVerıTabnı_2.BL;
using odevVerıTabnı_2.UI;

namespace odevVerıTabnı_2
{
    public partial class Anaforum : Form
    {
        public object Logic { get; private set; }

        public Anaforum()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {



        }

        private void btnMusterıDuznle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];

            FrmMusteri frmMusteri = new FrmMusteri()
            {
                Text = "Müşteri Güncelle",
                Guncelleme = true,
                Musteri = new Musteri()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    Ad = row.Cells[1].Value.ToString(),
                    Soyad = row.Cells[2].Value.ToString(),
                    Telefon = row.Cells[3].Value.ToString(),
                    Adres = row.Cells[4].Value.ToString()
                }
            };

            var sonuc = frmMusteri.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.MusteriGuncelle(frmMusteri.Musteri);

                if (b)
                {
                    row.Cells[1].Value = frmMusteri.Musteri.Ad;
                    row.Cells[2].Value = frmMusteri.Musteri.Soyad;
                    row.Cells[3].Value = frmMusteri.Musteri.Telefon;
                    row.Cells[4].Value = frmMusteri.Musteri.Adres;

                }
            }


        }

        private void btnMusterıEkle_Click(object sender, EventArgs e)
        {
            FrmMusteri frmMusteri = new FrmMusteri()
            {
                Text = "MusteriEkle",
                Musteri = new Musteri() { ID = Guid.NewGuid() }
            };

            var sonuc = frmMusteri.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.MusteriEkle(frmMusteri.Musteri);
                if (b)
                {
                    DataSet ds = BLogic.MusteriGetir("");
                    dataGridView2.DataSource = ds.Tables[0];

                }


            }



        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.MusteriGetir(toolStripTextBox1.Text);
            if (ds != null)
                dataGridView2.DataSource = ds.Tables[0];

        }
        private void AnaForm_Load(object sender, EventArgs e)
        {
            DataSet ds = BLogic.MusteriGetir("");
            if (ds != null)
                dataGridView2.DataSource = ds.Tables[0];
           
            DataSet ds2 = BLogic.UrunGetir("");
            if (ds2 != null)
                dataGridView2.DataSource = ds2.Tables[0];

        }

        private void btnMusterSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();

            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Silme Onayı",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.MusteriSil(ID);

                if (b)
                {
                    DataSet ds = BLogic.MusteriGetir("");
                    if (ds != null)
                        dataGridView2.DataSource = ds.Tables[0];
                }
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
           
        }
        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            ForMenu frmMenu = new ForMenu()
            {
                Text = "Ürün Ekle",
                Mune = new Mune() { ID = Guid.NewGuid() } 
            };

            var sonuc = frmMenu.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
       
                bool b = BLogic.UrunEkle(frmMenu.Mune);

                if (b)
                {
                    DataSet ds2 = BLogic.MusteriGetir("");
                    if (ds2 != null)
                    {
                        dataGridView2.DataSource = ds2.Tables[0];
                    }
                }
                
            }
        }

        private void btnStasanlar_Click(object sender, EventArgs e)
        {
          
            fomSatis formSatis = new fomSatis();
            Text = "Satış yap";

                formSatis.Show();
            }

        }
    }



