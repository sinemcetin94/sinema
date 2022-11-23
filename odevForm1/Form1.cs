using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odevForm1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            n:
            int toplam = 0;
            int misir = 0;
            int su = 0;
            int cay = 0;
            int bilet = 0;
           

            if(txtmisir.Text == "" || txtsu.Text == "" || txtcay.Text=="" || txtbilet.Text== "" || 
                txtmisir.Text==String.Empty || txtsu.Text==String.Empty || txtcay.Text==String.Empty || txtbilet.Text==String.Empty)
            {
                txtmisir.BackColor = Color.Cyan;
                txtsu.BackColor = Color.Cyan;
                txtcay.BackColor = Color.Cyan;
                txtbilet.BackColor = Color.Cyan;
                MessageBox.Show("Renkli Alanlar Boş Geçilemez", "Boş Alan Hatası");
            }
            else
            {
                misir = Convert.ToInt32(txtmisir.Text);
                su = Convert.ToInt32(txtsu.Text);
                cay = Convert.ToInt32(txtcay.Text);
                bilet = Convert.ToInt32(txtbilet.Text);

                toplam = misir * 20 + su * 5 + cay * 7 + bilet * 50;

                txtHesap.Text = toplam.ToString();

                txtmisir.Clear();
                txtsu.Clear();
                txtcay.Clear();
                txtbilet.Clear();
            }

            
      
          

        }
    }
}
