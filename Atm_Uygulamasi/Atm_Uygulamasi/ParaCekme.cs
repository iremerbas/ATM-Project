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
    public partial class ParaCekme : Form
    {
        public ParaCekme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var cstmr in DbContext._customers.ToList())
            {
                if (cstmr.openClose)
                {
                    if(cstmr.Balance>= Convert.ToDouble(textBox1.Text))
                    {
                        cstmr.Balance -= Convert.ToDouble(textBox1.Text);
                        MessageBox.Show("Kalan bakiyeniz : \n"+cstmr.Balance.ToString());
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Yeterli bakiyeniz bulunmamaktadır.");
                    }
                }
            }
        }
    }
}
