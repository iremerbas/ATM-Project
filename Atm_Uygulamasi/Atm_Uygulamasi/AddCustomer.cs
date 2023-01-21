using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atm_Uygulamasi
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }
        Customer customer = new Customer();
        CustomerProcess customerProcess = new CustomerProcess();
        private void button1_Click(object sender, EventArgs e)
        {

            Customer customer = new Customer();

            if (!String.IsNullOrWhiteSpace(txt_Name.Text) && !String.IsNullOrWhiteSpace(txt_Surname.Text) &&
                !String.IsNullOrWhiteSpace(txtCustomerNumber.Text) && !String.IsNullOrWhiteSpace(txt_Password.Text) &&
              !String.IsNullOrWhiteSpace(txt_Balance.Text) && !String.IsNullOrWhiteSpace(txt_CustomerTypeId.Text))
            {
                customer.Id = Convert.ToInt32(3);
                customer.Name = txt_Name.Text;
                customer.Surname = txt_Surname.Text;
                customer.CustomerNumber = Convert.ToInt32(txtCustomerNumber.Text);
                customer.Password = txt_Password.Text;
                customer.Balance = Convert.ToDouble(txt_Balance.Text);
                customer.customerTypeId = Convert.ToInt32(txt_CustomerTypeId.Text);

                if (customerProcess.Add(customer))
                {
                    MessageBox.Show("Customer Add Successful");
                    customer.Id++;
                    txt_Name.Clear();
                    txt_Surname.Clear();
                    txtCustomerNumber.Clear();
                    txt_Password.Clear();
                    txt_Balance.Clear();
                    txt_CustomerTypeId.Clear();
                    customerList();
                }
                else
                {
                    MessageBox.Show("Customer Add Failed");
                }
            }
            else
            {
                MessageBox.Show("Değerler Boş geçilemez");
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            customerList();
        }

        public void customerList()
        {
            CustomerLb.Items.Clear();

            foreach (var customer in customerProcess.List().ToList())
            {
                CustomerLb.Items.Add(customer.CustomerNumber + "  " + customer.Name + " " + customer.Surname);
            }
        }
    }
}
