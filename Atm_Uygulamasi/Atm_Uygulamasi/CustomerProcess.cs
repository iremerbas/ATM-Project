using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atm_Uygulamasi
{
    internal class CustomerProcess : Icrud<Customer>
    {
        public bool Add(Customer obj)
        {
            Customer customer = obj;
            if (customer != null)
            {
                DbContext._customers.Add(customer);
                return true;
            }
            else return false;
        }

        public bool Delete(int id)
        {
            bool IsDelete = false;
            foreach (var customer in DbContext._customers.ToList())
            {
                if (customer.Id == id)
                {
                    DbContext._customers.Remove(customer);
                    IsDelete = true;
                    break;

                }
            }
            return IsDelete;
        }

        public Customer Detail(int id)
        {
            Customer customerDetail = null;
            foreach (var customer in DbContext._customers.ToList())
            {
                if (customer.Id == id)
                {
                    customerDetail = customer;
                    break;

                }
            }
            return customerDetail;

        }

        public List<Customer> List()
        {
            List<Customer> customers = DbContext._customers.ToList();
            return customers;
        }
    }
}
