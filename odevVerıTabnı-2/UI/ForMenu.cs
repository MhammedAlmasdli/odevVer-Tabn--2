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
    public partial class ForMenu : Form
    {
        public ForMenu()
        {
            InitializeComponent();
        }

        private void ForMenu_Load(object sender, EventArgs e)
        {

        }
        public Mune Mune { get; set; }



            private void btnTamam_Click(object sender, EventArgs e)
        {
            
            if (!ErrorControl(textAd)) return;
            if (!ErrorControl(nnfiyat)) return;
            if (!ErrorControl(nnadat)) return;
            if (!ErrorControl(textacklama)) return;


            Mune.Ad = textAd.Text;
           Mune.Fiyat = (double)nnfiyat.Value;
             Mune.Kategori = cbkatgori.Text;
            Mune.adat = (double)nnadat.Value;
            Mune.Detay = textacklama.Text;




            DialogResult = DialogResult.OK;

        }
        
        private bool ErrorControl(Control c)
        {
            if (c is TextBox || c is ComboBox)
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

            if (c is NumericUpDown)
            {
                if (((NumericUpDown)c).Value == 0)
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


        private void btniptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
   

   

}
