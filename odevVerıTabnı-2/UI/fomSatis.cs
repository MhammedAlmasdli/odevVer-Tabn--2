using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace odevVerıTabnı_2.UI
{
    public partial class fomSatis : Form
    {
        public fomSatis()
        {
            InitializeComponent();
        }
        public Musteri Musteri { get; set; }
        public Mune Menu { get; set; }
        public satlis satlis { get; set; }


        private void textID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            if (nnfiyat.Value == 0)
            {
                errorProvider1.SetError(nnfiyat, "");
                nnfiyat.Focus();
                return;

            }
            else
            {
                errorProvider1.SetError(nnfiyat, "tüfen fiet gırınız ");
            }

             satlis.Tarih = dtTarih.Value;
            satlis.Fiyat = (double)nnfiyat.Value;

            DialogResult = DialogResult.OK;
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
        }

        private void fomSatis_Load(object sender, EventArgs e)
        {
           // textID.Text = satlis.ToString();
           // txtMusteri.Text = Musteri.ToString();
            //txtUrun.Text = Menu.ToString();
        }

        private void btnOde_Click(object sender, EventArgs e)
        {
            FormOdeme formSatis = new FormOdeme();
            Text = "Öde";

            formSatis.Show();
        }

    }
}

