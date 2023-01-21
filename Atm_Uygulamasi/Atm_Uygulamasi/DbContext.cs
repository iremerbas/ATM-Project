using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atm_Uygulamasi
{
    internal class DbContext
    {
        public static List<Customer> _customers = new List<Customer>();
        public static List<CustomerType> _customersType = new List<CustomerType>();
        public static List<Process> _processes = new List<Process>();
        public static List<ProcessType> _processTypes = new List<ProcessType>();
        public static List<Banka> _banka = new List<Banka>();

        public DbContext()
        {
            Customer customer = new Customer()
            {
                Id = 1,
                CustomerNumber = 123456,
                Name = "irem",
                Surname = "erbas",
                Balance = 10000,
                Password = "123456",
                customerTypeId = 1,
               

            };
            _customers.Add(customer);

            Customer customer1 = new Customer()
            {
                Id = 2,
                CustomerNumber = 234567,
                Name = "eymen",
                Surname = "erbas",
                Balance = 20000,
                Password = "234567",
                customerTypeId = 2

            };
            _customers.Add(customer1);


            CustomerType customerType = new CustomerType()
            {
                Id = 1,
                Name = "Bireysel",
                CommissionRate = 0.05

            };
            _customersType.Add(customerType);


            CustomerType customerType1 = new CustomerType()
            {
                Id = 2,
                Name = "Kurumsal",
                CommissionRate = 0.01

            };
            _customersType.Add(customerType1);

            ProcessType processTypes = new ProcessType()
            {
                Id = 1,
                Name = "Para Çekme"
            };
            _processTypes.Add(processTypes);


            ProcessType processTypes1 = new ProcessType()
            {
                Id = 2,
                Name = "Para Yatırma"
            };
            _processTypes.Add(processTypes1);

            ProcessType processTypes2 = new ProcessType()
            {
                Id = 3,
                Name = "Para Gönderme"
            };
            _processTypes.Add(processTypes2);


            ProcessType processTypes3 = new ProcessType()
            {
                Id = 4,
                Name = "Para Alma"
            };
            _processTypes.Add(processTypes3);


            Banka banka = new Banka()
            {
                Id = 1,
                Name = "IremBank",
                CommissionAmount = 10000,
            };
            _banka.Add(banka);
        }
    }





}

