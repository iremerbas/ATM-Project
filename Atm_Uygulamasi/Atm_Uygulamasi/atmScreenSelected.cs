using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atm_Uygulamasi
{
    public partial class atmScreenSelected : Form
    {

        public atmScreenSelected()
        {
            InitializeComponent();
        }

        private void btn_ParaCekme_Click(object sender, EventArgs e)
        {
            foreach (var process in DbContext._processTypes.ToList())
            {
                if (process.Name == "Para Çekme")
                {
                    ParaCekme paraCekme = new ParaCekme();
                    this.Hide();
                    paraCekme.ShowDialog();
                    this.Show();


                }
            }
        }

        private void btn_ParaYatırma_Click(object sender, EventArgs e)
        {

            foreach (var process in DbContext._processTypes.ToList())
            {
                if (process.Name == "Para Yatırma")
                {
                    ParaYatırma paraYatırma = new ParaYatırma();
                    this.Hide();
                    paraYatırma.ShowDialog();
                    this.Show();

                    
                }
            }
        }

        private void btn_ParaGonderme_Click(object sender, EventArgs e)
        {

            foreach (var process in DbContext._processTypes.ToList())
            {
                if (process.Name == "Para Gönderme")
                {
                    ParaGonderme paraGonderme = new ParaGonderme();
                    this.Hide();
                    paraGonderme.ShowDialog();
                    this.Show();

                 
                }
            }
        }



        private void btn_Bakiye_Click(object sender, EventArgs e)
        {

            foreach (var cstmr in DbContext._customers.ToList())
            {
                if (cstmr.openClose)
                {
                    MessageBox.Show("Bakiyeniz : "+cstmr.Balance.ToString());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Banka Bakiye : "+DbContext._banka[0].CommissionAmount.ToString());
        }

        private void atmScreenSelected_Load(object sender, EventArgs e)
        {

        }
    }
}
