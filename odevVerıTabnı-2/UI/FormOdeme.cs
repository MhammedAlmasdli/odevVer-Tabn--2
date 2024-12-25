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
    public partial class FormOdeme : Form
    {
        public FormOdeme()
        {
            InitializeComponent();
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
           
            DialogResult = DialogResult.Cancel;
        }
        public Odeme odeme { get; set; }
        private void btnTamam_Click(object sender, EventArgs e)
        {
            if (nntutar.Value == 0)
            {
                errorProvider1.SetError(nntutar, "");
                nntutar.Focus();
                return;

            }
            else
            {
                errorProvider1.SetError(nntutar, "tüfen fiet gırınız ");
            }
            if (cbTur.SelectedItem == null)
            {
                errorProvider1.SetError(cbTur, "Ödeme türü seçin!");
                cbTur.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(cbTur, "");
            }
            if (txtAciklama.Text == "")
            {
                errorProvider1.SetError(txtAciklama, "Eksik veya hatalı bilgi");
                txtAciklama.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtAciklama, "");
            }
            odeme.Tur = cbTur.SelectedItem.ToString();
            odeme.Tutar = (double)nntutar.Value;
            odeme.Aciklama = txtAciklama.Text;
            odeme.Tarih = dtTarih.Value;



            DialogResult = DialogResult.OK;
        }
    }
}
   

