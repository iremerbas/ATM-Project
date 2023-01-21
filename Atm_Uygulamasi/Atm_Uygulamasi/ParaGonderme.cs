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
    public partial class ParaGonderme : Form
    {
        bool IsReciver = false;
        CustomerType CustomerType = new CustomerType();
        public ParaGonderme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var reciver in DbContext._customers.ToList())
            {
                if (reciver.CustomerNumber.ToString() == txt_gönderilecekKisi.Text)
                {
                    IsReciver = true;
                    break;
                }
            }
            if (IsReciver)
            {
                foreach (var cstmr in DbContext._customers.ToList())
                {
                    if (cstmr.openClose)
                    {
                        if (cstmr.Balance >= Convert.ToDouble(textBox1.Text))
                        {
                            if (cstmr.customerTypeId == 1)
                            {
                                double money = DbContext._customersType[0].CommissionRate * Convert.ToInt32(textBox1.Text);

                                DbContext._banka[0].CommissionAmount += money;
                                cstmr.Balance -= (Convert.ToDouble(textBox1.Text) + money);
                                MessageBox.Show("Kalan bakiyeniz : "+cstmr.Balance.ToString());

                                foreach (var reciever in DbContext._customers.ToList())
                                {
                                    if (reciever.CustomerNumber.ToString() == txt_gönderilecekKisi.Text)
                                    {
                                        reciever.Balance += Convert.ToInt32(textBox1.Text);
                                        MessageBox.Show(txt_gönderilecekKisi.Text + " Numaralı müşterinin Güncel Bakiyesi : \n" + reciever.Balance.ToString());
                                        break;
                                    }
                                }
                            }
                            else if (cstmr.customerTypeId == 2)
                            {
                                double money = DbContext._customersType[1].CommissionRate * Convert.ToInt32(textBox1.Text);
                                DbContext._banka[0].CommissionAmount += money;
                                cstmr.Balance -= Convert.ToDouble(textBox1.Text);
                                MessageBox.Show("Kalan bakiyeniz: "+ cstmr.Balance.ToString());
                                foreach (var reciever in DbContext._customers.ToList())
                                {
                                    if (reciever.CustomerNumber.ToString() == txt_gönderilecekKisi.Text)
                                    {
                                        reciever.Balance += Convert.ToInt32(textBox1.Text);
                                        MessageBox.Show(txt_gönderilecekKisi.Text + " Numaralı müşterinin Güncel Bakiyesi : \n" + reciever.Balance.ToString());
                                        break;
                                    }
                                }
                            }
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Bakiyeniz yetersiz");
                        }

                    }
                }
               
            }
            else
            {
                MessageBox.Show("Kullanici bulunamadi.");
            }
           











        }

  
    }

}
