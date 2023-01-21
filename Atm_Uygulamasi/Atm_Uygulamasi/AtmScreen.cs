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
    public partial class AtmScreen : Form
    {

        Customer customer = new Customer()
        {
            ErrorPasswordEntryCount = 0
        };

        bool status = false;
        //  Customer customer = new Customer();

        public AtmScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DbContext._customers.Add(customer);


            foreach (var customers in DbContext._customers.ToList())
            {
                if (txt_CustomerNumber.Text == customers.CustomerNumber.ToString() && txt_CustomerPassword.Text == customers.Password.ToString())
                {
                    status = true;
                    customers.openClose = true;
                    txt_CustomerNumber.Clear();
                    txt_CustomerPassword.Clear();
                }

            }

            if (status)
            {

                atmScreenSelected atmScreenSelected = new atmScreenSelected();
                
                this.Hide();
                atmScreenSelected.ShowDialog();              
                this.Show();

                status = false;
            }
            else
            {
                if (customer.ErrorPasswordEntryCount < 3)
                {
                    MessageBox.Show("Hatalı Giriş");
                    customer.ErrorPasswordEntryCount++;
                }
                if (customer.ErrorPasswordEntryCount == 3)
                {
                    MessageBox.Show("Hesabınız bloke olmuştur");
                }
            }

        }

        private void AtmScreen_Load(object sender, EventArgs e)
        {
            DbContext db = new DbContext();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            status = false;
            AddCustomer addCustomer = new AddCustomer();
            this.Hide();
            addCustomer.ShowDialog();
            this.Show();

        }
    }
}
