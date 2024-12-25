using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odevVerıTabnı_2.UI
{
    public partial class FrmMusteri : Form
    {
        public FrmMusteri()
        {
            InitializeComponent();
        }

        private void FrmMusteri_Load(object sender, EventArgs e)
        {
            textID.Text = Musteri.ID.ToString();
            if (Guncelleme)
            {
                textAd.Text = Musteri.Ad;
                textyosAd.Text = Musteri.Soyad;
                texttel.Text = Musteri.Telefon;
                textAdres.Text = Musteri.Adres;
            }

        }

        private void iptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }
        public Musteri Musteri { get; set; }
        public bool Guncelleme { get; set; } = false;


        private void btnTamam_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(textAd)) return;
            if (!ErrorControl(textAdres)) return;
            if (!ErrorControl(texttel)) return;
            if (!ErrorControl(textAdres)) return;
           
            
            Musteri.Ad = textAd.Text;
            Musteri.Soyad = textyosAd.Text;
            Musteri.Telefon = texttel.Text;
            Musteri.Adres = textAdres.Text;



            DialogResult = DialogResult.OK;
            
        }
        private bool ErrorControl(Control c)
        {
           
            if (c is TextBox)
            {
                if (c.Text == "")
                {
                    
                    errorProvider1.SetError(c, "Eksik veya hatalı giriş!"); 
                    c.Focus(); 
                    return false; 
                }
                else
                {
                   
                    errorProvider1.SetError(c, "");
                    return true; 
                }
            }
            if (c is MaskedTextBox)
            {
                if (!((MaskedTextBox)c).MaskFull)
                {
                    errorProvider1.SetError(c, "Eksik veya hatalı bilgi!");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, "");
                    return true;
                }
            }

            return true;
        }
        private void textAd_TextChanged(object sender, EventArgs e)
        {
         
        }

    }
}
